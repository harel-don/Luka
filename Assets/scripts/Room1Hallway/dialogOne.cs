using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using PixelCrushers.DialogueSystem;
using UnityEngine.SceneManagement;

public class dialogOne : MonoBehaviour
{
    public DialogManager dialogManager;
    public GameObject NextMission;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("My name is Luka", "Luka"));
        dialogTexts.Add(new DialogData("/size:up/I live on the second floor", "Luka"));
        var dialog1 = new DialogData("/emote:Happy/I live upstairs from you", "Luka");
        dialog1.SelectList.Add("left", "you look familiar");
        dialog1.SelectList.Add("right", "see yha");
        dialog1.Callback = () => choiseHandle();
        dialogTexts.Add(dialog1);
        dialogManager.Show(dialogTexts);
    }

    // Update is called once per frame
    // void Update()
    // {
    //     
    // }

    private void choiseHandle()
    {
        if(dialogManager.Result == "left")
        {
            NextMission.SetActive(true);
            gameObject.SetActive(false);
        }
        else if (dialogManager.Result == "right")
        {
            var dialog = new DialogData("");
            // dialog.Callback = () => RunOneIter(currentConv.Right);
            // RunOneIter(currentConv.Right);
            // var dialog = new DialogData("wrong");
            // dialog.Callback = () => RunOneIter(currentConv);
            // dialogTexts.Add(new DialogData("You are wrong."));
            dialogManager.Show(dialog);
            SceneManager.LoadScene("Apartment2");
        }
        
        
        
    }
   
    // private void RunOneIter(converstionScript conv)
    // {
    //     var dialogTexts = new List<DialogData>();
    //     var currentConv = conv;
    //     if (!currentConv.IsLeaf)
    //     {
    //         // var dialog = new DialogData(currentConv.Sentence, currentConv.actor);
    //         if (!currentConv.IsQustion)
    //         {
    //             var dialog = new DialogData(currentConv.Sentence, currentConv.actor);
    //
    //             dialogTexts.Add(dialog);
    //             currentConv = currentConv.next;
    //             // RunOneIter(currentConv);
    //             dialog.Callback = () => RunOneIter(currentConv);
    //             // dialogManager.Show(dialogTexts);
    //         }
    //         else
    //         {
    //             var dialog = new DialogData(currentConv.Sentence, currentConv.actor);
    //             dialog.SelectList.Add("left", currentConv.NameLeft);
    //             dialog.SelectList.Add("right", currentConv.NameRight);
    //             dialog.Callback = () => Check_Correct();
    //             dialogTexts.Add(dialog);
    //             // dialogManager.Show(dialog);
    //             // dialogManager.Show(dialogTexts);
    //         }
    //
    //         // dialog.Callback = () => RunOneIter(currentConv);
    //     }
    //     dialogManager.Show(dialogTexts);
    // }
}
