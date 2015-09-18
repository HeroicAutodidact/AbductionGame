using UnityEngine;
using System.Collections;

public class NeckInterface : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.position = new Vector2(0f,0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void move(float x, float y) {
		transform.position.Set(x,y,0);
	}

}
