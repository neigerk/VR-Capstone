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
        if (move.GetFinished())
        {
            if(gameObject.GetComponent<Renderer>().material.name.Substring(0, 1) == "R")
            {
                player.ChangeCurrentHP(-1);
            }
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entering Collision! " + other);
        if (other.transform.tag == "BlockDestructionField")
        {
            if (gameObject.GetComponent<Renderer>().material.name.Substring(0, 1) == "R")
            {
                player.ChangeCurrentHP(-1);
            }
            Destroy(this.gameObject);
        }
    }
    

    public void Shatter()
     {
          Instantiate(rubble, gameObject.transform);
          Destroy(gameObject);
     }
}
