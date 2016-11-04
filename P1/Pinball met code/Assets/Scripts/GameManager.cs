using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int score;
    public int lives;
    public Text scoreboard;
	
	// Update is called once per frame
	void Update ()
    {
        scoreboard.text = score.ToString();
    }
}
