using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteBlock : MonoBehaviour
{
     [SerializeField]
     public GameObject rubble;
     private Move move;
     // Start is called before the first frame update
     private void Awake()
     {
         move = GetComponentInParent<Move>();
     }
     void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (move.GetFinished())
        {
            Destroy(this.gameObject);
        }
    }

    public void Shatter()
     {
          Instantiate(rubble, gameObject.transform);
          Destroy(gameObject);
     }
}
