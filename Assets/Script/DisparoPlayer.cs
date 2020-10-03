using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoPlayer : MonoBehaviour
{
    public bool disparando = false;

    public float cadenciaDisparo;
    
    public float cadenciaDisparo2 = 0.5f;

    public GameObject bala;
    
    // Start is called before the first frame update
    void Start()
    {
       // cadenciaDisparo =+ cadenciaDisparo2;
        
        cadenciaDisparo = Time.time;
        
        cadenciaDisparo =+ cadenciaDisparo2;
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (disparando == true && cadenciaDisparo < Time.time)
        {
            cadenciaDisparo = Time.time + cadenciaDisparo2;
            
            StartCoroutine(DisparandoPistola());

          //  cadenciaDisparo = Time.time + cadenciaDisparo2;
        }
    }

    public void Disparar()
    {
        disparando = true;
    }

    IEnumerator DisparandoPistola()
    {
        //if (cadenciaDisparo < Time.time)
        //{
        Instantiate(bala, transform.position, transform.rotation);
        
        
            Debug.Log("Estoy disparando");
            
        //}
        

        yield return null;
    }
}
