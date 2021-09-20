using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
    public Text TimerText;
    public float currentTime;


    // Start is called before the first frame update
    void Start()
    {
        TimerText.text = "0:00.00";
        currentTime = 0;
    }

    void Update()
    {
        currentTime += Time.deltaTime;
     
        TimeSpan time = TimeSpan.FromSeconds(currentTime);

        TimerText.text = time.ToString(@"m\:ss\.ff");
    }


}