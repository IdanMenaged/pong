using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public float speed;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > ball.transform.position.y) {
            transform.position -= speed * Time.deltaTime * transform.up;
        }
        else if (transform.position.y < ball.transform.position.y) {
            transform.position += speed * Time.deltaTime * transform.up;
        }
    }
}
