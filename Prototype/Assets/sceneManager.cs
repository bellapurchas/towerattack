using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SceneManager.LoadScene ("");
	}

	public void selectLevel(){
		SceneManager.LoadScene ("select levels");
	}
	public void level1(){
		SceneManager.LoadScene ("Level 1");
	}
	public void level2(){
		SceneManager.LoadScene ("Level 2");
	}
	public void level3(){
		SceneManager.LoadScene ("Level 3");
	}
	public void level4(){
		SceneManager.LoadScene ("Level 4");
	}
	public void level5(){
		SceneManager.LoadScene ("Level 5");
	}

	public void Tutorial(){
		SceneManager.LoadScene ("Tutorial");
	}

	public void Home(){
		SceneManager.LoadScene ("Start Screen");
	}


		

	
	// Update is called once per frame
	void Update () {
		
	}
}
