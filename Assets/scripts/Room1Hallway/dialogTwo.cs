using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class dialogTwo : MonoBehaviour
{
    public DialogManager dialogManager;
    public GameObject NextMission;
    // Start is called before the first frame update
    void OnEnable()
    {
        var dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("Yes I think you've seen me before, ", "Luka"));
        // dialogTexts.Add(new DialogData("one more thing, " +
        //                                "if you hear something late at night, don't worry about it..", "Luka"));
        var dialog = new DialogData("one more thing if you hear something late at night," +
                                    " don't worry about it..", "Luka");
        dialog.SelectList.Add("left", "sure");
        dialog.SelectList.Add("right", "why");
        dialog.Callback = () => choiseHandle();
        dialogTexts.Add(dialog);
        dialogManager.Show(dialogTexts);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void choiseHandle()
    {
        var dialogTexts = new List<DialogData>();
        if (dialogManager.Result == "left")
        {
            
            SceneManager.LoadScene("Apartment3");
        }
        else if (dialogManager.Result == "right")
        {
            SceneManager.LoadScene("scene 1");
            NextMission.SetActive(true);
            // SceneManager.LoadScene("hallway2");
            gameObject.SetActive(false);
            // var dialog = new DialogData("just don't ask me what it is", "Luka");
            // dialogTexts.Add(dialog);
            // dialogManager.Show(dialogTexts);
        }
        
    }

}
