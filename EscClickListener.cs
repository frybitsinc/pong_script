using UnityEngine;
using System.Collections;

public class EscClickListener : MonoBehaviour
{
    public Transform canvas;

    void Start()
    {
        // hide pause menu on start
        canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Click ESC
        if (Input.GetKey(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            // Pause game
            Time.timeScale = 0;
            canvas.gameObject.SetActive(true);
        }
        else {
            // Resume game
            Time.timeScale = 1;
            canvas.gameObject.SetActive(false);
        }
    }
}
