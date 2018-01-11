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
        if (Input.GetKey(KeyCode.Space)) {
            if (!paused)
            {
                // Pause game
                PauseGame();
            }
            else {
                // Resume game
                PauseGame();
            }
        }
    }

    private void PauseGame() {
        Time.timeScale = 0;
        //pausePanel.SetActive(true);
        //Disable scripts that still work while timescale is set to 0
    }
    private void ResumeGame() {
        Time.timeScale = 1;
        //pausePanel.SetActive(false);
        //enable the scripts again
    }
}
