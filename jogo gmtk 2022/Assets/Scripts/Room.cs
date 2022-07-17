using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    private Generation generation;
    [SerializeField] DiceTube tubo;

    public List<GameObject> enemies = new List<GameObject>();

    private void Start()
    {
        generation = FindObjectOfType<Generation>();  
        tubo = FindObjectOfType<Player>().gameObject.GetComponentInChildren<DiceTube>();
    }

    private void Update()
    {
        for (int i = 0; i < enemies.Count; i++)
        {
            if (enemies[i] == null)
            {
                enemies.RemoveAt(i);
                i--;
            }
        }

        if(enemies.Count == 0)
        {
            GameObject[] collectibles = GameObject.FindGameObjectsWithTag("Collectible");
            foreach(GameObject item in collectibles){
                GameObject.Destroy(item);
            }
            generation.NewRoom();
            tubo.EncherFilaRand();
        }

    }
}
