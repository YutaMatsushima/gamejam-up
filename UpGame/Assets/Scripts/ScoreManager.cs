using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    private int prescore = 0;
    public GameObject item_object = null;
    public AudioClip sound1;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        Text item_text = item_object.GetComponent<Text>();
        item_text.text = "Score:" + score;
        if (score != prescore) {
            audioSource.PlayOneShot(sound1);
            prescore = score;
        }
    }
}
