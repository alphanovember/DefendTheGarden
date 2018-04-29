using UnityEngine;
using System.Collections;

public class PersistentMusic : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;
	private AudioSource audioSource;

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void OnLevelWasLoaded (int level)  {
		AudioClip thisLevelMusic = levelMusicChangeArray [level];
		if (thisLevelMusic) { // if there is some music attached
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true ;
			audioSource.Play() ;
		} 
	}
	public void SetVolume(float volume){

		audioSource.volume = volume;
	}

}
