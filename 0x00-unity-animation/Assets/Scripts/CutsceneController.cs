using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Enable: MainCamera, PlayerController, TimerCanvas
// Disable: CutsceneController

public class CutsceneController : MonoBehaviour
{

	public GameObject MainCamera;
	public GameObject CutSceneCamera;
	public GameObject player;
	public GameObject TimerCanvas;
	public Animator Ani;


    // Start is called before the first frame update
    void Start()
    {
       // enable CutsceneCamera
	   CutSceneCamera = GameObject.Find("CutsceneCamera"); 
    }

    // Update is called once per frame
    void Update()
    {
    	if (Ani.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
			{
				Debug.Log("Animation done");
				TimerCanvas.gameObject.SetActive(true);
				CutSceneCamera.gameObject.SetActive(false);
				MainCamera.gameObject.SetActive(true);
				player.GetComponent<PlayerController>().enabled = true;
			}
    }
}
