using UnityEngine;
using System.Collections;

public class MoveRacket_LR : MonoBehaviour {
    public float speed = 30;
    
	// Update is called once per frame
	void FixedUpdate () {
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
	}
}
