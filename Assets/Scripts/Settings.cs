using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    private PersistentData persistentData;

    // Start is called before the first frame update
    void Start()
    {
        persistentData = GameObject.Find("Persistent Data").GetComponent<PersistentData>();
    }

    // Update is called once per frame
    void Update()
    {
        // back to main game
        if (Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene(persistentData.gameMode);
        }
    }

    public void Exit() {
        Application.Quit();
    }

    public void BackToMainMenu() {
        SceneManager.LoadScene("Main Menu");
    }
}
