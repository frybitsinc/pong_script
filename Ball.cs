using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public float speed = 30;

	// Use this for initialization
	void Start () {
        // Initial Velocity
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}

    void OnCollisionEnter2D (Collision2D col) {
        // Note that 'col' holds the collision info, 
        // if the Ball collided with a racket, 
        // then :
        //  col.gameObject          is the racket, 
        //  col.transform.position  is the racket's position
        //  col.collider            is the racket's collider

        // hit the Left Racket?
        if (col.gameObject.name == "RacketLeft") {
            // Calculate hit factor
            float y = hitFactor_LR ( transform.position,
                                  col.transform.position,
                                  col.collider.bounds.size.y);
            // Calculate direction, make length = 1 via .normalized
            Vector2 dir = new Vector2(1, y).normalized;
            // Set velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        // hit the Right Racket?
        if (col.gameObject.name == "RacketRight") {
            // Calculate hit factor
            float y = hitFactor_LR (transform.position,
                                  col.transform.position,
                                  col.collider.bounds.size.y);
            // Calculate direction, make length = 1 via .normalized
            Vector2 dir = new Vector2(-1, y).normalized;
            // Set velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        // hit the Top Racket?
        // hit the Bottom Racket?
    }

    float hitFactor_LR (Vector2 ballPos, Vector2 racketPos, float racketHeight) {
        return (ballPos.y - racketPos.y) / racketHeight;
    }
}
