using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncenderFuego : MonoBehaviour
{
    public GameObject Fuego;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.layer == 7)
        {
           Fuego.gameObject.SetActive(true);
        }
    }
}
