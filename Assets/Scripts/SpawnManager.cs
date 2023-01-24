using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    Vector3 spawnPos;
    public GameObject[] obstaclePrefabs;
    float repeatRate;
    float spawnDelay=2;
    // Start is called before the first frame update
    void Start()
    {
        spawnPos = transform.position;
        Invoke("spawnManager", spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnManager()
    {
        repeatRate = Random.Range(1, 3);
        Instantiate(obstaclePrefabs[0], spawnPos , obstaclePrefabs[0].transform.rotation);
        Invoke("spawnManager", repeatRate);
    }
}
