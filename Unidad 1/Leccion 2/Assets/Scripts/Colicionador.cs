using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
-- Jose Antonio Garcia Maryinez
-- 27/09/22
-- Clase que destruye los objetos al chocar uno contra el otro
**/
public class Colicionador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Metodo para destruir objetos
    void OnTriggerEnter(Collider other)
    {    
        Destroy(gameObject); //Va destruyendo los objetos 
    }
}
