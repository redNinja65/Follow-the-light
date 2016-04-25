using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

	public Text distanceLabel;
	int j=0;
	public Text wishduringpause;
	public Text velocityLabel;
	int wishleftforgamebegin;
	public GameObject watchvideowishing;
	public GameObject wish;
	public GameObject usewishrevive;
	public GameObject killthesoul;
	int k;

	public void SetValues (float distanceTraveled, float velocity) 
	{
		distanceLabel.text = ((int)(distanceTraveled * 10f)).ToString();
		velocityLabel.text = ((int)(velocity * 10f)).ToString();
	}

	void Start()
	{
		k = -1;
		Avatar.gameispaused = false;
		wishleftforgamebegin = PlayerPrefs.GetInt ("wishleft");
		distanceLabel.gameObject.SetActive (true);
		velocityLabel.gameObject.SetActive (true);
	}

	public void onclickingmerevive()
	{
		if(j==0)
		{

			j++;
			k++;
			if ((wishleftforgamebegin >= 1)) {
			numberofwish.i--;
			PlayerPrefs.SetInt ("wishleft", numberofwish.i);
			watchvideowishing.SetActive (false);
			wish.SetActive (false);
			usewishrevive.SetActive (false);
			killthesoul.SetActive (false);
			Avatar.gameispaused = false;

			Time.timeScale = 1.0f;

		} else {
			killthesoul.SetActive (true);
			watchvideowishing.SetActive (true);
			wish.SetActive (true);
		}
		}


	}
	void Update()
	{
		Debug.Log (Avatar.gameispaused);
		if (j == 1) {
			usewishrevive.SetActive (false);
		}
//	
//		if (k >= 0) {
//			usewishrevive.SetActive (false);
//		}
			
		wishleftforgamebegin = PlayerPrefs.GetInt ("wishleft");
		if (wishleftforgamebegin < 1) {
			usewishrevive.SetActive (false);
		} 
		if(wishleftforgamebegin<=0)
		{
			wishleftforgamebegin = 0;
		}

		if(Avatar.gameispaused==true)
		{
			wishduringpause.text = "Wish:\n" + wishleftforgamebegin;
			//wishduringpause.gameObject.SetActive(true);

		}
		else if(Avatar.gameispaused==false){
			wishduringpause.gameObject.SetActive(false);
		}
		if((wishleftforgamebegin >= 1) &&(Avatar.gameispaused==true) && (j==0))
			{
				usewishrevive.SetActive (true);
			}
		else
		{
			usewishrevive.SetActive (false);
		}
			
	}

}