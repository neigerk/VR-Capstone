using UnityEngine;
using System.Collections;
 
public class motion : MonoBehaviour
{
 
    GameObject right_stream;
    GameObject sky_right;
    GameObject sky_left;
 
    void Start()
    {
        right_stream = GameObject.Find("right_stream");
        sky_right = GameObject.Find("sky_right");
        sky_left = GameObject.Find("sky_left");
    }
 
    // Update is called once per frame
    void Update()
    {
        right_stream.transform.Translate(Vector3.up * 0.1f, Space.World);
        sky_right.transform.Rotate(Vector3.up * 1, Space.Self);
        sky_left.transform.localScale = new Vector3(1 + Mathf.Sin(Time.time), 1 + Mathf.Sin(Time.time), 1 + Mathf.Sin(Time.time));
    }
}
