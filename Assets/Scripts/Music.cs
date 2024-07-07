using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private static Music instance;

    // Start is called before the first frame update
    void Start()
    {
        // make singleton
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject); // makes sure music keeps playing on different scenes
        }
        else {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
