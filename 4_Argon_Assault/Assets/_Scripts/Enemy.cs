using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;
    [SerializeField] int ScoreValue = 1000;
    Collider myCollider;
    ScoreBoard Scoreboard;
    // Start is called before the first frame update
    void Start()
    {
        AddBoxCollider();
        Scoreboard = FindObjectOfType<ScoreBoard>();
    }

    private void AddBoxCollider()
    {
        myCollider = gameObject.AddComponent<BoxCollider>();
        myCollider.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnParticleCollision(GameObject other)
    {
        ScoreHit();
        GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
        fx.transform.parent = parent; 
        Destroy(gameObject);
    }
    void ScoreHit()
    {
        Scoreboard.OnScore(ScoreValue);
    }
}
