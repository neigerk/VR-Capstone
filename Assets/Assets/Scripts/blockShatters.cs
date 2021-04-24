using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockShatters : MonoBehaviour
{

    public GameObject destroyedRedCube;
    public GameObject destroyedBlueCube;
    public GameObject destroyedWhiteCube;
    private PlayerStats player;
    private EnemyStats enemy;
    private bool broken = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerStats").GetComponent<PlayerStats>();
        enemy = GameObject.Find("EnemyStats").GetComponent<EnemyStats>();
    }

    // Update is called once per frame
    void Update()
    {
          broken = false;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponents<NoteBlock>().Length != 0 && broken == false)
          {
               NoteBlock nb = other.gameObject.GetComponent<NoteBlock>();
               GameObject rubble = nb.rubble;
               Instantiate(rubble, other.transform.position, other.transform.rotation);
               if (other.gameObject.GetComponent<Renderer>().material.name.Substring(0,1) == "W")
               {
                    enemy.ChangeCurrentHp(-1);
               } else if(other.gameObject.GetComponent<Renderer>().material.name.Substring(0, 1) == "B")
               {
                    player.ChangeCurrentEnergy(1);
               }
               Destroy(other.gameObject);
               broken = true;
               // NoteBlock nb = other.gameObject.GetComponent<NoteBlock>();
               // nb.Shatter();
          }
        /*
        if (other.gameObject.tag == "redNoteBlock")
        {
            print ("trigger worked");
            Instantiate(destroyedRedCube, other.transform.position, other.transform.rotation);
            Destroy (other.gameObject);
        }
        else if (other.gameObject.tag == "blueNoteBlock")
        {
            print ("trigger worked");
            Instantiate(destroyedBlueCube, other.transform.position, other.transform.rotation);
            Destroy (other.gameObject);
        }
        else if (other.gameObject.tag == "whiteNoteBlock")
        {
            print ("trigger worked");
            Instantiate(destroyedWhiteCube, other.transform.position, other.transform.rotation);
            Destroy (other.gameObject);
        }
        */
    }
}
