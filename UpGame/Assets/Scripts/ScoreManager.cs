using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public GameObject item_object = null;

    void Update()
    {
        Text item_text = item_object.GetComponent<Text>();
        item_text.text = "Score:" + score;
    }
}
