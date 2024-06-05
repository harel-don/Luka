using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Doublsb.Dialog;
using UnityEngine.SceneManagement;
public class dialogNext : DialgAbstract
{
    public GameObject nextMission;
    // public GameObject RightMission;
    public string sceneNext;
    public bool nextSceneExist;
    public bool HaveActor;
    // Start is called before the first frame update
    void OnEnable()
    {
        var dialogTexts = new List<DialogData>();
        var dialog1 = new DialogData(sentence);
        if(HaveActor)
            dialog1 = new DialogData(sentence, actor);
        dialog1.Callback = () => choiseHandle();
        dialogTexts.Add(dialog1);
        dialogManager.Show(dialogTexts);
    }
    
    override protected void choiseHandle()
    {
        
        if (nextSceneExist)
        {
            SceneManager.LoadScene(sceneNext);
        }
        
        else
        {
            nextMission.SetActive(true);
        }

       
    
        gameObject.SetActive(false);
    }
}
