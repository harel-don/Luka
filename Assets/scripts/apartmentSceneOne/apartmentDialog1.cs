using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class apartmentDialog1 : MonoBehaviour
{
    public DialogManager dialogManager;
    public GameObject LeftMission;
    public GameObject RightMission;

    private void OnEnable()
    {
        var dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("you get back to your apartment"));
        var dialog1 = new DialogData("/size:up/Would you like to open TV?", "TV");
        dialog1.SelectList.Add("left", "yes");
        dialog1.SelectList.Add("right", "I want to eat and get ready to sleep");
        dialog1.Callback = () => choiseHandle();
        dialogTexts.Add(dialog1);
        dialogManager.Show(dialogTexts);
    }
    
    
    private void choiseHandle()
    {
        switch (dialogManager.Result)
        {
            case "left":
                SceneManager.LoadScene("Apartment1 1");
                break;
            case "right":
                SceneManager.LoadScene("Apartment1 2");
                break;
        }
        gameObject.SetActive(false);
    }
}
