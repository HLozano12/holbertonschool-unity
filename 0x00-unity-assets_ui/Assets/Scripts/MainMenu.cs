using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{   
    public void LevelSelect(int level)
    {
       SceneManager.LoadScene(level);    }

	public void Options()
	{
		SceneManager.LoadScene(4);
		PlayerPrefs.SetInt("Back", SceneManager.GetActiveScene().buildIndex);
	}

	public void QuitGame()
	{
		Application.Quit();
		Debug.Log("Exited");
	}
}