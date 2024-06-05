using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class dialogThree : MonoBehaviour
{
    public DialogManager dialogManager;
    public GameObject NextMission;
    
     void OnEnable()
        {
            var dialogTexts = new List<DialogData>();
            var dialog = new DialogData("/emote:Angry/just don't ask me what it is", "Luka");
            // dialog.SelectList.Add("go back to your apartment", "one");
            dialog.Callback = () => choiseHandle();
            dialogTexts.Add(dialog);
            dialogManager.Show(dialogTexts);
            // SceneManager.LoadScene("Apartment1");
        }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void choiseHandle()
    {
        SceneManager.LoadScene("Apartment1");
    }
    
    
}
