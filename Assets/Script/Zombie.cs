using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{

    public Transform player;
  
    public Enemy enemy;

    public Player pl;
    private void Start()
    {
        pl = FindObjectOfType<Player>();
    }

    void Update()
    {
        transform.LookAt(player, Vector3.left);

        transform.Translate(0, 0, enemy.velocidadDeMovimiento);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Player":

                InvokeRepeating(("HacerDano"), enemy.velocidadDeAtaque, enemy.velocidadDeAtaque);
                
                break;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Player":

                Invoke("DejarDeHacerDaño", 0f);
                
                break;
        }
    }

    void HacerDano()
    {
        pl.vida -= enemy.dano;

    }

    void DejarDeHacerDaño()
    {
        CancelInvoke();
    }
    
    
}
