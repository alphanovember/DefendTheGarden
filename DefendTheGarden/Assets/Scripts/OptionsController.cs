using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class OptionsController : MonoBehaviour {

	public Slider volumeSlider;
	public Slider diffSlider;
	public LevelManager levelManager; 

	private PersistentMusic musicManager;
	//????private MusicManager musicManager;
	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<PersistentMusic>();
		volumeSlider.value = PlayerPref.GetMasterVolume ();
		diffSlider.value = PlayerPref.GetDifficulty ();
	}
	
	// Update is called once per frame
	void Update () {
		musicManager.SetVolume (volumeSlider.value);
	}

	public void SetDefault(){
		volumeSlider.value = 0.8f;
		diffSlider.value = 2f;
		
	}


	public void SaveAndExit(){
		PlayerPref.SetMasterVolume (volumeSlider.value);
		PlayerPref.SetDifficulty (diffSlider.value);
		levelManager.LoadLevel ("01a_Start Menu");
	}




}
