using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [Tooltip("In seconds")][SerializeField] float levelLoadDelay = 1f;
    [Tooltip("FX prefab on player")] [SerializeField] GameObject deathFX;

    private void OnCollisionEnter(Collision collision)
    {
        print("Player hit thing!");
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Player triggered thing!");
        StartDeathSequence();
        deathFX.SetActive(true);
        Invoke("ReloadScene", levelLoadDelay);
    }

    
    void StartDeathSequence()
    {
        //SendMessage("MethodName"); //Calls methods called MethodName() on all other scripts on the game object
        print("Player is dying!");

        SendMessage("OnPlayerDeath");
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(1);
    }
}
