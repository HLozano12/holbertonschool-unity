using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinMenu : MonoBehaviour
{
    public Button menuButton;
	public Button NextButton;
    public Text TimerText;
    public  Text winText;
	public string nextScene;

    int level;
    // Start is called before the first frame update
    void Start()
    {
        Button MenuButton = menuButton.GetComponent<Button>();
        MenuButton.onClick.AddListener(MainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        winText = TimerText;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
		Debug.Log("MainMenu");
    }

    public void Next(int level)
    {
        SceneManager.LoadScene(nextScene);
    }
}