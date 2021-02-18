using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remainsDisappear : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DeleteObj", 4); // delays for 4 seconds
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void DeleteObj()
    {
        Destroy(gameObject);
    }
}