using UnityEngine;
using System.Collections;
using System;
 
public class MouseMove2D : MonoBehaviour {
 
    private Vector3 mousePosition;
    public float moveSpeed = 0.3f;
    private Vector2 prevPos = new Vector2(0,0);
    private Vector2 velocity = new Vector2(0,0);
    private Vector2 lastTangent; 
    private Vector2 fromLastTangentV;
    private int i;
    private float zRotationRad;
    private float zRotationDeg;
 
    // Use this for initialization
    void Start () {
        lastTangent = GameObject.Find("ShipCore").transform.position;
    }
   
    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButton(1)) {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            prevPos = transform.position;
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
            velocity = (Vector2)transform.position - prevPos;//in worldpixels per frame
        }

        fromLastTangentV = (Vector2)transform.position - lastTangent;
        zRotationRad = (float)Math.Atan(fromLastTangentV.x/fromLastTangentV.y);
        zRotationDeg = -1 * zRotationRad * 180 / (float)Math.PI;
        transform.rotation = Quaternion.Euler(new Vector3(0f,0f,zRotationDeg));
        // i += 1;
        // if (i==40){
        //     Debug.Log(zRotationDeg);
        //     Debug.Log(transform.rotation);
        //     i=0;
        // }
    }
}
