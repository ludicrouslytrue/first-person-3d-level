using UnityEngine;

public class CrosshairAndCursor : MonoBehaviour
{
    public Texture2D crosshairTexture;
    private bool cursorLocked = true;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleCursor();
        }
    }

    void ToggleCursor()
    {
        cursorLocked = !cursorLocked;
        Cursor.lockState = cursorLocked ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !cursorLocked;
    }

    void OnGUI()
    {
        if (cursorLocked && crosshairTexture)
        {
            float xPos = (Screen.width - crosshairTexture.width) / 2;
            float yPos = (Screen.height - crosshairTexture.height) / 2;
            GUI.DrawTexture(new Rect(xPos, yPos, crosshairTexture.width, crosshairTexture.height), crosshairTexture);
        }
    }
}
