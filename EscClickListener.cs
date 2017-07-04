using UnityEngine;
using System.Collections;

public class EscClickListener : MonoBehaviour {
    
	// Update is called once per frame
	void Update () {
        // Click ESC
        if (Input.GetKey(KeyCode.Escape)) {
            // Quit game
            Application.Quit();
        }
    }
}
