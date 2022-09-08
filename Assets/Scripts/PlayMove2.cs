using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMove2 : MonoBehaviour
{
    public Transform transform;
    public float speed;
    public float dirX;
    public float fuerzaSalto;
    public Rigidbody2D rb;
    public SpriteRenderer spr;
    void Start()
    {
        
    }

    
    void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        transform.position += new Vector3(dirX * speed,0,0);
        //
        if(dirX > 0) spr.flipX = false;
        if(dirX < 0) spr.flipX = true;
        if(Input.GetKeyDown(KeyCode.Space)){//getkeydown si presiono una vez
           rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse); 
        }
    }
}
