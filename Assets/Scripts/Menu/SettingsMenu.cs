using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu, settingsMenu;
    [SerializeField] private UnityEngine.UI.Button backButton;
    
    private void Start()
    {
        backButton.onClick.AddListener(BackToMenu);
    }

    private void BackToMenu()
    {
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
