/*
    Nombre: Benjamin Ramirez Bolaños
    Grupo: GDGS2101 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float velocidad = 20;
    public float turnSpeed = 160;
    public float horizontalInput;
    public float forwadInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); //Obtener el input de manera horizontal
        forwadInput = Input.GetAxis("Vertical"); //Obtener el input de manera vertical

        //Mover el auto o acelerar para lo cual se mutiplican los vectores de la posicion y la velocidad y la entrada
        transform.Translate(Vector3.forward*Time.deltaTime*velocidad * forwadInput); 

        //Poder mover el auto a los lados con la posicion y la velocidad establecida
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
