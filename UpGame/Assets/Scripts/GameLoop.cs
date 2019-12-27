using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoop : MonoBehaviour
{
    public GameObject player;
    public GameObject goal;
    void Update()
    {
        if(!player.activeSelf || !goal.activeSelf){
            if(Input.GetKeyDown(KeyCode.Space)){
                SceneManager.LoadScene("Start");
            }
        }
    }
}
