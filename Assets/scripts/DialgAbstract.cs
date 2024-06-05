using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Doublsb.Dialog;
using UnityEngine.SceneManagement;


public abstract class DialgAbstract : MonoBehaviour
{
    public DialogManager dialogManager;
    public string actor;
    public string sentence;
    abstract protected void choiseHandle();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
