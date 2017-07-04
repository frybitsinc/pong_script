using UnityEngine;
using System.Collections;

public class MoveRacket_LR : MonoBehaviour {
    public float speed = 30;
    public string axis = "Vertical";

    // Update is called once per frame
    void FixedUpdate () {
        float v = Input.GetAxisRaw(axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
	}
}