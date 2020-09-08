using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int vida;
    public float velocidadDeMovimiento;
    public float velocidadDeAtaque;
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-velocidadDeMovimiento,0,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(velocidadDeMovimiento,0,0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0,-velocidadDeMovimiento,0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,velocidadDeMovimiento,0);
        }
    }
}
