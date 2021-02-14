using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockShatters : MonoBehaviour
{

    public GameObject destroyedRedCube;
    public GameObject destroyedBlueCube;
    public GameObject destroyedWhiteCube;

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
        if (other.gameObject.tag == "redNoteBlock")
        {
            print ("trigger worked");
            Instantiate(destroyedRedCube, other.transform.position, other.transform.rotation);
            Destroy (other.gameObject);
        }
        else if (other.gameObject.tag == "blueNoteBlock")
        {
            print ("trigger worked");
            Instantiate(destroyedBlueCube, other.transform.position, other.transform.rotation);
            Destroy (other.gameObject);
        }
        else if (other.gameObject.tag == "whiteNoteBlock")
        {
            print ("trigger worked");
            Instantiate(destroyedWhiteCube, other.transform.position, other.transform.rotation);
            Destroy (other.gameObject);
        }
    }
}
