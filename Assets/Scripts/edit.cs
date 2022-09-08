using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class edit : MonoBehaviour
{
    public Text puntaje;
    public static int puntajes;
    void Start()
    {
        
    }

    void Update()
    {
        puntaje.text = "Puntaje: " + puntajes.ToString();
    }
}
