using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalirEscenaController : MonoBehaviour
{
    float limiteSuperior = 35;
    float limiteInferior = -11; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ejecuta la sentencia solo si se superan los limites ya sean superiores o inferiores
        if (transform.position.z > limiteSuperior || transform.position.z < limiteInferior) 
        {
            //Destruye el objeto que sale de los limites
            Destroy(gameObject);
        }
    }
}
