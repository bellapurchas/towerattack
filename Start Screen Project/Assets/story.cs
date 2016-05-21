using UnityEngine;
using System.Collections;

public class story : MonoBehaviour {

	float[] timeArray = new float[]{4,6,8,10,12};
	int index;

	public GameObject particle;
	public GameObject bat;
	public GameObject enemy;
	public GameObject teleport;

	// Use this for initialization
	void Start () {
		particle.SetActive (false);
		bat.SetActive (false);
		enemy.SetActive (false);
		teleport.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (index < timeArray.Length && Time.realtimeSinceStartup >= timeArray [index]) {
			OnTime (index);

			index++;
		}
	}

	void OnTime(int index)
	{
		Debug.Log (index);
		switch (index) {
		case 0:
			{
				bat.SetActive(true);
			}
			break;
		case 1:
			{
				particle.SetActive(true);
			}
			break;
		case 2:
			{
				teleport.SetActive(true);
			}
			break;
		case 3:
			{
				enemy.SetActive(true);
			}
			break;
		}


	}



}
