using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarmtext : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMesh UIText;
    private float timer;
    private PlayerStats playerHealth;
    void Start()
    {
        timer=0.0f;
        playerHealth = GameObject.Find("PlayerStats").GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
    	UIText.text="";
    	if(playerHealth.GetCurrentEnergy() == 51
    		||playerHealth.GetCurrentEnergy() == 76
    		||playerHealth.GetCurrentEnergy() == 100)
    	{
        	timer +=Time.deltaTime*2;
        	if(timer % 2 > 1.0f){
        		UIText.text="";
        	}else{
        		UIText.text="your energy is full";
        	}
    	}
    }
}
