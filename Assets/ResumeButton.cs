using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButton : MonoBehaviour
{
    public GameObject menuPanel;       // The menu background panel
    public GameObject panelButtons;    // The container for all the buttons
    public GameObject menuRoot;        // (Optional) Parent object for the full menu, if you want to toggle it all

    public void ResumeGame()
    {
        if (menuPanel != null)
            menuPanel.SetActive(false);

        if (panelButtons != null)
            panelButtons.SetActive(false);

        if (menuRoot != null)
            menuRoot.SetActive(false);

        Time.timeScale = 1f; // Resume gameplay if paused
    }
}
