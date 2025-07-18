using UnityEngine;

public class MenuToggle : MonoBehaviour
{
    public GameObject menuPanel; // Assign your menu UI panel in the Inspector

    private bool isMenuOpen = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isMenuOpen = !isMenuOpen;
            menuPanel.SetActive(isMenuOpen);
            Debug.Log("Menu toggled: " + isMenuOpen);
        }
    }
}
