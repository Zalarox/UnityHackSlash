using UnityEngine;
using System.Collections;

public class HandleTap : MonoBehaviour {

    public GameObject OptionsPanel;

    public void StartGame()
    {
        // read progress and start the game
        
    }

    public void ShowOptions()
    {
        // show the options menu
        OptionsPanel.SetActive(true);
    }

    public void CloseOptions()
    {
        
    }
}
