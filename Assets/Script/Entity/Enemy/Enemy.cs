using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    private float distancePlayer;

    float attackDistance;

    private float attackVelocity;

    private Rigidbody2D rb;
    
   [SerializeField] private Ai_Controller controller;

   public int Think { get; set; }
    public IEnumerator Ai()
    {
        StartCoroutine(controller.ThinkRoutine(this));

        controller.Think = Think;
        
        yield return new WaitForEndOfFrame();
    }

    bool Death(bool isAlive)//bool is alive herencia
    {

        return isAlive;
    }

    void Attack()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        Think = 0;
        velocity = .5f;
        StartCoroutine(Ai());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
