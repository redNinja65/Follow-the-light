using UnityEngine;
using System.Collections;

public class gamestart : MonoBehaviour {


	public void fadingloadingscreen()
	{
		float fadeTime = GameObject.Find ("Snow").GetComponent<Fading> ().BeginFade (1);
		Invoke ("loadnextlevel", fadeTime);

	}
	void loadnextlevel()
	{
		Application.LoadLevel ("Game");
	}


//	public void onclickingme()
//	{
//		Application.LoadLevel ("Game");
//	}
		
}
