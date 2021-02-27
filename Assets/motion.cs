using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class motion : MonoBehaviour {
 
	public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
 
	void Start () {
        Debug.Log("hello unity");
	}
	
	// Update is called once per frame
	void Update () {
        cube1.transform.Translate(Vector3.up*0.1f, Space.World);
        cube2.transform.Rotate(Vector3.up*1,Space.Self);
        cube3.transform.localScale = new Vector3(1 + Mathf.Sin(Time.time), 1 + Mathf.Sin(Time.time), 1 + Mathf.Sin(Time.time));
	}
}
