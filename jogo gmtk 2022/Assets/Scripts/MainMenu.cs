using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject instructionsPanel;
    [SerializeField] TMP_Text highscoretxt;

    private void Start()
    {
        instructionsPanel.SetActive(false);


        if(!PlayerPrefs.HasKey("highscore")) PlayerPrefs.SetInt("highscore",0);

        highscoretxt.text = "HIGH SCORE " + PlayerPrefs.GetInt("highscore").ToString();
    }

    public void StartGame()
    {
        new WaitForSeconds(.5f);
        SceneManager.LoadScene("Level1");
    }

    public void ShowInstructions()
    {
        instructionsPanel.SetActive(true);
    }

    public void ClosePanel(GameObject toClose)
    {
        toClose.SetActive(false);
    }

}
