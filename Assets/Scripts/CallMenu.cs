using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CallMenu : MonoBehaviour
{
    private Canvas canvas = null;
    public AudioClip bgaudioClip;
    public AudioSource audio;
    private void Awake()

    {
        canvas = GetComponent<Canvas>();
        audio = GetComponent<AudioSource>();
        bgaudioClip = GetComponent<AudioClip>();


    }

    // Update is called once per frame
    void Update()
    {
        if ((OVRInput.Get(OVRInput.RawButton.B))
        	&&(GameObject.Find("EnemyStats").GetComponent<EnemyStats>().currentHp!=0)
        	&&(GameObject.Find("PlayerStats").GetComponent<PlayerStats>().currentHp!=0))
        {//button B
            Time.timeScale = 0;
            GameObject.Find("Canvas").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("Canvas").GetComponent<CanvasGroup>().interactable = true;
            GameObject.Find("Canvas").GetComponent<CanvasGroup>().blocksRaycasts = true;
            PauseMusic();
        }
        if ((OVRInput.Get(OVRInput.RawButton.X))
        	&&(GameObject.Find("Canvas").GetComponent<CanvasGroup>().alpha == 1))
        {//button X
            Time.timeScale = 1;
            GameObject.Find("Canvas").GetComponent<CanvasGroup>().alpha = 0;
            GameObject.Find("Canvas").GetComponent<CanvasGroup>().interactable = false;
            GameObject.Find("Canvas").GetComponent<CanvasGroup>().blocksRaycasts = false;
            UnpauseMusic();
        }
        if (((OVRInput.Get(OVRInput.RawButton.Y))&&(GameObject.Find("Canvas").GetComponent<CanvasGroup>().alpha == 1))
        	||((OVRInput.Get(OVRInput.RawButton.Y))&&(GameObject.Find("CanvasWin").GetComponent<CanvasGroup>().alpha == 1))
        	||((OVRInput.Get(OVRInput.RawButton.Y))&&(GameObject.Find("CanvasLose").GetComponent<CanvasGroup>().alpha == 1)))
        {//button Y
            SceneManager.LoadScene(0);
            Time.timeScale = 1;

        }
        if((GameObject.Find("EnemyStats").GetComponent<EnemyStats>().currentHp==0))//when enemyStats hp= 0, game over
        {
        	Time.timeScale = 0;
            GameObject.Find("CanvasWin").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("CanvasWin").GetComponent<CanvasGroup>().interactable = true;
            GameObject.Find("CanvasWin").GetComponent<CanvasGroup>().blocksRaycasts = true;
            PauseMusic();        
        }
        if((GameObject.Find("PlayerStats").GetComponent<PlayerStats>().currentHp==0))//when palyer hp= 0, game over
        {
        	Time.timeScale = 0;
            GameObject.Find("CanvasLose").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("CanvasLose").GetComponent<CanvasGroup>().interactable = true;
            GameObject.Find("CanvasLose").GetComponent<CanvasGroup>().blocksRaycasts = true;
            PauseMusic();        
        }
		if(((GameObject.Find("PlayerStats").GetComponent<PlayerStats>().currentHp == 0)&&(OVRInput.Get(OVRInput.RawButton.A)))
		||((GameObject.Find("EnemyStats").GetComponent<EnemyStats>().currentHp == 0)&&(OVRInput.Get(OVRInput.RawButton.A))))//restart game
        {
            SceneManager.LoadScene(1);    
        }
		if(audio == null)// music done
        {
        	Time.timeScale = 0;
            GameObject.Find("CanvasLose").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("CanvasLose").GetComponent<CanvasGroup>().interactable = true;
            GameObject.Find("CanvasLose").GetComponent<CanvasGroup>().blocksRaycasts = true;
            PauseMusic();        
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