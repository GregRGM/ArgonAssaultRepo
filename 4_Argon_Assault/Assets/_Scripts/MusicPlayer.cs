using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    private void Awake()
    {
        GetComponent<AudioSource>().Play();

        int numMusicPlayer = FindObjectsOfType<MusicPlayer>().Length;
        print("number of music players: " + numMusicPlayer);
        //if more than one in scene
        //destroy self
        if (numMusicPlayer > 1)
        {            
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Not destroying on load");
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {

    }
}
