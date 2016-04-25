using UnityEngine;

public class Avatar : MonoBehaviour {

	public ParticleSystem shape, trail, burst;
	public AudioClip deathClip;
	AudioSource playerAudio;
	private Player player;
	public GameObject watchvideowishing;
	public GameObject wish;
	public GameObject usewishrevive;
	public GameObject killthesoul;
	public static bool gameispaused=false;

	public float deathCountdown = -1f;

	private void Awake () {
		player = transform.root.GetComponent<Player>();
		playerAudio = GetComponent <AudioSource> ();
		//watchvideowishing.fontSize = (int)(Screen.width * 0.1f);
		//PlayerPrefs.SetInt ("wishleft", 0);

	}


	private void OnTriggerEnter (Collider collider) {
		gameispaused = true;
		watchvideowishing.SetActive (true);
		wish.SetActive (true);
		usewishrevive.SetActive (true);
		killthesoul.SetActive (true);
		Time.timeScale = 0.0f;


//		if (deathCountdown < 0f) {
//			shape.enableEmission = false;
//			trail.enableEmission = false;
//			burst.Emit(burst.maxParticles);
//			deathCountdown = burst.startLifetime;
//		}

		playerAudio.clip = deathClip;
		playerAudio.Play ();
	}


		
	private void Update () {
		if (deathCountdown >= 0f) {
			deathCountdown -= Time.deltaTime;
			if (deathCountdown <= 0f) {
				deathCountdown = -1f;
				shape.enableEmission = true;
				trail.enableEmission = true;
				player.Die();
			}
		}
	}
}