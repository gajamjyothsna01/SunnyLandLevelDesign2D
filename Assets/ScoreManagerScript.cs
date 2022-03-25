using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class ScoreManagerScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public void Score(int scoreValue)
    {
        score = score + scoreValue;
        Debug.Log(score);
        scoreText.text = scoreValue.ToString();
        
     
        if(score > 30)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
