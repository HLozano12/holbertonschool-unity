using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	// Reverts to previous screen
	public void Back()
	{
		int prev = PlayerPrefs.GetInt("Scene");
		SceneManager.LoadScene(prev);
	}
}
