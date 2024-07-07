using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SettingsSlider : MonoBehaviour
{
    public string sourcePath;

    private Slider slider;
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        source = GameObject.Find(sourcePath).GetComponent<AudioSource>();

        slider.value = source.volume;

        slider.onValueChanged.AddListener(delegate { ChangeVolume(); }); // handle changed volume
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ChangeVolume() {
        source.volume = slider.value;
    }
}
