using UnityEngine;

public class PopupManager : MonoBehaviour
{
    public GameObject popupPanel;  // Reference to the popup panel
    
    // This method will open the panel
    public void ShowPopup()
    {
        popupPanel.SetActive(true);  // Activate the panel (shows the popup)
    }

    // This method will close the panel
    public void ClosePopup()
    {
        popupPanel.SetActive(false);  // Deactivate the panel (hides the popup)
    }
}
