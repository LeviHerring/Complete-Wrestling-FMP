using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] ItemPrefabs;
    public float Radius = 1;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    int randEnemy;

    private void Start()
    {
        StartCoroutine(Spawner()); 
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) SpawnObjectAtRandom();

        spawnWait = Random.Range(spawnLeastWait, spawnMostWait); 
            
    }

    void SpawnObjectAtRandom()
    {
        Vector3 randomPos = Random.insideUnitCircle * Radius;

        //Instantiate(ItemPrefabs, randomPos, Quaternion.identity); 
    }

    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(1f);

        while(!stop)
        {
            randEnemy = Random.Range(0, 2);

            //Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y), 0);
            Vector3 randomPos = Random.insideUnitCircle * Radius;

            Instantiate(ItemPrefabs[randEnemy], randomPos + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait); 
        }


    }
}
