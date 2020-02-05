
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeForScript : MonoBehaviour
{
    void OnMouseDown()
    {
        print("down");
        GetComponent<Image>().sprite = Resources.Load<Sprite>("arrows/forward(active)");
        //GetComponent<Image>().sprite = Resources.Load<Sprite>("arrows/"+ active);
    }

    void OnMouseUp()
    {
        print("up");
        GetComponent<Image>().sprite = Resources.Load<Sprite>("arrows/forward(active)_2");
        //GetComponent<Image>().sprite = Resources.Load<Sprite>("arrows/"+sprite);
    }

}