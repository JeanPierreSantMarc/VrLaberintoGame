using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ataque : MonoBehaviour
{
    Rigidbody rb;
    public Transform target;
    public float speed = 0.1f;
    public float acel = 0.1f;

   
    public bool atacando = false;

    public Animator anim;

    public GameObject comer;
    public GameObject grito;
    public GameObject pasos;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
 
        anim = GetComponent<Animator>();

    }

    void FixedUpdate()
    {

        if ( atacando == true )
        {
            
            Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
            rb.MovePosition(pos);
            transform.LookAt(target);
            speed = speed + acel;

            anim.SetBool("ataque", true);

            atacando = true;

            comer.SetActive(false);
            grito.SetActive(true);
            pasos.SetActive(true);

        }
       
    }


}