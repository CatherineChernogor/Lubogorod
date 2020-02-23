using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    public GameObject LandPlane;
    public GameObject PortPlane;
    public static GameObject plane;
    public PanelScript panelScript;

    void Start()
    {
        plane = PortPlane;
    }
    void Update()
    {
        if (Camera.main.pixelHeight > Camera.main.pixelWidth)
        {
            Invoke("PortraitView", 0.2f);
        }
        else
        {
            Invoke("LandscapeView", 0.2f);
        }
    }
    void PortraitView()
    {
        plane = PortPlane;
        isShowPlane(PortPlane, LandPlane);
    }
    void LandscapeView()
    {
        plane = LandPlane;
        isShowPlane(LandPlane, PortPlane);
    }

    void isShowPlane(GameObject plane, GameObject otherPlane)
    {
        if (PanelScript.isPanel)
        {
            plane.SetActive(true);
            panelScript.openPanel(PanelScript.id);
            otherPlane.SetActive(false);
        }
        else
        {
            if (plane.activeSelf)
                panelScript.closePanel();
        }
    }

}
