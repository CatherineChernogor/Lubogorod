using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelScript : MonoBehaviour
{

    public static int id;
    public static bool isPanel;

    private string prof;
    private const int LOW = 1;
    private const int HIGH = 8;



    private GameObject panel;
    private GameObject text;
    private Animator anime;

    private GameObject menu_btn;
    private GameObject focus;
    private GameObject shadow;

    void Start()
    {
        id = 0;

        //Find all child obj and store to that array
        foreach (Transform child in transform)
        {
            if (child.name == "Shadow")
                shadow = child.gameObject;

            if (child.name == "CameraFocus")
                focus = child.gameObject;

            if (child.name == "Button")
                menu_btn = child.gameObject;
        }
    }

    void Update()
    {
        panel = SwitchScript.plane;

        foreach (Transform child in panel.transform)
        {
            if (child.name == "ImageWrapper")
            {
                Transform img = child.GetChild(0);
                anime = img.gameObject.GetComponent<Animator>();
            }

            else if (child.name == "TextWrapper")
                text = child.GetChild(0).GetChild(0).GetChild(0).GetChild(0).gameObject;

        }
    }
    public void closePanel()
    {
        print("close");
        panel.SetActive(false);
        shadow.SetActive(false);
        menu_btn.SetActive(true);
        focus.SetActive(true);

        id = 0;
        isPanel = false;
    }
    public void goBackward()
    {
        id--;
        if (id < LOW)
            id = HIGH;
    }
    public void goforward()
    {
        id++;
        if (id > HIGH)
            id = LOW;
    }
    public void openPanel(int loc_id)
    {
        id = loc_id;
        print("open_" + loc_id);

        anime.SetInteger("state", id);
        prof = Resources.Load<TextAsset>("text/pro_" + id).ToString();
        text.GetComponent<Text>().text = prof;

        menu_btn.SetActive(false);
        focus.SetActive(false);
        shadow.SetActive(true);
        isPanel = true;
    }
}
