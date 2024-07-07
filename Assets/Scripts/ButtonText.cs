using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonText : MonoBehaviour
{
    public Color hoverColor;
    public TMP_Text text;

    private Color ogColor;

    // Start is called before the first frame update
    void Start()
    {
        ogColor = text.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnPointerEnter(PointerEventData eventData) {
        text.color = hoverColor;
    }

    void OnPointerExit(PointerEventData eventData) {
        text.color = ogColor;
    }
}
