using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using System.Collections;

public class numberofwish : MonoBehaviour {

	public static bool audiooff;
	public Text creditstext;
	public Button musicon;
	public Button musicoff;
	public Button creditbutton;
	public Text wishcountingfirstscene;
	int x=0;
	public static int i=0;

	void Awake()
	{
		Advertisement.Initialize ("1028249", false);
			
	}
	void Start()
	{
		
		if (audiooff == false) {
			transform.GetComponent<AudioSource> ().UnPause ();
			musicon.gameObject.SetActive (false);
			musicoff.gameObject.SetActive (true);
		} else if (audiooff == true) {
			transform.GetComponent<AudioSource> ().Pause ();
			musicon.gameObject.SetActive (true);
			musicoff.gameObject.SetActive (false);
		}
	}
		
			
			
		void Update()
		{
		
			x=PlayerPrefs.GetInt("wishleft");

		if (x <= 0) {
			x = 0;
		}
			
//			wishcountingduringpause.text="Wish:\n"+ x;
			wishcountingfirstscene.text = "ClickMe!\nWish:\n" + x;
		}
		public void onclickingcredits()
		{
			creditstext.gameObject.SetActive (true);
			creditbutton.gameObject.SetActive (false);
		}
		public void musicofffxn()
		{
			audiooff = false;
			transform.GetComponent<AudioSource> ().UnPause ();
			musicon.gameObject.SetActive (false);
			musicoff.gameObject.SetActive (true);


		}
		public void musiconfxn()
		{
		audiooff = true;
		transform.GetComponent<AudioSource>().Pause();
		musicon.gameObject.SetActive (true);
		musicoff.gameObject.SetActive (false);
		}
//		
//		public void ShowAd()
//		{
//			if (Advertisement.IsReady())
//			{
//				Advertisement.Show();
//				Avatar.wishleft++;
//			}
//		}

		public void ShowRewardedAd()
		{
		if (Advertisement.IsReady())
					{
							Advertisement.Show();
							i++;
							PlayerPrefs.SetInt ("wishleft", i);
					}
		}
}

//		void HandleShowResult(ShowResult result)
//		{
//			switch (result)
//			{
//			case ShowResult.Finished:
//				Debug.Log ("The ad was successfully shown.");
//				Avatar.wishleft++;
//				break;
//			case ShowResult.Skipped:
//				Debug.Log("The ad was skipped before reaching the end.");
//				break;
//			case ShowResult.Failed:
//				Debug.LogError("The ad failed to be shown.");
//				break;
//			}
//		}				


		
	
