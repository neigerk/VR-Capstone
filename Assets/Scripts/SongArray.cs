using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongArray : MonoBehaviour
{
    public AudioClip[] audioClips;
    public float[] bpms;
    public GameObject[] bosses;
    private SongCarrier songCarrier;
    // Start is called before the first frame update
    private void Awake()
    {
        songCarrier = GameObject.Find("SongCarrier").GetComponent<SongCarrier>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateSongCarrier(int num)
    {
        songCarrier.audioClip = audioClips[num];
        songCarrier.bpm = bpms[num];
        songCarrier.boss = bosses[num];
    }
}
