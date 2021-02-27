using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour {

    public static Transform[] wayPoints;

    void Awake () {

        int count = transform.childCount;

        wayPoints = new Transform[count];

        for(int i = 0; i < count; i ++) {

            wayPoints [i] = transform.GetChild (i);

        }

    }
}