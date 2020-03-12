using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    int Score;
    [SerializeField] Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        if (ScoreText == null)
            ScoreText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        //ScoreText.text = "Score: " + Score.ToString();
    }

    public void OnScore(int scoreValue)
    {
        Score += scoreValue;
        ScoreText.text = "Score: " + Score.ToString();
    }

    /*
     [SerializeField]  int ScorePerHit = 12;
           
     public void ScoreHit()
     {
        score += ScorePerHit;
     }
     
     */

}
