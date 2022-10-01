using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
-- Jose Antonio Garcia Maryinez
-- 27/09/22
-- Clase que crea perros
**/

public class CrearDogs : MonoBehaviour
{
    //Creacion de instancias
    public GameObject[] dogs;

    // Start is called before the first frame update
    void Start()
    {
        //invoca una funcion para generar un animal cada cierto tiempo
        InvokeRepeating("CreateDog", 2, 1.5F); 
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.P))
        {
            
        }
        
    }
    void CreatePerro()
    {
        // Se crea una variable para la aparicion random de los animales y se da la ubicacion para que aparezcan
        int aleatorio = Random.Range(0,3);
        int x = Random.Range(-10, 10);
        Instantiate(dogs[aleatorio],new Vector3(x,0,20), dogs[aleatorio].transform.rotation);
    }
}
