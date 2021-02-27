using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern : MonoBehaviour
{
    const float SpawnZ = 40;
    private int next, size;
    public GameObject noteBlock;
    [SerializeField]
    private Vector3[] Notes;

    void Awake()
    {
        
        size = Notes.Length;
        next = 0;
    }
    // Start is called before the first frame update

    public int Play()
    {
        if (next < size)
        {
            Notes[next].z--;
            while (Notes[next].z <= 0)
            {
                Instantiate(noteBlock, new Vector3(Notes[next].x, Notes[next].y, SpawnZ), Quaternion.identity);
                next++;
                Debug.Log("next: " + next.ToString());
                Debug.Log("size: " + size.ToString());
                if (next == size)
                {
                    break;
                }
            }
        }
        if (next < size)
        {
            return 1;
            
        } 
        else
        {
            return 0;
        }
    }
}
