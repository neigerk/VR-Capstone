using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class attackTimer : MonoBehaviour
{
    public TextMesh timeText;
    public bool activated;
    public float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        timeText.text = "";
        activated = false;
        timeRemaining = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // detects a press of the A button
        if (OVRInput.Get(OVRInput.Button.One)){
            activated = true;
            timeRemaining = 20;
        }
        if (activated){
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            } else
            {
                timeText.text = "";
                timeRemaining = 0;
                activated = false;
            }
        }
    }

    void DisplayTime(float seconds)
    {
        // displays 0 in the minute place and seconds after the colon
        timeText.text = string.Format("Attack Time\n 0:{0:00}", seconds); 
    }
}
