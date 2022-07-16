using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Player player;
    private UIManager uiManager;

    private void Start()
    {
        player = FindObjectOfType<Player>();
        uiManager = FindObjectOfType<UIManager>();
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        uiManager.gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }


}
