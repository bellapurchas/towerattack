using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	void nextLevel(){
	int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; 
		if (currentSceneIndex < SceneManager.sceneCount - 1) {
			SceneManager.LoadScene (currentSceneIndex + 1);
		}
	}
	// Use this for initialization


}
