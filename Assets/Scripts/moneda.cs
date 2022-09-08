using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneda : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D laCosa)
    {
        if (laCosa.tag == "Player"){
            Destroy(gameObject);
            edit.puntajes += 1;
        }
    }
}
