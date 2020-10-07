using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float speed = 0.5f;
    public float tiempodevida = 0.5f;
    void Start()
    {
        Invoke("Destruir", tiempodevida);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,speed,0);
    }

    void Destruir()
    {
        Destroy(gameObject);
    }
}

