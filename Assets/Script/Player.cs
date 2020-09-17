using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    [SerializeField]Joystick joystick1;
    [SerializeField]JoystickRotate joystick2;
    private Vector3 posicion;
    private Rigidbody2D _rigidbody;
    [SerializeField]private float velocidad;
    private Vector2 lookVec;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move(joystick1.AxisHorizontal(),joystick1.AxisVertical());
       
       Apuntar(joystick2.AxisHorizontal(), joystick2.AxisVertical());
    }
    
    void Move(float h,float v)
    {

        transform.localPosition += Time.deltaTime * new Vector3(h, v, 0) * 2f;
        


        /*
        posicion.Set(h, v, 0);
 
        posicion= posicion.normalized * (velocidad * Time.deltaTime);
        _rigidbody.MovePosition(transform.position+posicion);
        */
    }

    void Apuntar(float h,float v)
    {
        lookVec = new Vector2(h,v);
        
       
        transform.LookAt((new Vector2(transform.position.x, transform.position.y) + lookVec));
        
        
    }
    
}
