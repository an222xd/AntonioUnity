using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 -- Jose Antonio Garcia Martinez
  -- 30/09/22
 -- Clae para mover avioneta
*/
public class PlayerController : MonoBehaviour
{
    public float vel = 10; // La velocidad de la avioneta
    public float verGiro = 30; // La rotacion 
    public float verInput = 10; // La velocidad para subir y bajar, de la avioneta

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Configuramos las teclas
        verInput = Input.GetAxis("Vertical");

        // Velocidad de movimiento de la avioneta
        transform.Translate(Vector3.forward * vel * Time.deltaTime);

        // Velocidad para cambiar posicion de la avioneta
        transform.Rotate(Vector3.left * verGiro * Time.deltaTime * verInput);
    }
}
