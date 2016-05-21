using UnityEngine;
using System.Collections;

public class slowShow : MonoBehaviour {
	public float Duration = 2.0f;
	float elapse;
	// Use this for initialization
	void Start () {
	
	}

	void SetAlpha(float a){
		var sp = GetComponent<SpriteRenderer> ();
		var c = sp.color;
		c.a = a;
		sp.color = c;

	}

	// Update is called once per frame
	void Update () {
		if (elapse < Duration) {
			elapse += Time.deltaTime;
			SetAlpha (elapse / Duration);

		}
	}
}
