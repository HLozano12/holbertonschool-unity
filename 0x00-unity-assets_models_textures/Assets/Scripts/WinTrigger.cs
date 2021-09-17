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
            

            // Stop "stop watch".
            player.GetComponent<Timer>().StopWatch = false;

            TimerText.color = Color.green;
            TimerText.fontStyle = FontStyle.Bold;
            TimerText.fontSize = 80;
            
        }
    }
}