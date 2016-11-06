using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

    public Text scoreText;
    int score;

    public void ChangeScore(int points)
    {
        score += points;
        scoreText.text = "Score:" + score;
    }
}
