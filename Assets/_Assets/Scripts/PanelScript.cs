using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        id = 0;
    }
    public static int id;
    private const int low = 1;
    private const int high = 8;
    public GameObject panel;
    public GameObject img;
    public GameObject text; 
    public Animator anime;
    public GameObject menu_btn;
    public GameObject focus;

    public void closePanel()
    {
        print("close");
        panel.SetActive(false);
        menu_btn.SetActive(true);
        focus.SetActive(true);
        id = 0;
    }
    public void goBackward()
    {
        print("backward " + id + "->" + (id - 1));
        id--;
        if (id < low)
            id = high;

        openPanel(id);
    }
    public void goforward()
    {
        print("forward " + id + "->" + (id + 1));
        id++;
        if (id > high)
            id = low;

        openPanel(id);
    }

    string prof;
    public void openPanel(int loc_id)
    {
        id = loc_id;
        print("open" + loc_id);
        if (!panel.activeSelf)
            panel.SetActive(true);

        //img.GetComponent<Image>().sprite = Resources.Load<Sprite>("gif/face_" + id);
        anime.SetInteger("state", id);
        prof= Resources.Load<TextAsset>("text/pro_" + id).ToString();
        text.GetComponent<Text>().text = prof;
        menu_btn.SetActive(false);
        focus.SetActive(false);

    }


   
}
