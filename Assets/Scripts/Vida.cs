using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public float vida;
    public Slider barraVida;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        barraVida.value = vida;
        if(vida <=0){
            Destroy(gameObject);
        }
    }
}
