using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanelSCript : MonoBehaviour
{
    public int id;
    public PanelScript panelScript;
   // public GameObject menu_btn;
    public void showPan()
    {
        panelScript.openPanel(id);
       
    }

}
