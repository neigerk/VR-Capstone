using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteBlock : MonoBehaviour
{
     [SerializeField]
     public GameObject rubble;
     // Start is called before the first frame update
     private void Awake()
     {
      
     }
     void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shatter()
     {
          Instantiate(rubble, gameObject.transform);
          Destroy(gameObject);
     }
}
