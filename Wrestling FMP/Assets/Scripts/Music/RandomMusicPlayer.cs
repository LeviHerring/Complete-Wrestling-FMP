using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMusicPlayer : MonoBehaviour
{
    public AudioClip[] music;
    private AudioSource source; 

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = music[Random.Range(0, music.Length)];
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
