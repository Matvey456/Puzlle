using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Button startButton, settingButton, quitButton;
    [SerializeField] private GameObject mainMenu, settingsMenu;
    
    private void Start()
    {
        startButton.onClick.AddListener(StartGame);
        settingButton.onClick.AddListener(SettingsGame);
        quitButton.onClick.AddListener(QuitGame);
    }

    private void StartGame() => SceneManager.LoadScene(1);

    private void SettingsGame()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    private void QuitGame() => Application.Quit();
}
