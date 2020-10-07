using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float speed = 0.5f;
    public float tiempodevida = 0.5f;
    public float dano = 10;
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
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Esqueleto")
        {

            other.gameObject.GetComponent<Esqueleto>().Hp -= dano;
            Destroy(gameObject);
        }
        if (other.tag == "Zombie")
        {

            other.gameObject.GetComponent<Zombie>().Hp -= dano;
            Destroy(gameObject);
        }
        if (other.tag == "Kamikaze")
        {

            other.gameObject.GetComponent<Kamikaze>().Hp -= dano;
            Destroy(gameObject);
            
        }
        
        
    }

    }


