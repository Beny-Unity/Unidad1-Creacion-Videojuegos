using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float tiempoEspera = 1;
    private float tiempoSigDisparo = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > tiempoSigDisparo) //Agregar a la decision condicion para que solo sea cada tiempo
        {
            tiempoSigDisparo = Time.time + tiempoEspera; //sumar el tiempo de espera
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
