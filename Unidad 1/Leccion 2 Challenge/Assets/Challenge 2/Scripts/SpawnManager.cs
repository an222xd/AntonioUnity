using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 -- Jose Antonio Garcia Martinez
 -- 29/09/22
 -- Clase que destruye los objetos llegando al limite de distancia requerida
*/
public class SpawnManager : MonoBehaviour
{
    // Creamos nuestro objeto tipo pelota
    public GameObject[] ball;
    // Creamos los limites izquierdo y derecho
    private float spawnLimitLeft = -22;
    private float spawnLimitRight = 7;
    // Creamos la posicion donde se generara la pelota = a la altura de donde caera
    private float spawnPosicionY = 30;

    //ponemos nuestro intervalo de tiempo para que tenga una duracion de cada cierto tiempogenerar una nueva pelota
    private float delay = 1.0f;
    private float interval = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Invocamos nuestro intervalo de tiempo
        InvokeRepeating("SpawnRandomBall", delay, interval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {   
        // Variable que nos crea un arreglo para generar diferentes pelotas
        int pelota = Random.Range(0, 3);
        // Creamos una variable que genera cada cierto tiempo una pelota en un diferente lugar
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitLeft, spawnLimitRight), spawnPosicionY, 0);

        // Genera una pelota en un lugar aleatorio
        Instantiate(ball[pelota], spawnPos, ball[pelota].transform.rotation);
    }

}
