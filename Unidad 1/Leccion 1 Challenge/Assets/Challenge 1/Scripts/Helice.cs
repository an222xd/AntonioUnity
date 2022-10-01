using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 -- Jose Antonio Garcia Martinez
 -- 30/09/22
 -- Clae para mover helice de la avioneta
*/
public class Helice : MonoBehaviour
{
    //Se le asigna un valor para dar la velocidad a la helice para que tenga un mejor diseño
    public float velGiro = 1250.0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Aplicamos la velocidad a la helice
        transform.Rotate(Vector3.forward * velGiro); 
    }
}

