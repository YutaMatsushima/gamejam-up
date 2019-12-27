using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public const int MAX_JUMP_COUNT = 2;
    public float jumpforce = 5.0f;
    private Vector3 side = new Vector3(0.1f, 0f, 0f);
    private int jumpcount = 0;
    private bool isJump = false;
    void start()
    {
        this.gameObject.transform.position = new Vector3(-18.0f, -8.0f, 0.0f);
    }
    void Update()
    {
        if(jumpcount < MAX_JUMP_COUNT && Input.GetKeyDown(KeyCode.W)){
            isJump = true;
        }   
    }

    void FixedUpdate()
    {
        Rigidbody rb = this.transform.GetComponent<Rigidbody>();
        Vector3 now = rb.position;
        if(isJump){
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            jumpcount++;
            isJump = false;

        }
        if(Input.GetKey(KeyCode.A)){
            now += side * -1;
            rb.position = now;
        }
        if(Input.GetKey(KeyCode.D)){
            now += side * 1;
            rb.position = now;
        }
        if(now.y < -10.0f){
            Debug.Log("game over");
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "floor"){
            jumpcount = 0;
        }
    }
}
