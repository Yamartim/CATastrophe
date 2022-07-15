using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardScript : MonoBehaviour
{
    public Storage storage_script;
    public int num;

    void Start(){
        Roll();
        Button btn = this.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }
    // Start is called before the first frame update
    public void Roll()
    {
        num = Random.Range(0,9);
        TextMeshProUGUI CardText = this.GetComponentInChildren<TextMeshProUGUI>();
        CardText.text = num + "";
    }

    void TaskOnClick(){
        storage_script.num = num;
        storage_script.lastCardScript = this;
    }
}
