using UnityEngine;
using System.Collections;

public class tryagain : MonoBehaviour {

	public void Awake()
	{
		Time.timeScale = 1.0f;
	}
		
	public void onrestart()
	{

		Application.LoadLevel ("mainmenu");
	}
}
