using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerBehavior : MonoBehaviour {


	public Text goldLabel;
	private int gold;
	public int Gold {
  		get { return gold; }
  		set {
			gold = value;
    		goldLabel.GetComponent<Text>().text = gold + "x";
		}
	}

	public Text waveLabel;
	public GameObject[] nextWaveLabels;

	public bool gameOver = false;
	public bool gameWon = false;

	private int wave;
	public int Wave {
		get { return wave; }
		set {
			wave = value;
			if (!gameOver) {
				for (int i = 0; i < nextWaveLabels.Length; i++) {
					nextWaveLabels[i].GetComponent<Animator>().SetTrigger("nextWave");
				}
			}
		}
	}

	public Text healthLabel;
	public GameObject[] healthIndicator;

	private int health;
	public int Health {
		get { return health; }
		set {
			// 1
			if (value < health) {
				Camera.main.GetComponent<CameraShake>().Shake();
				Gold += 200;
			}
			// 2
			health = value;
			healthLabel.text = health + "x";
			// 2
			if (health <= 0 && !gameOver) {
				gameOver = true;
				GameObject gameOverText = GameObject.FindGameObjectWithTag ("GameOver");
				gameOverText.GetComponent<Animator>().SetBool("gameOver", true);
			}
			// 3 
			for (int i = 0; i < healthIndicator.Length; i++) {
				if (i < Health) {
					healthIndicator[i].SetActive(true);
				} else {
					healthIndicator[i].SetActive(false);
				}
			}
		}
	}

	// Use this for initialization
	void Start () {
		Gold = 1000;
		Wave = 0;
		Health = 5;
	}

	void NextLevel() {
		if (gameOver) {
			int currentSceneIndex = SceneManager.GetActiveScene ().buildIndex; 
			if (currentSceneIndex < SceneManager.sceneCount - 1) {
				SceneManager.LoadScene (currentSceneIndex + 1);
			}
		}
	}
	// Update is called once per frame

	public void endGameAndRestartLevel() {
		GameObject[] enemies = GameObject.FindGameObjectsWithTag ("Enemy") as GameObject[];
		int enemyCount = enemies.Length;
		if (enemyCount <= 0 && gold <= 99 && !gameOver) {
			gameWon = true;
			GameObject gameWonText = GameObject.FindGameObjectWithTag ("GameWon");
			gameWonText.GetComponent<Animator> ().SetBool ("gameWon", true);
		}
	}
}
