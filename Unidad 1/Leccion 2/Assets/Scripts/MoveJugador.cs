using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
-- Jose Antonio Garcia Maryinez
-- 27/09/22
-- Clase que permite el movimiento del jugador al mismo tiempo tambien invoca los huesos para eliminar a los animales
**/

public class MoveJugador : MonoBehaviour
{   // Se definene las variables como la velocidad(vel) y el maximo(max)
    public float vel = 10.0F;
    public float max = 20;
    public GameObject hueso; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // Se crean dos condiciones para que el personje no salga del mapa y tenga limite 
        if(transform.position.x > max)
        {
            transform.position = new Vector3(max, transform.position.y, transform.position.z);
        }

        if(transform.position.x < -max)
        {
            transform.position = new Vector3(-max, transform.position.y, transform.position.z);
        }

        // Condicion para que al precionar una tecla se lanze el hueso
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(hueso, transform.position, hueso.transform.rotation);
        }
        // Movimiento del jugador
        float flechas = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*vel*flechas);
        
    }
}
