using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int score;
    public int lives;
    public Text scoreboard;
    public Text lives_left;
    	
	// Update is called once per frame
	void Update ()
    {
        scoreboard.text = score.ToString();
        lives_left.text = lives.ToString();
    }
}
