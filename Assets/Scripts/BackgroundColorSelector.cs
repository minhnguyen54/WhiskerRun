using UnityEngine;
using TMPro;

public class BackgroundColorSelector : MonoBehaviour
{
    public Camera mainCamera;
    public TMP_Dropdown dropdown;

    public void ChangeBackground()
    {
        if (mainCamera == null || dropdown == null)
        {
            return;
        }

        switch (dropdown.value)
        {
            case 0: // Default
                mainCamera.backgroundColor = new Color32(214, 214, 214, 255); // #D6D6D6
                break;
            case 1: // Red
                mainCamera.backgroundColor = Color.red;
                break;
            case 2: // Blue
                mainCamera.backgroundColor = Color.blue;
                break;
            case 3: // Green
                mainCamera.backgroundColor = Color.green;
                break;
            case 4: // Yellow
                mainCamera.backgroundColor = Color.yellow;
                break;
            case 5: // Purple
                mainCamera.backgroundColor = new Color32(128, 0, 128, 255); // Custom purple
                break;
            default:
                mainCamera.backgroundColor = new Color32(214, 214, 214, 255);
                break;
        }
    }
}
