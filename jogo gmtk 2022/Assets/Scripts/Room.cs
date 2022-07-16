using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    private Generation generation;

    public List<GameObject> enemies = new List<GameObject>();

    private void Start()
    {
        generation = FindObjectOfType<Generation>();   
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
            generation.NewRoom();
        }

    }
}
