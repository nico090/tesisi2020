using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArrow : MonoBehaviour
{
   [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destruir", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,speed,0);
    }

    void Destruir()
    {
        Destroy(gameObject);
    }
}
