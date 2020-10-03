using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    [SerializeField] Joystick joystick1;
    [SerializeField] JoystickRotate joystick2;
    private Vector3 posicion;
    private Rigidbody2D _rigidbody;
    [SerializeField] private float velocidad;
    private Vector2 lookVec;
    

    private void Start()
    {
        
        
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move(joystick1.AxisHorizontal(), joystick1.AxisVertical());

        Apuntar(joystick2.AxisHorizontal(), joystick2.AxisVertical());
    }

    void Move(float h, float v)
    {

        transform.localPosition += new Vector3(h, v, 0) * (Time.deltaTime * 2f);



        /*
        posicion.Set(h, v, 0);
 
        posicion= posicion.normalized * (velocidad * Time.deltaTime);
        _rigidbody.MovePosition(transform.position+posicion);
        */
    }

    void Apuntar(float h, float v)
    {
        /*
        lookVec = new Vector2(h,v);
        
       
        transform.LookAt((new Vector2(transform.position.x, transform.position.y) + lookVec), Vector3.down);
        */

        if (h < 10f || v < 10f || h > -10f)

        {
            lookVec = new Vector2(h, v);

            var transform1 = transform;
            var position1 = transform1.position;
            Vector2 position = new Vector2(position1.x, position1.y);

            Vector2 axis = position + new Vector2(h, v);



            Vector2 playerToAxis = axis - position;
            playerToAxis = playerToAxis.normalized;
            float angle = Mathf.Atan2(playerToAxis.y, playerToAxis.x) * Mathf.Rad2Deg -90;

            _rigidbody.rotation = angle;
            
        }

        
       


    }
}

