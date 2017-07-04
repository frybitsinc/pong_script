using UnityEngine;
using System.Collections;

public class MoveRacket_TB : MonoBehaviour {
    public float speed = 30;

    // Update is called once per frame
    void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(v, 0) * speed;
    }
}
