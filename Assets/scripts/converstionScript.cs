using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class converstionScript : MonoBehaviour
{
    public string Sentence;
    
    public string actor;
    
    public bool IsLeaf; 
    
    public bool IsQustion;

    public string NameLeft;
    public converstionScript Left;

    public string NameRight;
    public converstionScript Right;
    public converstionScript next;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
