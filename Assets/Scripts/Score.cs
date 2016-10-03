using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
	private int score = 0;					// The player's score.
    

	private PlayerControl playerControl;	// Reference to the player control script.

    private GUIText _guiText;
    public int CurrentScore
    {
    get { return score; }

        set
        {
            score = value;
            // Set the score text.
            _guiText.text = "Score: " + score;

            // If the score has changed...
         
                // ... play a taunt.
                playerControl.StartCoroutine(playerControl.Taunt());

            // Set the previous score to this frame's score.

        }
    }

	void Awake ()
	{
		// Setting up the reference.
		playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
        _guiText = GetComponent<GUIText>();
	}


	void Update ()
	{
	
	}

}
