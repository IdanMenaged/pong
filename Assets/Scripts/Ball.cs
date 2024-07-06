using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    public float speed = 5;
    
    public TMP_Text score1;
    public TMP_Text score2;

    public float rightBoundry = 4.89f;
    public float leftBoundry = -4.89f;

    public AudioSource audio;
    public AudioClip[] audioClips;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = transform.right * speed * -1;
    }

    // Update is called once per frame
    void Update()
    {
        // check out of bounds
        float screenWidth = Camera.main.aspect * Camera.main.orthographicSize;

        if (transform.position.x >= rightBoundry) {
            // inc score
            score1.text = (int.Parse(score1.text) + 1) + "";
            Restart();
        }
        else if (transform.position.x <= leftBoundry) {
            // inc score
            score2.text = (int.Parse(score2.text) + 1) + "";
            Restart();
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        // add random direction
        float angle = UnityEngine.Random.Range((float) -Math.PI / 4, (float) Math.PI / 4);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)).normalized;
        rb.velocity = (rb.velocity + direction).normalized * speed;

        // play sound effect
        audio.clip = audioClips[UnityEngine.Random.Range(0, audioClips.Length)];
        audio.Play();
    }

    private void Restart() {
        transform.position = new Vector3(0, 0, 0);
        rb.velocity = transform.right * speed * -1;
        rb.angularVelocity = 0;
    }
}
