using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirar : MonoBehaviour
{
    private Vector3 direccion;

    private Rigidbody2D rb;

    public Transform player;

    public float angle;
    
    // Start is called before the first frame update
    void Start()
    {
        rb =  GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direccion = player.position - transform.position;

        angle = (Mathf.Atan2(direccion.y, direccion.x) *  Mathf.Rad2Deg) - 90f;

        rb.rotation = angle;
        
        Debug.Log(direccion);
        
        
    }
}
