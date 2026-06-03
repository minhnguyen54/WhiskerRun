using TMPro;
using UnityEngine;
using UnityEngine.UI;

[DefaultExecutionOrder(-1)]
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public float initialGameSpeed = 5f;
    public float gameSpeedIncrease = 0.4f;
    public float gameSpeed { get; private set; }

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;
    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private Button retryButton;
    [SerializeField] private TextMeshProUGUI startText;

    private Player player;
    private Spawner spawner;

    private float score;
    public float Score => score;

    private bool hasStarted;
    public bool HasStarted => hasStarted;

    private void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    private void Start()
    {
        player = FindFirstObjectByType<Player>();
        spawner = FindFirstObjectByType<Spawner>();

        NewGame();
    }

    public void NewGame()
    {
        CancelInvoke();
        Obstacle[] obstacles = FindObjectsByType<Obstacle>(FindObjectsSortMode.None);

        foreach (var obstacle in obstacles)
        {
            Destroy(obstacle.gameObject);
        }

        score = 0f;
        gameSpeed = initialGameSpeed;
        enabled = true;

        player.gameObject.SetActive(true);
        spawner.gameObject.SetActive(true);
        startText.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(false);
        retryButton.gameObject.SetActive(false);

        hasStarted = false;
        spawner.CancelInvoke();

        UpdateHighScore();
    }

    public void GameOver()
    {
        gameSpeed = 0f;
        enabled = false;

        player.gameObject.SetActive(false);
        spawner.CancelInvoke();
        spawner.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(true);
        retryButton.gameObject.SetActive(true);

        UpdateHighScore();
    }

    private void Update()
    {
        if (!hasStarted)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                hasStarted = true;
                startText.gameObject.SetActive(false);
                spawner.StartSpawning();
            }

            return;
        }

        gameSpeed += gameSpeedIncrease * Time.deltaTime;
        score += gameSpeed * Time.deltaTime;
        scoreText.text = Mathf.FloorToInt(score).ToString("D5");
    }

    private void UpdateHighScore()
    {
        // Keep the original PlayerPrefs key so existing local high scores survive project polish.
        const string highScoreKey = "hiscore";
        float highScore = PlayerPrefs.GetFloat(highScoreKey, 0);

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetFloat(highScoreKey, highScore);
        }

        highScoreText.text = Mathf.FloorToInt(highScore).ToString("D5");
    }

}
