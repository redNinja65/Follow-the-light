using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;


public class googlelogin : MonoBehaviour {

	static int onetimerepetitionlogin=0;
	string leaderboardidE="CgkIsrfU4d4MEAIQAQ";
	float x;

	void Start()
	{
		Invoke ("afterthreesecondcallme", 3f);

	}

	void afterthreesecondcallme()
	{
		PlayGamesPlatform.DebugLogEnabled = true;
		PlayGamesPlatform.Activate ();
	if (onetimerepetitionlogin == 0) {

	Social.localUser.Authenticate ((bool success) =>
	{
		if (success) {
							Debug.Log ("Login Sucess");
					} 
		else {
							Debug.Log ("Login failed");
					}
					});

			}
			onetimerepetitionlogin++;
}

	public void OnAddScoreToLeaderBorad()
	{
		x=PlayerPrefs.GetFloat("highscoreD")*10f;
		if (Social.localUser.authenticated) {
			Social.ReportScore ((int)x, leaderboardidE, (bool success) => {
				if (success) {
					Social.ShowLeaderboardUI ();
				} else {
					Debug.Log ("Add Score Fail");
				}
			});
		}
	}
}
