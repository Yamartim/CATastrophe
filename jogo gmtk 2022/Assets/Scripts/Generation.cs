using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
    [SerializeField] private GameObject[] roomsPrefabs;
    private GameObject room;

    private void Start()
    {
        NewRoom();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            NewRoom();
        }
    }

    public void NewRoom()
    {        
        Destroy(room);
        int rand = Random.Range(0, roomsPrefabs.Length);
        room = Instantiate(roomsPrefabs[rand], Vector3.zero, Quaternion.identity);

    }
}
