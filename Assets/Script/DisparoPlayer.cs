using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DisparoPlayer : MonoBehaviour
{
    public bool disparando = false;

    public float cadenciaDisparo;
    
    public float fireRate = 0.5f;

    public GameObject balaMetralleta;
    public GameObject balaPistola;
    public GameObject balaEscopeta;

    public int tipoDeArma = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        cadenciaDisparo = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
       // Contador();
        
        if (disparando == true )
        {
           // cadenciaDisparo = Time.time + cadenciaDisparo2;

            StartCoroutine(DisparandoPistola());
            
           // Contador();
        }

        if (Input.GetKeyDown("1"))
        {
            tipoDeArma = 1;

            fireRate = 0.3f;
        }
        if (Input.GetKeyDown("2"))
        {
            tipoDeArma = 2;  
            
            fireRate = 0.1f;
        }
        if (Input.GetKeyDown("3"))
        {
            tipoDeArma = 3;   
            
            fireRate = 0.8f;
        }
        
        
        
    }

    public void Disparar()
    {
        disparando = true;
    }

    IEnumerator DisparandoPistola()
    {
        Debug.Log("si");
        
        if (cadenciaDisparo < Time.time && tipoDeArma == 1)
        {
            cadenciaDisparo = Time.time + fireRate;
            Instantiate(balaPistola, transform.position, transform.rotation);
            
            
          //  StopCoroutine("DisparandoPistola");
        }
        
        if (cadenciaDisparo < Time.time && tipoDeArma == 2) 
        {
            cadenciaDisparo = Time.time + fireRate;
            Instantiate(balaMetralleta, transform.position, transform.rotation);
        }
        
        if (cadenciaDisparo < Time.time && tipoDeArma == 3) 
        {
            cadenciaDisparo = Time.time + fireRate;
            Instantiate(balaEscopeta, transform.position, transform.rotation);
            Instantiate(balaEscopeta, transform.position, new Quaternion(transform.rotation.x,transform.rotation.y,transform.rotation.z + Random.Range(0.1f,0.01f), transform.rotation.w + Random.Range(0.1f,0.01f)));
            Instantiate(balaEscopeta, transform.position, new Quaternion(transform.rotation.x,transform.rotation.y,transform.rotation.z - Random.Range(0.1f,0.01f), transform.rotation.w - Random.Range(0.1f,0.01f)));
        }
        /*

        if (cadenciaDisparo > 1.01f)
        {
            cadenciaDisparo = 0;
        }
        */

        yield return null;
    }
/*
    public void Contador()
    {
        cadenciaDisparo += Time.deltaTime;
    }
    */
}
