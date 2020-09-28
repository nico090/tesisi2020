using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvocadorEnemigos : MonoBehaviour
{
    public GameObject[] Enemys;
    void Start()
    {
        InvokeRepeating("GenerearEnemys", 0f, Random.Range(1f, 2f));
    }

    void GenerearEnemys()
    {
        Instantiate(Enemys[0], transform.position, Quaternion.identity);
    }
}
