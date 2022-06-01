using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class HazardsOn : MonoBehaviour
{
   public Text hazards;
   public Text powerups;
   public Text items; 

    // Start is called before the first frame update
    void Start()
    {
        Hazards();
        Items();
        Powerups(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hazards()
    {
        string hazardsOn = PlayerPrefs.GetString("hazards");
        switch (hazardsOn)
        {
            case "true":
                hazards.text = "Hazards: On";
                break;
            case "false":
                hazards.text = "Hazards: Off";
                break;
        }
    }
    public void Items()
    {
        string itemsOn = PlayerPrefs.GetString("items");
        switch (itemsOn)
        {
            case "true":
                items.text = "Items: On";
                break;
            case "false":
                items.text = "Items: Off"; 
                break;
        }
    }
    public void Powerups()
    {
        string powerupsOn = PlayerPrefs.GetString("powerups");
        switch (powerupsOn)
        {
            case "true":
                powerups.text = "Powerups: On";
                break;
            case "false":
                powerups.text = "Powerups: Off";
                break;

        }
    }
}
