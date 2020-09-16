using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    [SerializeField]Joystick joystick1;
    [SerializeField]Joystick joystick2;
    private Vector3 posicion;
    private Rigidbody2D _rigidbody;
    [SerializeField]private float velocidad;
  
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move(joystick1.AxisHorizontal(),joystick1.AxisVertical());
        Apuntar(transform.position.x+joystick2.AxisHorizontal(),transform.position.y+joystick2.AxisVertical());
    }
    
    void Move(float h,float v)
    {
        posicion.Set(h, v, 0);
 
        posicion= posicion.normalized * (velocidad * Time.deltaTime);
        _rigidbody.MovePosition(transform.position+posicion);
    }

    void Apuntar(float h,float v)
    {
        Vector2 posApuntar=new Vector2(h,v);

        transform.rotation = new Quaternion(posApuntar.x,posApuntar.y,0,0);
    }
}
