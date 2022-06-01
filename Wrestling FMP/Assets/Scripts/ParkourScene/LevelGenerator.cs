using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    [SerializeField] private Transform levelPartstart;
    [SerializeField] private Transform levelPartEnding;
    [SerializeField] private Transform levelPartOne;
    [SerializeField] private List<Transform> levelPartList;
    private Transform chosenLevelPart; 
    private Transform lastLevelPartTransform; 
    private Vector3 lastEndPosition; 
    int loopCounter; 
    private void Awake()
    {
        loopCounter = 0; 
        Transform lastLevelPartTransform; 
        lastEndPosition = levelPartstart.Find("EndPosition").position;
        SpawnLevelPart(); 
        while (loopCounter < 7)
        {
            SpawnLevelPart();
            loopCounter++;
            
        }
        if(loopCounter >= 7)
        {
            SpawnEnding(); 
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

    public void SpawnEnding()
    {
        lastEndPosition = lastLevelPartTransform.Find("EndPosition").position;
        Instantiate(levelPartEnding, lastEndPosition, Quaternion.identity); 
    }
}
