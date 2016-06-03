using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {





	void Start () {

	}
	void RestartLevel (){

		int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; 

		SceneManager.LoadScene(currentSceneIndex + 1);

	}
}

