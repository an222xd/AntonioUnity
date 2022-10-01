using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
-- Jose Antonio Garcia Maryinez
-- 27/09/22
-- Clase que crea perros
**/

public class CrearDog3 : MonoBehaviour
{
    //Creacion de instancias
    public GameObject[] dogs3;

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
        int x = Random.Range(-21, 21);
        Instantiate(dogs3[aleatorio],new Vector3(x,0,20), dogs3[aleatorio].transform.rotation);
    }
}
