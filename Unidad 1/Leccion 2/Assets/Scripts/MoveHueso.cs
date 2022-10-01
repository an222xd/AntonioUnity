using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
-- Jose Antonio Garcia Maryinez
-- 27/09/22
-- Clase que permite el movimiento del hueso para destruir a los animales
**/

public class MoveHueso : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Se crea una condicion para que el hueso, se destruya llegando a cierta posicion
        if (transform.position.z > 35)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector3.forward*Time.deltaTime*15); 
    }
}
