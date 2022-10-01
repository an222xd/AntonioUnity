using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 -- Jose Antonio Garcia Martinez
 -- 29/09/22
 -- Clase que le da autorizacion a la barra espaciadora de generar un dog para que atrape la pelota
*/
public class PlayerController : MonoBehaviour
{
    public GameObject dogs;

    // Update is called once per frame
    void Update()
    {
        // Al presionar la barra espaciadora, por lo cual esta funcion creara un objeto de tipo dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogs, transform.position, dogs.transform.rotation);
        }
    }
}
