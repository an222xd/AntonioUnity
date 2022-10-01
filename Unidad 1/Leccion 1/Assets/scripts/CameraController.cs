using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
---Creado por Jose Antonio Garcia Martinez
-- 29/09/22
---Codigo para el movimiento de la camara
*/
public class CameraController : MonoBehaviour
{
    // Definimos el objeto que utilizaremos para que la camara lo siga
    public GameObject autobus;
    // Start is called before the first frame update

    // Definimos las cordenadas que debe de seguir antes de comenzar
    private Vector3 posicion = new Vector3(5,10,-10);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // le damos la posicion del autobus + la posicion donde queremos que siga
        transform.position = autobus.transform.position + posicion;
    }
}
