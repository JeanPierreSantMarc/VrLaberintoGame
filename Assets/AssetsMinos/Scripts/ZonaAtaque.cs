using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaAtaque : MonoBehaviour
{
    public Ataque ataque;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.layer == 10)
        {
           ataque.atacando = true;
        }
    }
}
