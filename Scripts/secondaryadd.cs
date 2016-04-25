using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using System.Collections;

public class secondaryadd : MonoBehaviour {

//	public Button reviving;

	void Awake()
	{
		Advertisement.Initialize ("1028249", false);

	}



	public void ShowRewardedAdd()
	{
		if (Advertisement.IsReady())
		{
			Advertisement.Show();
			numberofwish.i++;
	//		reviving.gameObject.SetActive (true);
			PlayerPrefs.SetInt ("wishleft", numberofwish.i);
		}
	}
}

