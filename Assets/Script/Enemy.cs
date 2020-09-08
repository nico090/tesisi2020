using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class Enemy : ScriptableObject
{
    public string name;
    public int vida;
    public int dano;
    public float velocidadDeMovimiento;
    public float velocidadDeAtaque;
    public Sprite arteSprite;
}
