using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class attackTimer : MonoBehaviour
{
    public TextMesh timeText;
    public bool activated;
    public bool unable;
    public float timeRemaining;
    private PlayerStats playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        timeText.text = "";
        unable = false;
        activated = false;
        timeRemaining = 0;
        playerHealth = GameObject.Find("PlayerStats").GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        // detects a press of the A button
        if (OVRInput.GetDown(OVRInput.Button.One)){
            if (playerHealth.GetCurrentEnergy() >= 25){ // player is able to attack
                activated = true;
                timeRemaining = 20;
                playerHealth.ChangeCurrentEnergy(-25);
            } else{ // player has too little energy
                unable = true;
                timeRemaining = 2;
            }
        }
        if (activated){ // attack sequence is started
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
        if (unable){ // player has too little energy
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                timeText.text = "Need 25 or more energy to attack.";
            } else
            {
                timeText.text = "";
                timeRemaining = 0;
                unable = false;
            }
        }
    }

    void DisplayTime(float seconds)
    {
        // displays 0 in the minute place and seconds after the colon
        timeText.text = string.Format("Attack Time\n 0:{0:00}", seconds); 
    }
}
