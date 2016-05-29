using UnityEngine;
using System.Collections;

public class story : MonoBehaviour {

	float[] timeArray = new float[]{2,4,6,8,10};
	int index;


	public GameObject Canvas;
	public GameObject enemy;

	// Use this for initialization
	void Start () {
		
		enemy.SetActive (false);
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

		case 1:
			{
				enemy.SetActive(true);
			}
			break;
		case 2:
			{
				Canvas.SetActive (true);
			}
			break;
		}


	}



}
