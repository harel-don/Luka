using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class dialogApartment2 : MonoBehaviour
{
    public DialogManager dialogManager;
    public GameObject LeftMission;
    public GameObject RightMission;

    // Start is called before the first frame update
    void OnEnable()
    {
        
        var dialogTexts = new List<DialogData>();
        var dialog1 = new DialogData("what chanel?");
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
        if (dialogManager.Result == "left")
        {
            SceneManager.LoadScene("Apartment1 4");
        }
        else
        {
            SceneManager.LoadScene("Apartment1 5");
        }
        // switch (dialogManager.Result)
        // {
        //     case "left":
        //         LeftMission.SetActive(true);
        //         break;
        //     case "right":
        //         RightMission.SetActive(true);
        //         break;
        // }
        gameObject.SetActive(false);
    }
}
