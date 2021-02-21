using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteBlock : MonoBehaviour
{
     [SerializeField]
     public GameObject rubble;
     private PlayerStats player;
     private Move move;
     // Start is called before the first frame update
     private void Awake()
     {
         move = GetComponentInParent<Move>();
         player = GameObject.Find("PlayerStats").GetComponent<PlayerStats>();
     }
     void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //check if red block misses the player, therefore damaging in the player stats script
        if (move.GetFinished())
        {
            if (gameObject.GetComponent<Renderer>().material.name.Substring(0,1) == "R"){
                print("red missed");
                player.ChangeCurrentHP(-1);
            }    
            Destroy(this.gameObject);
        }
    }

    public void Shatter()
     {
        // never is called rn
        //   Instantiate(rubble, gameObject.transform);
        //   if (gameObject.GetComponent<Renderer>().material.name.Substring(0,1) == "W"){
        //     print("destroyed a white cube!");
        //     destroyedWhite = true;
        //   }
        //   Destroy(gameObject);
     }
}
