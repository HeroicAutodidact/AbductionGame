using UnityEngine;
using System.Collections;

public class VertibraeManager : MonoBehaviour {

	private VertibrateInterface ni;
	// Use this for initialization
	void Start () {
		ni = (VertibrateInterface) GameObject.Find("Vince").GetComponent(typeof(VertibrateInterface));
		ni.move(0f,0f);
	}
	
	// Update is called once per frame
	void Update () {

		//Recalculate path
			//Recalculate line from lasttangent to claw	
			//Search this line for contact neck w/ foreign bodies
			//Establish any new tangent point
			//Calculate arc
		//Move all neckpieces
			//Calculate length of curve
			//Get length difference, increment neck piece path
			
	
	}
}
