using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockShatters : MonoBehaviour
{

    public GameObject destroyedCube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "testcube")
        {
            print ("trigger worked");
            Instantiate(destroyedCube, other.transform.position, other.transform.rotation);
            Destroy (other.gameObject);
        }
    }
}
