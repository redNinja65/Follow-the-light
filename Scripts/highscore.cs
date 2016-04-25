using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class highscore : MonoBehaviour {

	public Text bestscore;
	public Text bestvelocity;
	float oldHighscoreS;
	float oldHighscoreV;

	void Update () {

		oldHighscoreS = PlayerPrefs.GetFloat ("highscoreD",0);
		oldHighscoreV = PlayerPrefs.GetFloat ("highscoreV",0);

		if ((int)Player.distanceTraveled >= (oldHighscoreS) )
		{

			PlayerPrefs.SetFloat ("highscoreD", Player.distanceTraveled);
		
		
		}

		if ((int)Player.velocity >= oldHighscoreV) {

			PlayerPrefs.SetFloat ("highscoreV", Player.velocity);


			}

		bestscore.text="DISTANCE:\n"+ PlayerPrefs.GetFloat ("highscoreD")*10f;

		bestvelocity.text="VELOCITY:\n"+ PlayerPrefs.GetFloat ("highscoreV")*10f;
	}
}







