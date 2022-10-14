using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] hazards;
    public float startTimeBtwSpawns;
    public float minTimeBetwSpawns;
    public float decrease;
    public GameObject player;

    private float timeBtwSpawns;
    

    // Update is called once per frame
    void Update()
    {
        if (player != null){
            if(timeBtwSpawns <= 0) {
                Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
                GameObject randomHazar = hazards[Random.Range(0, hazards.Length)];

                Instantiate(randomHazar, randomSpawnPoint.position, Quaternion.identity);

                if(startTimeBtwSpawns > minTimeBetwSpawns) {
                    startTimeBtwSpawns -= decrease;
                }
                timeBtwSpawns = startTimeBtwSpawns;

            } else {
                timeBtwSpawns -= Time.deltaTime;
            }
        }
    }
}
