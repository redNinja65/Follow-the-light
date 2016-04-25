using UnityEngine;
using System.Collections;

public class lastscenemusicoff : MonoBehaviour {

	void Awake()
	{

		if (numberofwish.audiooff == true) {
			transform.GetComponent<AudioSource> ().Pause ();
		} else {
			transform.GetComponent<AudioSource> ().UnPause ();
		}
	}
}
