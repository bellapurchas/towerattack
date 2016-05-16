using UnityEngine;
using System.Collections;


public class PlaceMonster : MonoBehaviour {
	public GameObject monsterPrefab;
	private GameObject monster;
	private GameManagerBehaviour gameManager;

	private bool canPlaceMonster () {
		int cost = monsterPrefab.GetComponent<MonsterData> ().levels[0].cost;
		return monster == null && gameManager.Gold >= cost;

	}
	//1
	void OnMouseUp (){
		//2
		if (canPlaceMonster ()) {
			monster = (GameObject)Instantiate (monsterPrefab, transform.position, Quaternion.identity);
			AudioSource audioSource = gameObject.GetComponent<AudioSource> ();
			audioSource.PlayOneShot (audioSource.clip);

			gameManager.Gold -= monster.GetComponent<MonsterData>().CurrentLevel.cost;
		}
			else if (canUpgradeMonster()) {
				monster.GetComponent<MonsterData>().increaseLevel();
				AudioSource audioSource = gameObject.GetComponent<AudioSource>();
				audioSource.PlayOneShot(audioSource.clip);

			gameManager.Gold -= monster.GetComponent<MonsterData>().CurrentLevel.cost;
			
			}
		}

	private bool canUpgradeMonster() {
		if (monster != null) {
			MonsterData monsterData = monster.GetComponent<MonsterData> ();
			MonsterLevel nextLevel = monsterData.getNextLevel();
			if (nextLevel != null) {
				return gameManager.Gold >= nextLevel.cost;
			}
		}
		return false;
	}
	// Use this for initialization
	void Start () {
		gameManager =
			GameObject.Find("GameManager").GetComponent<GameManagerBehaviour>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
