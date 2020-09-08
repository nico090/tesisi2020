using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : ScriptableObject
{
    private float currentHP;
        private  float maxHP;
        public bool IsAlive { get; private set; }

        public float CurrentHP
        {
            get => currentHP;
            set
            {
                currentHP = value;
                if (currentHP <= 0)
                {
                    currentHP = 0;
                    IsAlive = false;
                }
            }
        }

        public float MaxHP => maxHP;




    }



