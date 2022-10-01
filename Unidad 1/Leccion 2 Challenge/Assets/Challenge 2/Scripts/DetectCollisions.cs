using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 -- Jose Antonio Garcia Martinez
 -- 29/09/22
 -- Clase que destruye los objetos al momento que los dos chocan
 */
public class DetectCollisions : MonoBehaviour
{
    // Funcion que destruye los objetos al chocar.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
