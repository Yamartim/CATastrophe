using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject instructionsPanel;

    private void Start()
    {
        instructionsPanel.SetActive(false);
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
