using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsHazardsPowerups : MonoBehaviour
{
    public GameObject hazards;
    public GameObject items;
    public GameObject powerups; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        string hazardsOn = PlayerPrefs.GetString("hazards");
        switch (hazardsOn)
        {
            case "true":
                hazards.SetActive(true); 
                break;
            case "false":
                hazards.SetActive(false); 
                break;
        }

        string itemsOn = PlayerPrefs.GetString("items");
        switch (itemsOn)
        {
            case "true":
                items.SetActive(true);
                break;
            case "false":
                items.SetActive(false); 
                break;
        }

        string powerupsOn = PlayerPrefs.GetString("powerups");
        switch (powerupsOn)
        {
            case "true":
                powerups.SetActive(true); 
                break;
            case "false":
                powerups.SetActive(false); 
                break;

        }
    }
}
