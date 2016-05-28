using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

	public AudioClip buttonPress;
	public AudioSource audioSource;



	public void star(){
		
	
		SceneManager.LoadScene ("");
	}

	public void selectLevel(){
		SceneManager.LoadScene ("selectLevel");
	}
	public void level1(){
		SceneManager.LoadScene ("");
	}
	public void level2(){
		SceneManager.LoadScene ("");
	}
	public void level3(){
		SceneManager.LoadScene ("");
	}
	public void level4(){
		SceneManager.LoadScene ("");
	}
	public void level5(){
		SceneManager.LoadScene ("");
	}
	public void playClip(AudioClip x){
		audioSource = GetComponent<AudioSource> ();
		audioSource.PlayOneShot (x);
	}
}
