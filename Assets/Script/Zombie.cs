using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{

    public Transform player;

    public int vida = 100;

    public int dano = 5;

    public float velocidad = 0.01f;
    
    
    void Update()
    {
        transform.LookAt(player, Vector3.left);

        transform.Translate(0, 0, velocidad);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Player":
                
                
                
                InvokeRepeating(("HacerDano"),1f,1f);

               // StartCoroutine("Dano");

                break;
        }
    }

    void HacerDano()
    {

        print("verdadero");
        
        //hp.player -= dano;


    }
    
    
}
