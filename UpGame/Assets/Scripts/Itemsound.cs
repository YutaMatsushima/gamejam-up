using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemsound : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player"){
            audioSource.PlayOneShot(sound1);
        }
    }
}
