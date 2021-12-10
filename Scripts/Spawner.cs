using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //array for å representere alle spawnere
    public GameObject[] spawners;
    public GameObject enemy;

    private void start()
    {
        //gir elemter får å kunne ha alle 4 spawners i en parentobject
        spawners = new GameObject[4];

        //for loop (hvis i er mindre enn 4 så vill dette loope og når i blir 5 (tror jeg) er loopen over, HUSK DETTE ER IKKE FERDIG WAVE SYSTEM BARE FOR 1 TERMIN FÅR Å HA ET FUNKENE PRODUKT!!!)
        for(int i = 0; i < spawners.Length; i++)
        {
            spawners[i] = transform.GetChild(i).gameObject;
        }
    }

    //får at den ikke spawner infinte mengder enemies for nå bare hvis jeg trykker T, siden vill ikke ha flere spawne
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            SpawnEnemy();
        }
    }

    //random spawn position, men fortsatt de gitte stedene
    private void SpawnEnemy()
    {
        int spawnerID = Random.Range(0, spawners.Length);
        Instantiate(enemy, spawners[spawnerID].transform.position, spawners[spawnerID].transform.rotation);
    }
}