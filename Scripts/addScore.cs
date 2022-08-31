using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addScore : MonoBehaviour
{
    private AudioSource AudioSource;
    public AudioClip collect = null;

    private void Awake() 
    {
        AudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        AudioSource.PlayOneShot(collect);
        Score.score++;
    }
}
