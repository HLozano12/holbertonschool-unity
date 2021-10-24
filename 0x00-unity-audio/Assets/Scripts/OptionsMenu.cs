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
	

    public void SetBGM(float BGM_Vol)
    {
        Mixer.SetFloat("BGM_Vol", Mathf.Log10(BGM_Vol) * 20);
    }

	public void SetSFX(float SFX_Vol)
	{
		Mixer.SetFloat("SFX_Vol", Mathf.Log10(SFX_Vol) * 20);
	}
	public void apply()
	{

	}
	
    public void Back()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Back"));
    }
}