using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMove : MonoBehaviour
{
    public Transform transform;
    public float speed;
    public float fuerzaSalto;
    public float dirX;
    public Rigidbody2D rb;
    public bool tocandoSuelo;
    public SpriteRenderer spr;
    public Animator anim;
    void Start()
    {
        rb.gravityScale = 2;
    }

    
    void Update()
    {
        /*if(Input.GetKey(KeyCode.D)){// keycode si mantengo presionado
            transform.position += new Vector3(speed,0,0) * Time.deltaTime; // alteramos posicion
        }
        if(Input.GetKey(KeyCode.A)){
            transform.position -= new Vector3(speed,0,0) * Time.deltaTime; 
        }
        if(Input.GetKeyDown(KeyCode.Space) && tocandoSuelo){//getkeydown si presiono una vez
           rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse); 
           tocandoSuelo = false;
        }*/
        dirX = Input.GetAxis("Horizontal");
        
        //
        if(dirX > 0){
            spr.flipX = false;
            anim.SetBool("estaCorriendo",true);
            transform.position += new Vector3(dirX * speed,0,0);
        } 
        if(dirX < 0) {
            spr.flipX = true;
            anim.SetBool("estaCorriendo",true);
            transform.position += new Vector3(dirX * speed,0,0);
        }
        if(dirX == 0){
            anim.SetBool("estaCorriendo",false);
        }
        if(dirX > 0 && Input.GetKeyDown(KeyCode.X)){
            spr.flipX = false;
            anim.SetBool("estaCorriendo",true);
            transform.position += new Vector3(dirX * 0.032f,0,0);
        } 
        if(dirX < 0 && Input.GetKeyDown(KeyCode.X)) {
            spr.flipX = true;
            anim.SetBool("estaCorriendo",true);
            transform.position += new Vector3(dirX * 0.032f,0,0);
        }
        if(Input.GetKeyDown(KeyCode.Space)){//getkeydown si presiono una vez
           rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
           anim.SetBool("estaSaltando",true);
        }
        if(Input.GetKeyUp(KeyCode.Space)){//getkeyup si suelto
           anim.SetBool("estaSaltando",false);
        }
        
    }
    public void OnCollisionEnter2D(Collision2D laCosa)// Si toco algo
    {
        if(laCosa.gameObject.tag == "Suelo" ) //si el cuerpo de lacosa que yo choque tiene tag suelo
        {
            Debug.Log("Tocando Suelo");
            tocandoSuelo = true; 
        }
    }
}
