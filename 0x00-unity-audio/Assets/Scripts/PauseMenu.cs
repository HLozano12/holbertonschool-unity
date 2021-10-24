using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    public Button resumeButton;
    public Button restartButton;
    public Button menuButton;
    public Button optionsButton;
	public AudioMixerSnapshot AudioPaused;
	public AudioMixerSnapshot AudioUnpaused;

    void Start()
    {
        Button resume = resumeButton.GetComponent<Button>();
        resume.onClick.AddListener(Resume);

        Button restart = restartButton.GetComponent<Button>();
        restart.onClick.AddListener(Restart);


        Button MenuButton = menuButton.GetComponent<Button>();
        MenuButton.onClick.AddListener(MainMenu);

        Button OptionsButton = optionsButton.GetComponent<Button>();
        OptionsButton.onClick.AddListener(Options);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (GameIsPaused)
            {
                Resume();
				AudioPaused.TransitionTo(0.01f);
            }
            else
            {
                Pause();
				AudioUnpaused.TransitionTo(0.01f);
            }
        }
    }

    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        GameIsPaused = true;
        pauseMenuUI.SetActive(true);
    }

    void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        GameIsPaused = false;
        pauseMenuUI.SetActive(false);
		// Audio
		AudioUnpaused.TransitionTo(0.01f);
    }

    void Restart()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("timescale");
        SceneManager.LoadScene("MainMenu");
        Debug.Log("mainmenue");
    }

    void Options()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        PlayerPrefs.SetInt("LastScene", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Options");
    }
}