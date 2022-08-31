using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public AudioClip victorySound;
    private AudioSource AudioSource;

    private void Awake() 
    {
        AudioSource = GetComponent<AudioSource>();
    }

    private void Start() 
    {
        score = 0;
    }

    private void Update() 
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}

