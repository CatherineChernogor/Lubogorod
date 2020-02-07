using UnityEngine;
using System.Collections;
using Vuforia;
using UnityEngine.EventSystems;

public class CameraFocusScript: MonoBehaviour
{

    private string label;
    private float touchduration;
    private Touch touch;

    public GameObject clickmage;
    RectTransform keka;
    // Use this for initialization
    void Start()
    {
        keka = clickmage.GetComponent<RectTransform>();
        //clickmage = GameObject.Find ("clickMage");

        //clickmage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (keka.sizeDelta.x < 50)
            keka.sizeDelta = new Vector2(0, 0);
        else
        {
            keka.sizeDelta = new Vector2((float)(keka.sizeDelta.x - (float)1.4), (float)(keka.sizeDelta.y - (float)1.4));
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        clickmage.SetActive(true);
        if (Input.touchCount > 0)
        {
            if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
            {
                label = "kek";
            }
            else
            {
                clickmage.transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                keka.sizeDelta = new Vector2(100, 100);

                touchduration += Time.deltaTime;
                touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Ended && touchduration < 0.2f)
                {
                    StartCoroutine("singleOrDouble");
                }
            }
        }
        else
        {
            touchduration = 0;
        }
    }

    IEnumerator singleOrDouble()
    {
        yield return new WaitForSeconds(0.3f);
        if (touch.tapCount == 1)
        {

            OnSingleTapped();
        }
        /*else if (touch.tapCount == 2) {
			//this coroutine has been called twice. We should stop the next one here otherwise we get two double tap
			StopCoroutine ("singleOrDouble");
			//Debug.Log ("Double");
			OnDoubleTapped();
		}*/
    }

    private void OnSingleTapped()
    {
        TriggerAutoFocus();
        label = "Tap the Screen!";
    }

    private void OnDoubleTapped()
    {
        label = "Double Tap the Screen!";
    }

    //SingleTap Gestures are captured by AppManager and calls this method for TapToFocus
    public void TriggerAutoFocus()
    {
        StartCoroutine(TriggerAutoFocusAndEnableContinuousFocusIfSet());
    }

    /// <summary>
    /// Activating trigger autofocus mode unsets continuous focus mode (if was previously enabled from the UI Options Menu)
    /// So, we wait for a second and turn continuous focus back on (if options menu shows as enabled)
    /// </returns>
    private IEnumerator TriggerAutoFocusAndEnableContinuousFocusIfSet()
    {
        /*
        //triggers a single autofocus operation 
		if (CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_TRIGGERAUTO)) {
			this.View.FocusMode = CameraDevice.FocusMode.FOCUS_MODE_TRIGGERAUTO;
		}

		yield return new WaitForSeconds(1.0f);

		//continuous focus mode is turned back on if it was previously enabled from the options menu
		if(this.View.mAutoFocusSetting.IsEnabled)
		{
			if (CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO)) {
				this.View.FocusMode = CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO;
			}
		}

		Debug.Log (this.View.FocusMode);
		*/
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_TRIGGERAUTO);
        yield return new WaitForSeconds(1.0f);
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

    /*	void OnGUI ()
        {
            GUI.Label (new Rect (10, 10, 100, 100), "----> " + label);
        }*/
}