using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 -- Jose Antonio Garcia Martinez
  -- 30/09/22
 -- Clae para que la avioneta no le afecte la gravedad al comenzar
*/

public class Camara : MonoBehaviour
{
    public GameObject avioneta; // declaramos nuestra avioneta
    private Vector3 offset = new Vector3(20,2,0); // Que se quede estatica la avioneta cuando comienza

    // Start is called before the first frame update
    void Start()
    {

    } 

    // Update is called once per frame
    void Update()
    {
        //Metodo de movimiento estatico
        transform.position = avioneta.transform.position + offset; 
    }
}
