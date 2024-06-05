using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Doublsb.Dialog;
using UnityEngine.SceneManagement;
public  class leftRightDialog : DialgAbstract
{
    // public GameObject LeftMission;
    // public GameObject RightMission;
    public string optionLeft;
    public string optionRight;
    public string sceneLeft;
    public string sceneRight;
    public bool leftSceneExist;
    public bool rightSceneExist;
    public bool HaveActor;
    
    
    // Start is called before the first frame update
    void OnEnable()
    {
        var dialogTexts = new List<DialogData>();
        var dialog1 = new DialogData(sentence);
        if(HaveActor)
            dialog1 = new DialogData(sentence, actor);
        
        dialog1.SelectList.Add("left", optionLeft);
        dialog1.SelectList.Add("right", optionRight);
        dialog1.Callback = () => cho();
        dialogTexts.Add(dialog1);
        dialogManager.Show(dialogTexts);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    override protected void choiseHandle()
    {
        if (dialogManager.Result == "left")
        {
            if (leftSceneExist)
            {
                SceneManager.LoadScene(sceneLeft);
            }
            // LeftMission.SetActive(true);
        }
        else
        {
            if (rightSceneExist)
            {
                SceneManager.LoadScene(sceneRight);
            }
            else
            {
                // RightMission.SetActive(true);  
            }
        }
        // switch (dialogManager.Result)
        // {
        //     
        //     case "left":
        //         if (leftSceneExist){ SceneManager.LoadScene(sceneLeft);}
        //         else
        //         {
        //           LeftMission.SetActive(true);  
        //         }
        //         break;
        //     
        //     case "right":
        //         if (rightSceneExist){SceneManager.LoadScene(sceneRight);}
        //             
        //         else
        //         {
        //           RightMission.SetActive(true);  
        //         }
        //         break;
        // }
        gameObject.SetActive(false);
    }

    private void cho()
    {
        if (dialogManager.Result == "left")
        {
            if (leftSceneExist)
            {
                SceneManager.LoadScene(sceneLeft);
            }
            // LeftMission.SetActive(true);
        }
        else
        {
            if (rightSceneExist)
            {
                SceneManager.LoadScene(sceneRight);
            }
            else
            {
                // RightMission.SetActive(true);  
            }
        }
    }
}
