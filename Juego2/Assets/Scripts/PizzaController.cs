using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaController : MonoBehaviour
{
    public float velocidad = 40.0f; //Velocidad asiganda al proyectil
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad); //Mueve el trozo de pizza o a los animales
    }
}
