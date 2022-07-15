using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RollOnClick : MonoBehaviour
{
    public GameObject[] cards;
	void Start () {
		Button btn = this.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		foreach (GameObject card in cards)
        {
            int num = Random.Range(0,9);
            TextMeshProUGUI CardText = card.GetComponentInChildren<TextMeshProUGUI>();
            CardText.text = num + "";
        }
	}
}
