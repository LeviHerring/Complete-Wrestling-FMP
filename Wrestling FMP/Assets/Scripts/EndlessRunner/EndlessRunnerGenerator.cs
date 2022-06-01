using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessRunnerGenerator : MonoBehaviour
{
    private const float playerDistanceSpawnLevel = 200f; 
    [SerializeField] private Transform levelPartstart;
    [SerializeField] private List<Transform> levelPartList;
    [SerializeField] private GameObject player;
    //[SerializeField] private PlayerMovementFinal playerMovement;
    private Transform chosenLevelPart;
    private Transform lastLevelPartTransform;
    private Vector3 lastEndPosition;
    int loopCounter;
    private void Awake()
    {
        lastEndPosition = levelPartstart.Find("EndPosition").position;
        int startingSpawnLevelParts = 5; 
        for(int i = 0; i < startingSpawnLevelParts; i++)
        {
            SpawnLevelPart();
        }
      
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("PlayerOne"); 
    }

    private void Update()
    {
        if(Vector3.Distance(player.transform.position, lastEndPosition) < playerDistanceSpawnLevel)
        {
            SpawnLevelPart(); 
        }

        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("PlayerOne");
        }
    }


    private void SpawnLevelPart()
    {
        chosenLevelPart = levelPartList[Random.Range(0, levelPartList.Count)];
        lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("EndPosition").position;
    }

    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }

}
