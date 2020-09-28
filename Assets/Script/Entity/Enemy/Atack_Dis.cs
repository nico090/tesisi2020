using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
[CreateAssetMenu(fileName = "Atack_Dis", menuName = "Atack_Dis")]
public class Atack_Dis : AbstractAction
{
    private Vector3 direccion;
    public float velocidadDeRotacion = 3f;

   // private Rigidbody2D rb;
   // public Transform player;
   public override IEnumerator Execute(Enemy owner)
   {
       

        direccion = FindObjectOfType<Player>().transform.position - owner.transform.position;

        float angle = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Deg2Rad;

        owner.GetComponent<Rigidbody2D>().rotation = angle;
        
        
        
        
        
        
        //owner.GetComponent<Rigidbody2D>().MoveRotation(Mathf.LerpAngle((owner.transform.position,direccion,3f * Time.deltaTime));
        Debug.Log(direccion);
        
        
        /*
        direccion = Quaternion.LookRotation(FindObjectOfType<Player>().transform.position - owner.transform.position);
        owner.transform.rotation = Quaternion.Slerp(direccion, owner.transform.rotation, velocidadDeRotacion * Time.deltaTime);
        */
        
        
        
        
        
        //owner.transform.rotation = Quaternion.
        //owner.transform.RotateAround(FindObjectOfType<Player>().transform.position, Vector3.back, 3f * Time.deltaTime);

        yield return null;
        
        
        //owner.StartCoroutine(owner.Ai());
        //  owner.Think = owner.Think + 1;
    }
    
}
