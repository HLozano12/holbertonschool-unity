using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerTrigger : MonoBehaviour
{
    public GameObject player;
   
    void Update()
    {
  
    }


    void OnTriggerExit(Collider other)
    {
        Debug.Log("CLOCK ON");
        player.GetComponent<Timer>().enabled = true;
    }
  
}
