using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreshowing : MonoBehaviour {


	public Text scorelabel;
	public Text velocitylabel;
	public Text levellabel;
	void Start () {
		scorelabel.text="Distance:\n" +((int)(Player.distanceTraveled* 10f)).ToString();
		velocitylabel.text="Velocity:\n"+((int)(Player.velocity * 10f)).ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
