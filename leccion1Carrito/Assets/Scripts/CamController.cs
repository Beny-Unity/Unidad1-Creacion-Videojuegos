/*
    Nombre: Benjamin Ramirez Bolaños
    Grupo: GDGS2101 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public GameObject carro;
    public Vector3 upCam = new Vector3(0,10,-15); //Variable para posicionar la camara a cierta distancia del carro
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = carro.transform.position + upCam; //Pocisionar la camara
    }
}
