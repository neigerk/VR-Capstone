using UnityEngine;
using System.Collections;
 
public class Create : MonoBehaviour
{
 
    private IEnumerator coroutine; 
    private bool isStart = false;//the flag for create object
    public GameObject CreateObject;//set object
 
    void Start()
    {
        coroutine = WaitAndPrint(1.5f);//WaitAndPrint function will use 1.5s
    }
 
    void Update()
    {
        if (Input.GetMouseButtonDown(1))//use mouse right butto 
        {
            if (!isStart)//not start
            {
                StartCoroutine(coroutine);//open teh create
                isStart = true;
            }
            else
            {
                StopCoroutine(coroutine);//destroy
                isStart = false;
                coroutine = WaitAndPrint(1.5f);//keep the initial object
            }
        }
    }
 
    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            GameObject.Instantiate(CreateObject, gameObject.transform.position, gameObject.transform.rotation);
            yield return new WaitForSeconds(waitTime);
        }
    }
}