using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
   
    public GameObject player;
    public GameObject flag;
    private Rigidbody fl;
    public Text TimerText;
	public GameObject TimerCanvas;
	public GameObject WinCanvas;

    void Start()
    {
        fl = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
           TimerCanvas.SetActive(false);
		   WinCanvas.SetActive(true);        
        }
    }
}