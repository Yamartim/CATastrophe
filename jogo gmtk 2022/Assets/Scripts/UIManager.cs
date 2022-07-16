using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private Player player;

    [SerializeField] private Slider hpSlider;
    public GameObject gameOverPanel;

    private void Start()
    {
        player = FindObjectOfType<Player>();
        gameOverPanel.SetActive(false);
    }

    private void Update()
    {
        hpSlider.value = player.hp / player.maxHp;
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
