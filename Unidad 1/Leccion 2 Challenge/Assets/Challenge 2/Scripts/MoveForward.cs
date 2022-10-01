using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 -- Jose Antonio Garcia Martinez
 -- 29/09/22
 -- Clase que destruye los objetos llegando al limite de distancia requerida
*/
public class MoveForward : MonoBehaviour
{
    // Definimos velocidad
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // Esta linea sirve para mover el dog en linea recta.
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
