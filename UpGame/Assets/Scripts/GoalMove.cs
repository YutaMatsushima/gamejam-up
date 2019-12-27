using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(16.0f, 9.0f, 0.0f);
        transform.eulerAngles = new Vector3(45.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Transform goaltrans = this.transform;
        Vector3 worldAngle = goaltrans.eulerAngles;
        worldAngle.y += 5.0f;
        goaltrans.eulerAngles = worldAngle;
    }
}
