using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorController : MonoBehaviour
{
    public float desplaHorizontal;
    public float velocidad = 10.0f;
    public float rangoX = 24.5f;
    public GameObject proyectilPizza;
    public GameObject proyectilManzana;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Lanza proyectiles de pizza con el boton de la barra espaciadora
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(proyectilPizza, transform.position, proyectilPizza.transform.rotation);
        }
        //Lanza proyectiles de manzana con el boton de Enter
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(proyectilManzana, transform.position, proyectilManzana.transform.rotation);
        }

        //EL jugador no se pueda salir de los limites del campo
        if(transform.position.x < -rangoX)
        {
            transform.position = new Vector3 (-rangoX, transform.position.y, transform.position.z);
        }
        //EL jugador no se pueda salir de los limites del campo
        if(transform.position.x > rangoX)
        {
            transform.position = new Vector3 (rangoX, transform.position.y, transform.position.z);
        }
        desplaHorizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * desplaHorizontal * Time.deltaTime * velocidad);
    }
}
