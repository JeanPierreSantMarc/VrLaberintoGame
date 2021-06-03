using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncenderFuegoBarrote : MonoBehaviour
{
    public GameObject Fuego;
    public AbrirBarroteFuego Abrir;
    public float numero;

    public GameObject Bloques;


    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.layer == 7)
        {
           Fuego.gameObject.SetActive(true);
           
            if (numero == 1)
            {
                Abrir.fuego1 = true;
            }

            else if (numero == 2)
            {
                Abrir.fuego2 = true;
            }

             else if (numero == 3)
            {
                Abrir.fuego3 = true;
            }

             else if (numero == 4)
            {
                Abrir.fuego4 = true;
            }

             else if (numero == 5)
            {
                Abrir.fuego5 = true;
            }

             else if (numero == 6)
            {
                Abrir.fuego6 = true;
            }

             else if (numero == 69)
            {
                Bloques.SetActive(true);
            }


        }
    }
}
