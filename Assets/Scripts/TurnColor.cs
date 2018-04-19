using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColor : MonoBehaviour {

    Renderer rend;


    private void Start()
    {
        Renderer rend = GetComponent<Renderer>();
    }

    private void OnEnable()
    {
        EventManager.Killed += ChangeColor;
    }

    private void OnDisable()
    {
        EventManager.Killed -= ChangeColor;
    }

    void ChangeColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        rend.material.SetColor("rosso",Color.red);
    }
}
