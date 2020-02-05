
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeCloseScript : MonoBehaviour
{
    void OnMouseDown()
    {
        print("down");
        GetComponent<Image>().sprite = Resources.Load<Sprite>("arrows/close(active)");
        //GetComponent<Image>().sprite = Resources.Load<Sprite>("arrows/"+ active);
    }

    void OnMouseUp()
    {
        print("up");
        GetComponent<Image>().sprite = Resources.Load<Sprite>("arrows/close(active)_2");
        //GetComponent<Image>().sprite = Resources.Load<Sprite>("arrows/"+sprite);
    }

}