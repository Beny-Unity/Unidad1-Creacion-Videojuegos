/*
    Nombre: Benjamin Ramirez Bolaños
    Grupo: GDGS2101 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical"); //Obtener la entrada de manera verticar

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime); // Mover el Avion a una velocidad establecida

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput); // Permite rotar el avion con las entradas verticales
    }
}
