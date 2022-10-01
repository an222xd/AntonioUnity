
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 -- Jose Antonio Garcia Martinez
 -- 29/09/22
 -- Clase que destruye los objetos llegando al limite de distancia requerida
*/
public class DestroyOutOfBounds : MonoBehaviour
{
    // limite de distancia antes de destruir el objeto ya sea limite superior izquierdo, o que las pelotas terminen en el suelo
    private float leftLim = -40;
    private float bottomLim = -5;

    // Update is called once per frame
    void Update()
    {
        // Destruir perros si la posición X es inferior al límite izquierdo
        if (transform.position.x < leftLim)
        {
            Destroy(gameObject);
        } 
        // Destruye las pelotas si la posición Y es menor que el suelo del juego 
        else if (transform.position.y < bottomLim)
        {
            Destroy(gameObject);
        }

    }
}
