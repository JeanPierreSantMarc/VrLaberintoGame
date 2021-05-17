using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaCorrecta : MonoBehaviour
{
    public string tagObjeto;
    public AbrirBarrote barrotes;

    private bool funcionAbrirBarrote1 = false;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (funcionAbrirBarrote1 == true && tagObjeto == "Hoja")
        {
            barrotes.abrirBarrote1();
        }
       if (funcionAbrirBarrote1 == true && tagObjeto == "Pajaro")
        {
            barrotes.abrirBarrote2();
        }
       if (funcionAbrirBarrote1 == true && tagObjeto == "Serpiente")
        {
            barrotes.abrirBarrote3();
        }

    }
 void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.tag == tagObjeto)
            {
                funcionAbrirBarrote1 = true;
            }
        }
    void OnTriggerExit(Collider collider)
        {
            if (collider.gameObject.tag == tagObjeto)
            {
                funcionAbrirBarrote1 = false;
            }
        }
}
