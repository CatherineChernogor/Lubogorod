
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeBackScript : MonoBehaviour
{
    void OnMouseDown()
    {
        print("down");
        GetComponent<Image>().sprite = Resources.Load<Sprite>("arrows/backward(active)");
        //GetComponent<Image>().sprite = Resources.Load<Sprite>("arrows/"+ active);
    }

    void OnMouseUp()
    {
        print("up");
        GetComponent<Image>().sprite = Resources.Load<Sprite>("arrows/backward");
        //GetComponent<Image>().sprite = Resources.Load<Sprite>("arrows/"+sprite);
    }

}