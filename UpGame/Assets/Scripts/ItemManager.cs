using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private GameObject scoremanager;
    private ScoreManager script;
    void Start()
    {
        scoremanager = GameObject.Find("ScoreManager");
        script = scoremanager.GetComponent<ScoreManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player"){
            script.score++;
            Destroy(this.gameObject);
        }
    }
}
