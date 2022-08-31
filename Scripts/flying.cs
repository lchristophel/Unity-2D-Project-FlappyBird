using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flying : MonoBehaviour
{
    private AudioSource AudioSource;
    public AudioClip birdSound = null;
    public gameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;

    private void Awake() 
    {
        AudioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            AudioSource.PlayOneShot(birdSound);
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<gameManager>().GameOver();
            
        } 
        else if (collision.gameObject.tag == "Scoring")
        {
            FindObjectOfType<gameManager>().IncreaseScore();
        }
    }
}
