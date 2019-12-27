using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private int timecheck = 0;
    void Update()
    {
        if(timecheck == 0){
            Debug.Log(Time.time);
        }
        if(timecheck == 1){
            Debug.Log("END");
            timecheck++;
        }
    }
    public void CheckGoal(){
        timecheck++;
    }
}
