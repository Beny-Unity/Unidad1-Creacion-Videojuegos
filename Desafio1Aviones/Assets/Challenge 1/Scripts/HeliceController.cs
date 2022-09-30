/*
    Nombre: Benjamin Ramirez Bolaños
    Grupo: GDGS2101 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliceController : MonoBehaviour
{
    public float velocidad = 1000.0f; //Velocidad a que se mueva la helice
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * velocidad); //Rotar el helice a la velocidas establecida
    }
}
