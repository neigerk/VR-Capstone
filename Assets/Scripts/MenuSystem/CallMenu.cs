using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallMenu : MonoBehaviour
{
	private Canvas canvas = null;
	public AudioClip bgaudioClip;
	private AudioSource audio;
    private void Awake()

    {
        canvas = GetComponent<Canvas>();
        audio = GetComponent<AudioSource>();
        Invoke("PlayMusic", 6f);
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Two)){
        	Time.timeScale = 0;
		GetComponent<CanvasGroup>().alpha = 1;
		GetComponent<CanvasGroup>().interactable = true;
		GetComponent<CanvasGroup>().blocksRaycasts = true;
		PauseMusic();
        } 
    
    }
        public void PauseMusic()
    {
        audio.Pause();
    }

}
