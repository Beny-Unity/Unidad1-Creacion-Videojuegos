using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorController : MonoBehaviour
{
    public GameObject[] animalesPrefab; //Array de animales Prefab
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarAnimal", 2.0f, 1.5f); //Generar de manera aleatoria animales entre 2 y 1.5 segundos
    }

    // Update is called once per frame
    void Update()
    {
        //Genera al presionar la tecla S
        // if(Input.GetKeyDown(KeyCode.S))
        // {
        //     GenerarAnimal();
        // }
    }

    void GenerarAnimal()
    {
            int indexAnimal = Random.Range(0,animalesPrefab.Length); //Generar de manera aleatoria un animal del array 
            Vector3 posisionAnimales = new Vector3(Random.Range(-24,24),0,20); //posicion del animal
            //Generar animal
            Instantiate(animalesPrefab[indexAnimal], posisionAnimales, animalesPrefab[indexAnimal].transform.rotation); //Crear el prefab en las cordenadas indicadas
    }
}
