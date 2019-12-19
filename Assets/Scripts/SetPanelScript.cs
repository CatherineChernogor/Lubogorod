using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SetPanelScript : MonoBehaviour
{

    public int id;
    public GameObject panel;
    public GameObject img;
    public GameObject text;

    public GameObject buttons;
    public void openPanel(int id)
    {
        Debug.Log("work");
        if (!panel.activeSelf)
            panel.SetActive(true);
        //img.GetComponent<Image>.SourceImage = Resources.Load<Sprite>("png/trigger_" + id);
        //text.GetComponent<Text>.text = Resources.Load<Text>("text/prof_" + id);
        for (int i = 0; i < buttons.transform.childCount ; i++)
        {
            if ( buttons.transform.GetChild(i).transform.name==("Button_"+i))
                id = i+1;
        }
        Debug.Log("id is " + id);
        // Debug.Log("png/trigger_" + id);
        // Debug.Log("text/prof_" + id);

    }


}
