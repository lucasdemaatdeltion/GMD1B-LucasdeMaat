using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    // Dit zijn de variabelen.

    public int score;
    public int lives;
    public Text scoreboard;
    public Text lives_left;
    	
	// Hiermee wordt het scorebord en levensbord mee aangestuurd.
	void Update ()
    {
        scoreboard.text = score.ToString();
        lives_left.text = lives.ToString();
    }
}
