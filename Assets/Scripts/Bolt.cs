using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt : MonoBehaviour
{
    public float speed;
    public Transform boss;

    private void Awake()
    {
        speed = 20.0f;
        boss = GameObject.FindGameObjectWithTag("Boss").transform;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, boss.position, step);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Boss")
        {
            Debug.Log("Boss Collision Detected");
            Destroy(gameObject);
        }
    }
}
