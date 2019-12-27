using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSound : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    public GameObject player;
    private int count = 0;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (player.transform.position.y < -10.0f && count == 0) {
            audioSource.PlayOneShot(sound1);
            count++;
        }
    }
}
