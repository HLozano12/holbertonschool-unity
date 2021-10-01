using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
{
	 
}

public class PauseMenu : MonoBehaviour
{

	public GameObject PauseCanvas;
	Private bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		// if Esc key
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			isPaused = !isPaused;
		}
		if (isPaused)
		{
			Pause();
		}
		else
		{
			Resume();
		}
        
    }
	// The Pause menu
	public void Pause()
	{
		Time.TimeScale = 0;
		PauseCanvas.SetActive(true);
	}
	// Resume Button
	public void Resume()
	{
		Time.TimeScale = 1;
		PauseCanvas.SetActive(false);
		isPaused = false;
	}
	// Restart Button
	public void Restart()
	{
		SceneManagement.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
	// return Main Menu
	public void MainMenu()
	{
		SceneManager.LoadScene(0);
	}
	// Options Button
	public void Options()
	{
		SceneManager.LoadScene(1);
	}

}