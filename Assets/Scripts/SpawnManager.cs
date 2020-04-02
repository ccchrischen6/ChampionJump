using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private PlayerController playerControllerScript;
    public GameObject obstablePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 0;
    private float repeatRate = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstable", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstable()
    {
        if (!playerControllerScript.gameOver)
        {
            Instantiate(obstablePrefab, spawnPos, obstablePrefab.transform.rotation);
        }
        
    }
}
