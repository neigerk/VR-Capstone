using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SongCarrier : MonoBehaviour
{
    private static SongCarrier _SongCarrierInstance;

    public float bpm;
    public AudioClip audioClip;

    private Scene currentScene;

    private void Awake()
    {
        Debug.Log(SceneManager.GetActiveScene().name);
        currentScene = SceneManager.GetActiveScene();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (_SongCarrierInstance != null && _SongCarrierInstance != this)
        {
            Destroy(this.gameObject);
        } else
        {
            _SongCarrierInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if( currentScene != SceneManager.GetActiveScene())
        {
            currentScene = SceneManager.GetActiveScene();
            UpdateSongs();
        }
    }
    
    private void UpdateSongs()
    {
        Debug.Log(SceneManager.GetActiveScene().name);
        if (SceneManager.GetActiveScene().name == "BetaScene")
        {
            GameObject.Find("Canvas").GetComponent<AudioSource>().clip = audioClip;
            GameObject.Find("BPM").GetComponent<BPM>().bpm = bpm;
            GameObject.Find("Canvas").GetComponent<AudioSource>().Play();


        }
    }
}
