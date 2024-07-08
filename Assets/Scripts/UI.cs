using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    private CanvasGroup canvasGroup;

    private static UI instance;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }

        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        string scene = SceneManager.GetActiveScene().name;
        if (scene.Equals("Singleplayer") || scene.Equals("Multiplayer")) {
            canvasGroup.alpha = 1;
        }
        else if (scene.Equals("Settings")) {
            canvasGroup.alpha = 0;
        }
        else {
            Destroy(gameObject);
        }
    }
}
