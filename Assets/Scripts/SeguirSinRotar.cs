using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirSinRotar : MonoBehaviour
{
    public GameObject Jugador;
    private Vector3 distancia;

    // Start se llama antes del primer frame 

    void Start()
    {
       distancia = transform.position - Jugador.transform.position;
    }

    // Update se llama 1 vez por Frama

    void Update()
    {

    }

    private void LateUpdate()
    {
        transform.position = Jugador.transform.position + distancia;
    }
}