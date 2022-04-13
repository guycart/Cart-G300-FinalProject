using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Statistics : MonoBehaviour
{
    
    public static int scoreInt;
    public static float timer;
    public Text score,time;


    void Update()
    {
        timer += Time.deltaTime;
        score.text = "Score:" + scoreInt;
        time.text = "Time:" + timer;
    }
}
