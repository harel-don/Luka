using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class menuScript2 : MonoBehaviour
{
    private bool ent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        
        if (Input.GetKey("enter"))
        {
            SceneManager.LoadScene("scene");
        }
    }
    
    public void GoToScene(string scene1)
    {
        SceneManager.LoadScene(scene1);
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        
        if (Input.GetKey("enter"))
        {
            SceneManager.LoadScene("scene");
        }
    }
}
