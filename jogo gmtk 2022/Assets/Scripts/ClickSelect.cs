using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickSelect : MonoBehaviour
{
    public Storage storage_script;
    public CardScript card_script;

    void Start()
    {
        Button btn = this.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick(){
        card_script = storage_script.lastCardScript;
        if(this.name == "Good"){
            storage_script.isSum = true;
            storage_script.Operation();
        }else if(this.name == "Bad"){
            storage_script.isSum = false;
            storage_script.Operation();
        }else{
            return;
        }
        card_script.Roll();
    }
}
