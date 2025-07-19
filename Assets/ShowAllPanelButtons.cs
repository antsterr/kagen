using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowAllPanelButtons : MonoBehaviour
{
    public GameObject panelButtons;  // Assign the "PanelButtons" GameObject in the Inspector

    void Start()
    {
        if (panelButtons == null)
        {
            Debug.LogWarning("PanelButtons GameObject is not assigned.");
            return;
        }

        // Get all Button components under PanelButtons, even if they're inactive
        Button[] buttons = panelButtons.GetComponentsInChildren<Button>(true);

        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(true);  // Enable the GameObject that holds the button
        }

        Debug.Log($"Enabled {buttons.Length} buttons under PanelButtons.");
    }
}
