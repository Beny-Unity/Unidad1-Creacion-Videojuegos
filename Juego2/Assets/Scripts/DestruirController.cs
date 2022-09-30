using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirController : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
