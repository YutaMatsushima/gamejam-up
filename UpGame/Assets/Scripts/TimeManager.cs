﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public int timecheck = 0;
    public GameObject player;
    public GameObject time_object = null;
    void Update()
    {
        Text time_text = time_object.GetComponent<Text>();
        if(timecheck == 0){
            time_text.text = "Time:" + (Time.time - 2.5f);
        }
        if(timecheck == 1){
            Debug.Log("END");
            timecheck++;
        }
        if(!player.activeSelf){
            timecheck++;
        }
    }
}
