using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float speed = 5;

    private Transform[] ways;

    private int index ;

    // Use this for initialization

    void Start () {

        ways = WayPoints.wayPoints;

        index = 0;

    }

        // Update is called once per frame

    void Update () {

        MoveTo ();

    }

    void MoveTo() {

        if (index > ways.Length-1) {

            return;

        }

        transform.Translate ((ways[index].position - 

            transform.position).normalized * Time.deltaTime * speed);

                if(Vector3.Distance(ways[index].position,transform.position) < 0.2f){

            index ++;

            if(index == ways.Length){

                transform.position = ways[index -1].position;

            }

        }

    }

    
    //Returns true if the movement is complete
    //Returns false if it needs to continue moving
    public bool GetFinished()
    {
        if (index >= ways.Length)
        {
            return true;
        } else
        {
            return false;
        }
    }

}