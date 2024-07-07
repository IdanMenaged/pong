using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    private string gameMode;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // back to main game
        if (Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene(gameMode);
        }
    }
}
