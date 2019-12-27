using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMove : MonoBehaviour
{
    private GameObject timemanager;
    private TimeManager script;
    public GameObject clear;
    void Start()
    {
        transform.position = new Vector3(14.0f, 9.0f, 0.0f);
        transform.eulerAngles = new Vector3(45.0f, 0.0f, 0.0f);
        timemanager = GameObject.Find("TimeManager");
        script = timemanager.GetComponent<TimeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform goaltrans = this.transform;
        Vector3 worldAngle = goaltrans.eulerAngles;
        worldAngle.y += 5.0f;
        goaltrans.eulerAngles = worldAngle;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player"){
            script.timecheck++;
            clear.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
