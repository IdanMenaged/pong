using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string inputMethod = "wasd"; // wasd or arrows
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        if (!inputMethod.Equals("wasd") && !inputMethod.Equals("arrows")) {
            Debug.LogError("input method " + inputMethod + " is invalid. must be 'wasd' or 'arrows'");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // move
        if ((inputMethod.Equals("wasd") && Input.GetKey(KeyCode.W)) || (inputMethod.Equals("arrows") && Input.GetKey(KeyCode.UpArrow))) {
            transform.position += speed * Time.deltaTime * transform.up;
        }
        else if ((inputMethod.Equals("wasd") && Input.GetKey(KeyCode.S)) || (inputMethod.Equals("arrows") && Input.GetKey(KeyCode.DownArrow))) {
            transform.position -= speed * Time.deltaTime * transform.up;
        }
    }
}
