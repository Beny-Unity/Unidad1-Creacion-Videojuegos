using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Generar la primera bola pasando un segundo
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int bola = Random.Range(0, 3); // crear una variable para que genere un numero aleatorio entre 0, 1 y 2
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[bola], spawnPos, ballPrefabs[bola].transform.rotation); // intercambiar el valor en el vector para que aparezcan diferentes tipos de pelotas

        //Generar bolas de manera aleatoria
        startDelay = Random.Range(0,5);
        Invoke("SpawnRandomBall", startDelay);

    }

}
