using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remainsDisappear : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Stall());
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Stall()
    {
        yield return new WaitForSeconds(3);
    }
}