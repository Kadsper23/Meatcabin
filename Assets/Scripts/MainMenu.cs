using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Show cursor and unlock it when entering the main menu
        SetCursorVisibility(true);
    }

    public void PlayGame()
    {
        // Transition to gameplay scene
        SceneManager.LoadScene("Cabin");

        // Hide cursor for gameplay
        SetCursorVisibility(false);
    }

    public void QuitGame()
    {
        // Quit application
        Application.Quit();
    }

    // Helper method to set cursor visibility and lock state
    private void SetCursorVisibility(bool isVisible)
    {
        if (isVisible)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}

