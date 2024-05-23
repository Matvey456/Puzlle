using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] private PauseMenu pauseMenu;
    [SerializeField] private UnityEngine.UI.Button continueButton, mainMenuButton;

    private void Start()
    {
        continueButton.onClick.AddListener(ContinueGame);
        mainMenuButton.onClick.AddListener(ToMainMenu);
    }

    private void ContinueGame()
    {
        pauseMenu.Pause(false);
        pauseMenu.menu.SetActive(false);
    }

    private void ToMainMenu()
    {
        pauseMenu.Pause(false);
        SceneManager.LoadScene(0);

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
