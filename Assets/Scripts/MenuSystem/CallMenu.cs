using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallMenu : MonoBehaviour
{
	private Canvas canvas = null;
	private Transform trackingSpace = null;
    private void Awake()
    {
        canvas = GetComponent<Canvas>();
        //ovrcamerarig = GetComponent<OVRCameraRig>();

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Two)){
        	Time.timeScale = 0;
        	canvas.enabled = true;
        	//trackingSpace.enabled = true;
        } 
    
    }
}
