using UnityEngine;
using System.Collections;

public class startgamedirectly : MonoBehaviour {

	void Start()
	{
		
		if (numberofwish.audiooff == true) {
			transform.GetComponent<AudioSource> ().Pause ();
		} else {
			transform.GetComponent<AudioSource> ().UnPause ();
		}
}
}