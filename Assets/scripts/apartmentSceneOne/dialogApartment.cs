using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public DialogManager dialogManager;
    public GameObject LeftMission;
    public GameObject RightMission;

    // Start is called before the first frame update
    void Awake()
    {
        
        var dialogTexts = new List<DialogData>();
        var dialog1 = new DialogData("/size:up/what chanel?", "TV");
        dialog1.SelectList.Add("left", "Sport Chanel");
        dialog1.SelectList.Add("right", "eleven");
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
