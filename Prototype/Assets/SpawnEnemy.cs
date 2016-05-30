using UnityEngine;
using System.Collections;

[System.Serializable]
public class Wave {
	public GameObject enemyPrefab;
	public float spawnInterval = 2;
	public int maxEnemies = 20;
	public int cost;
}

public class SpawnEnemy : MonoBehaviour {

	public GameObject[] waypoints;
	public GameObject testEnemyPrefab;

	public Wave[] waves;
	public int timeBetweenWaves = 5;

	
	private GameManagerBehavior gameManager;
	
	private float lastSpawnTime;
	private int enemiesSpawned = 0;

	// Use this for initialization
	void Start () {
		lastSpawnTime = Time.time;
		gameManager =
			GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
	}

		
	// Update is called once per frame
	void Update () {
		// 1
		int currentWave = gameManager.Wave;
		float cost;
		if (currentWave < waves.Length) {
			// 2
			float timeInterval = Time.time - lastSpawnTime;
			float spawnInterval = waves[currentWave].spawnInterval;
			if (((enemiesSpawned == 0 && timeInterval > timeBetweenWaves) ||
			     timeInterval > spawnInterval) && 
			    enemiesSpawned < waves[currentWave].maxEnemies) {
				// 3  
				lastSpawnTime = Time.time;
				GameObject newEnemy = (GameObject)
					Instantiate(waves[currentWave].enemyPrefab);
				newEnemy.GetComponent<MoveEnemy>().waypoints = waypoints;
				enemiesSpawned++;
			}
			// 4 
			if (enemiesSpawned == waves[currentWave].maxEnemies &&
			    GameObject.FindGameObjectWithTag("Enemy") == null) {
				gameManager.Wave++;
				gameManager.Gold = Mathf.RoundToInt(gameManager.Gold * 1.1f);
				enemiesSpawned = 0;
				lastSpawnTime = Time.time;
			}
			// 5 
		} else {
			gameManager.gameOver = true;
			GameObject gameOverText = GameObject.FindGameObjectWithTag ("GameWon");
			gameOverText.GetComponent<Animator>().SetBool("gameOver", true);
		}	
	}
	public void generateEnemy1() {
		int currentWave = gameManager.Wave;
		if (gameManager.Gold >= (waves[0].cost)) {
			GameObject newEnemy = (GameObject)
				Instantiate(waves[0].enemyPrefab);
			newEnemy.GetComponent<MoveEnemy>().waypoints = waypoints;
			gameManager.Gold -= (waves[0].cost);
		}

	}

	public void generateEnemy2() {
		int currentWave = gameManager.Wave;
		if (gameManager.Gold >= (waves[1].cost)) {
			GameObject newEnemy = (GameObject)
				Instantiate(waves[1].enemyPrefab);
			newEnemy.GetComponent<MoveEnemy>().waypoints = waypoints;
			gameManager.Gold -= (waves[1].cost);
		}
	}

	public void generateEnemy3() {
		int currentWave = gameManager.Wave;
		if (gameManager.Gold >= (waves[2].cost)) {
			GameObject newEnemy = (GameObject)
				Instantiate(waves[2].enemyPrefab);
			newEnemy.GetComponent<MoveEnemy>().waypoints = waypoints;
			gameManager.Gold -= (waves[2].cost);
		}

	}

	public void generateEnemy4() {
		int currentWave = gameManager.Wave;
		if (gameManager.Gold >= (waves[3].cost)) {
			GameObject newEnemy = (GameObject)
				Instantiate(waves[3].enemyPrefab);
			newEnemy.GetComponent<MoveEnemy>().waypoints = waypoints;
			gameManager.Gold -= (waves[3].cost);
		}

	}

	public void generateEnemy5() {
		int currentWave = gameManager.Wave;
		if (gameManager.Gold >= (waves[4].cost)) {
			GameObject newEnemy = (GameObject)
				Instantiate(waves[4].enemyPrefab);
			newEnemy.GetComponent<MoveEnemy>().waypoints = waypoints;
			gameManager.Gold -= (waves[4].cost);
		}

	}

}
