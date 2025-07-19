using UnityEngine;

public class MenuVisibilityController : MonoBehaviour
{
    public GameObject mainMenuPanel;          // The main menu buttons container (e.g. PanelButtons)
    public GameObject backButton;             // The Back button GameObject
    public AudioSource audioSource;           // Optional: sound player
    public AudioClip buttonClickSound;        // Optional: UI click sound

    [HideInInspector] public GameObject currentSubMenu;

    private bool inSubMenu = false;

    void Start()
    {
        if (mainMenuPanel != null)
            mainMenuPanel.SetActive(true);

        if (backButton != null)
            backButton.SetActive(false);

        if (currentSubMenu != null)
            currentSubMenu.SetActive(false);
    }

    public void OpenSubMenu(GameObject subMenu)
    {
        PlayClickSound();

        if (mainMenuPanel != null)
            mainMenuPanel.SetActive(false);

        if (subMenu != null)
        {
            currentSubMenu = subMenu;
            currentSubMenu.SetActive(true);
            inSubMenu = true;
        }

        if (backButton != null)
            backButton.SetActive(true); // Show back button
    }

    public void BackToMainMenu()
    {
        PlayClickSound();

        if (currentSubMenu != null)
            currentSubMenu.SetActive(false);

        if (mainMenuPanel != null)
            mainMenuPanel.SetActive(true);

        if (backButton != null)
            backButton.SetActive(false); // Hide back button

        inSubMenu = false;
    }

    private void PlayClickSound()
    {
        if (audioSource != null && buttonClickSound != null)
        {
            audioSource.PlayOneShot(buttonClickSound);
        }
    }
}
