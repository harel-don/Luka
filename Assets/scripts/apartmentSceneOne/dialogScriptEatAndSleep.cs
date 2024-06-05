using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class dialogScript : MonoBehaviour
{
    public DialogManager dialogManager;
    public GameObject LeftMission;
    public GameObject RightMission;

    // Start is called before the first frame update
    void Awake()
    {
        
        var dialogTexts = new List<DialogData>();
        var dialog1 = new DialogData("you eat, and you organize yourself to bed."+
        "but then you hear loud noises coming from the apartment above you..", "TV");
        dialog1.SelectList.Add("left", "you descide that you want to investegate what is that sound");
        dialog1.SelectList.Add("right", "you don't want do anything about it, you want to sleep");
        dialog1.Callback = () => choiseHandle();
        dialogTexts.Add(dialog1);
        dialogManager.Show(dialogTexts);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void choiseHandle()
    {
        switch (dialogManager.Result)
        {
            case "left":
                LeftMission.SetActive(true);
                break;
            case "right":
                RightMission.SetActive(true);
                break;
        }
        gameObject.SetActive(false);
    }
}
