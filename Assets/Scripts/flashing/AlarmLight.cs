using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmLight : MonoBehaviour
{
	//open the light
	public bool alarmOn; //if no initial value,the alarmON is false
	//turn speed for light change
	public float turnSpeed;
	private float hightIntensity = 2f;
	private float lowIntensity = 0;
	private float targetIntensity =0;
	private Light alarmLight;
	private PlayerStats playerHealth;


    // Start is called before the first frame update
    void Start()
    {
        alarmLight = GameObject.Find("AlarmLight").GetComponent<Light>();
        targetIntensity = hightIntensity;
        playerHealth = GameObject.Find("PlayerStats").GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
    	//if alarmlight open by eneygy 
    	if(playerHealth.GetCurrentEnergy() == 51
    		||playerHealth.GetCurrentEnergy() == 76
    		||playerHealth.GetCurrentEnergy() == 100){
        	alarmOn = true;
        	//make alarmligh intersity to targetintensity by some time
        	alarmLight.intensity = Mathf.Lerp(alarmLight.intensity,targetIntensity,Time.deltaTime*turnSpeed);

        	if(Mathf.Abs(targetIntensity - alarmLight.intensity) <= 0.05f){
        		targetIntensity = targetIntensity == hightIntensity?lowIntensity:hightIntensity;
        	}
        }
        else{
        	//change to lowIntensity
        	alarmLight.intensity = Mathf.Lerp(alarmLight.intensity,lowIntensity,Time.deltaTime*turnSpeed);
        }
    }
}
