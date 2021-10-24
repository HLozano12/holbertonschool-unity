using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
	public AudioMixer Mixer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
    }

	//BGM slider control
	public void SetBGlevel( float slider_value)
	{
		Mixer.SetFloat("BGM", Mathf.Log10(slider_value) * 20);
	} 
	public void apply()
	{

	}
	
    public void Back()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Back"));
    }
}