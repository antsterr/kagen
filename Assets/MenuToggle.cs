using UnityEngine;
using UnityEngine.UI;

public class MenuToggleController : MonoBehaviour
{
    public GameObject menuPanel;      // The panel that gets shown/hidden (your "menu")
    public GameObject panelButtons;   // The parent object of all buttons (like resume, settings, social links)

    private Button[] buttons;
    private bool menuOpen = false;

    void Start()
    {
        if (menuPanel == null || panelButtons == null)
        {
            Debug.LogWarning("Assign both MenuPanel and PanelButtons in the Inspector.");
            return;
        }

        // Get all button components (even if inactive)
        buttons = panelButtons.GetComponentsInChildren<Button>(true);

        // Start with menu and buttons hidden
        menuPanel.SetActive(false);
        SetButtonsActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuOpen = !menuOpen;

            menuPanel.SetActive(menuOpen);
            SetButtonsActive(menuOpen);
        }
    }

    void SetButtonsActive(bool state)
    {
        // Show/hide the whole button container
        panelButtons.SetActive(state);

        // Also show/hide the individual buttons just in case
        foreach (Button btn in buttons)
        {
            btn.gameObject.SetActive(state);
        }
    }
}

