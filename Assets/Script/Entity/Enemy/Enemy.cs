using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    private float distancePlayer;

    float attackDistance;

    private float attackVelocity;

   [SerializeField] private Ai_Controller controller;

    IEnumerator Ai()
    {
        StartCoroutine(controller.ThinkRoutine());

        
        
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
        StartCoroutine(Ai());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
