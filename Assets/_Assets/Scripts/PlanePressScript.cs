using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePressScript : MonoBehaviour
{
    public int id;
    public PanelScript panelScript;
    private void OnMouseDown()
    {
        panelScript.openPanel(id);
    }
}
