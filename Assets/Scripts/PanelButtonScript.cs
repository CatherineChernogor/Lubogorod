using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//SPS SetPanelScript;
public class PanelButtonScript : MonoBehaviour
{
    public int id;
    public GameObject panel;
    public SetPanelScript SetPanelScript;

    public void closePanel()
    {
        print("close");
        panel.SetActive(false);
    }

    public void goBackward()
    {
        print("backward");
        id--;
        SetPanelScript.openPanel(id);
    }
    public void goforward()
    {
        print("forward");
        id++;
        SetPanelScript.openPanel(id);

        //openPanel(id + 1);
    }
}
