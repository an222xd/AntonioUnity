using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
-- Jose Antonio Garcia Maryinez
-- 27/09/22
-- Clase que permite el movimiento de los animales asia delante
**/

public class MoveAnimals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Condicion para que los animales que se generen se destruyan
        if (transform.position.z < -22)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.forward*Time.deltaTime*10);
    }
}
