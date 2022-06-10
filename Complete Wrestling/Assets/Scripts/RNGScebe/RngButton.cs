using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro; 

public class RngButton : MonoBehaviour
{
    public GameObject panel;
    public GameObject Mainpanel;
    public TextMeshProUGUI text;
    private int rng;
    private int result;
    public List<Sprite> images;
    public Image image; 
    private int randomImage;
    public Sprite stonksDown; 
    public Sprite stonksUp; 
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Close()
    {
        Mainpanel.SetActive(true); 
        panel.SetActive(false); 
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("SampleScene"); 
    }

    public void IndieWrestler()
    {
        rng = Random.Range(1, 50);
        result = Random.Range(1, 50);
        if(rng == result)
        {
            text.text = "The indie wrestler was a success!";
        }
        else
        {
            text.text = "The indie wrestler flopped!"; 
        }
    }

    public void PopularWrester()
    {
        rng = Random.Range(1, 10);
        result = Random.Range(1, 10);
        if (rng == result)
        {
            text.text = "The popular wrestler was a success!";
        }
        else
        {
            text.text = "The popular wrestler flopped!";
        }
    }

    public void Stocks()
    {
        rng = Random.Range(1, 100);
        result = Random.Range(1, 100);
        if (rng == result)
        {
            image.sprite = stonksUp;
            text.text = "Investing in Gamestock was a success, to the moon!";
        }
        else
        {
            image.sprite = stonksDown;
            text.text = "Investing didn't work, all your money is gone!";
        }
    }

    public void NFT()
    {
        rng = Random.Range(1, 1000000000);
        result = Random.Range(1, 1000000000);
        image.sprite = images[Random.Range(0, images.Count - 1)];
        

        if (rng == result)
        {
            text.text = "People loved your funny monkeys!";
        }
        else
        {
            text.text = "WHAT WERE YOU THINKING? EVERYONE HATES YOUR MONKEYS!";
        }
    }
}
