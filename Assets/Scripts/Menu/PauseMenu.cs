using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject menu;

    private bool _isPaused;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MenuInGame();
        }
    }

    private void MenuInGame()
    {
        _isPaused = !_isPaused;
        menu.SetActive(_isPaused);

        Pause(_isPaused);
    }

    public void Pause(bool pause)
    {
        Cursor.visible = pause;
        
        if (pause)
        {
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1;
        }
    }
}
