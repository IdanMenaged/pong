using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
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
        
    }

    public void Transition(string scene) {
        persistentData.gameMode = scene;
        SceneManager.LoadScene(scene);
    }
}
