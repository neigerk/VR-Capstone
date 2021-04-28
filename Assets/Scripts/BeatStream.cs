using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatStream : MonoBehaviour
{
    [SerializeField]
    private GameObject noteBlock;
    [SerializeField]
    public GameObject patternSource;
    private PatternArray patterns;
    private Pattern current, next;

    private void Awake()
    {
        patterns = patternSource.GetComponent<PatternArray>();
        current = PickNewPattern();
        next = PickNewPattern();
        GetComponentInParent<BPM>().BeatD8 += PlayPattern;


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayPattern()
    {
        int swapper = current.Play();
        if (swapper == 0)
        {
            SwapPattern();
        }
    }

    private int SwapPattern()
    {
        Destroy(current.gameObject);
        current = next;
        next = PickNewPattern();
        if(next != null)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    private Pattern PickNewPattern()
    {
        int rand = Random.Range(0, patterns.patterns.Length);
        Pattern pat = Instantiate(patterns.patterns[rand]);
        pat.noteBlock = noteBlock;
        return pat;
    }
}
