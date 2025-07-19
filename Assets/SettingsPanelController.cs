using UnityEngine;

public class SettingsPanelController : MonoBehaviour
{
    public GameObject settingsPanel;  // Settings panel UI
    public GameObject menuPanel;      // Main menu panel UI
    public GameObject backButton;     // Back button
    public GameObject[] menuButtons;  // Optional: menu buttons to hide/show

    void Start()
    {
        // Hide settings panel and back button on start
        if (settingsPanel != null)
            settingsPanel.SetActive(false);
        if (backButton != null)
            backButton.SetActive(false);
    }

    public void OpenSettings()
    {
        Debug.Log("Opening Settings");

        if (settingsPanel != null)
            settingsPanel.SetActive(true);

        if (menuPanel != null)
            menuPanel.SetActive(false);

        if (backButton != null)
            backButton.SetActive(true);

        foreach (GameObject button in menuButtons)
            if (button != null)
                button.SetActive(false);
    }

    public void CloseSettings()
    {
        Debug.Log("Closing Settings");

        if (settingsPanel != null)
            settingsPanel.SetActive(false);

        if (menuPanel != null)
            menuPanel.SetActive(true);

        if (backButton != null)
            backButton.SetActive(false);

        foreach (GameObject button in menuButtons)
            if (button != null)
                button.SetActive(true);
    }
}

