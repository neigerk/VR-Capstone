using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CallMenu : MonoBehaviour
{
	private Canvas canvas = null;
	public AudioClip bgaudioClip;
	private AudioSource audio;
    private void Awake()

    {
        canvas = GetComponent<Canvas>();
        audio = GetComponent<AudioSource>();
        bgaudioClip = GetComponent<AudioClip>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.B)){//button B
        	Time.timeScale = 0;
			GetComponent<CanvasGroup>().alpha = 1;
			GetComponent<CanvasGroup>().interactable = true;
			GetComponent<CanvasGroup>().blocksRaycasts = true;
			PauseMusic();
        } 
    	if (OVRInput.Get(OVRInput.RawButton.X)){//button X
        	Time.timeScale = 1;
			GetComponent<CanvasGroup>().alpha = 0;
			GetComponent<CanvasGroup>().interactable = false;
			GetComponent<CanvasGroup>().blocksRaycasts = false;
			UnpauseMusic();
        }
		if (OVRInput.Get(OVRInput.RawButton.Y)){//button Y
        		SceneManager.LoadScene(0);
        		Time.timeScale = 1;
        	}
    }
    public void PauseMusic()
    {
        audio.Pause();
    }
   /* public void StopMusic()
    {
        audio.Stop();
    }
    public void PlayMusic()
    {
        audio.clip = bgaudioClip;
        audio.Play();
    }*/
    public void UnpauseMusic()
    {
    	audio.UnPause();
    }

}
