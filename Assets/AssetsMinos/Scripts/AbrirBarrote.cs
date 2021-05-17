using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class AbrirBarrote : MonoBehaviour
{
    [SerializeField] private GameObject BarroteSerpiente;
    [SerializeField] private GameObject BarroteHoja;
    [SerializeField] private GameObject BarrotePajaro;

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
        
        if (BarroteSerpiente.transform.position == target1.position && BarroteHoja.transform.position == target2.position && BarrotePajaro.transform.position == target3.position)
        {
            puertaAbierta = true;
        }

    }

    public void abrirBarrote1()
    {
        float step = speed * Time.deltaTime;
        BarroteSerpiente.transform.position = Vector3.MoveTowards(BarroteSerpiente.transform.position, target1.position, step);
    }public void abrirBarrote2()
    {
        float step = speed * Time.deltaTime;
        BarroteHoja.transform.position = Vector3.MoveTowards(BarroteHoja.transform.position, target2.position, step);
    }
    public void abrirBarrote3()
    {
        float step = speed * Time.deltaTime;
        BarrotePajaro.transform.position = Vector3.MoveTowards(BarrotePajaro.transform.position, target3.position, step);
    }
}
