using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
---Creado por Jose Antonio Garcia Martinez
-- 29/09/22
---Codigo para el movimiento de la camara
*/
public class PlayerController : MonoBehaviour
{
    // velocidad = al movimiento del camion
    public float velocidad = 6; 
    // avanza = mover el autobus con las flechas ariba y abajo 
    private float avanza;
    // Gira = mover el autobus con las flechas izquierda y derecha 
    private float gira;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Le damos valor a avanza
        avanza = Input.GetAxis("Vertical");
        // Le damos valor a gira
        gira = Input.GetAxis("Horizontal");
        // Movimiento para mover el autobus asia atras o adelante dependiendo las flechas que preciones
        transform.Translate(Vector3.forward * Time.deltaTime*velocidad*avanza);
        // Movimiento para mover el autobus asia la izquierda o derecha dependiendo las flechas que preciones
        transform.Rotate(Vector3.up, Time.deltaTime *30*gira);
     
    }
}
