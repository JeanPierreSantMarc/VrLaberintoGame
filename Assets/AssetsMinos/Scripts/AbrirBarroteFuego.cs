using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class AbrirBarroteFuego : MonoBehaviour
{
    [SerializeField] private GameObject Barrote1;
    [SerializeField] private GameObject Barrote2;
    [SerializeField] private GameObject Barrote3;

    public bool fuego1 = false;
    public bool fuego2 = false;
    public bool fuego3 = false;
    public bool fuego4 = false;
    public bool fuego5 = false;
    public bool fuego6 = false;

    public Transform target1;
    public Transform target2;
    public Transform target3;
    public float speed;

    public bool puertaAbierta;
    

    // Start is called before the first frame update
    void Start()
    {
        puertaAbierta = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Barrote1.transform.position == target1.position && Barrote2.transform.position == target2.position && Barrote3.transform.position == target3.position)
        {
            puertaAbierta = true;
        }

        if ( fuego1 == true && fuego2 == true )
        { abrirBarrote1(); }
         if ( fuego3 == true && fuego4 == true )
        { abrirBarrote2(); }
         if ( fuego5 == true && fuego6 == true )
        { abrirBarrote3(); }

    }

    public void abrirBarrote1()
    {
        float step = speed * Time.deltaTime;
        Barrote1.transform.position = Vector3.MoveTowards(Barrote1.transform.position, target1.position, step);
    }public void abrirBarrote2()
    {
        float step = speed * Time.deltaTime;
        Barrote2.transform.position = Vector3.MoveTowards(Barrote2.transform.position, target2.position, step);
    }
    public void abrirBarrote3()
    {
        float step = speed * Time.deltaTime;
        Barrote3.transform.position = Vector3.MoveTowards(Barrote3.transform.position, target3.position, step);
    }
}
