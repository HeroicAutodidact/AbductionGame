using UnityEngine;
using System.Collections;

public class OpenClose : MonoBehaviour {


	public SpriteRenderer sr;
	public Sprite closed;
	public Sprite open;
	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer>();
		if (sr.sprite == null) {
			sr.sprite = open;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			//Close claw
			sr.sprite = closed;
		}	
		if(Input.GetMouseButtonUp(0)){
			sr.sprite = open;	
		}
	}
}
