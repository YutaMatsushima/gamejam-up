using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathWall : MonoBehaviour
{
    public GameObject player;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == player){
            player.SetActive(false);
        }
    }
}
