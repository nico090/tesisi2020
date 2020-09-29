using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "Atack_Dis", menuName = "Atack_Dis")]
public class Atack_Dis : AbstractAction
{
    public float angle;
    private Vector3 direccion;

    private RaycastHit2D hit;

    private Rigidbody2D ownerRb;

    public float velocidadDeRotacion = 3f;

    // private Rigidbody2D rb;
    // public Transform player;
    public override IEnumerator Execute(Enemy owner)
    {
        ownerRb = owner.GetComponent<Rigidbody2D>();

        do
        {
            direccion = FindObjectOfType<Player>().transform.position - owner.transform.position;

            direccion.Normalize();
            
            //Debug.Log(direccion);

            angle = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg - 90f;

            ownerRb.rotation = angle;

            hit = Physics2D.Raycast(owner.transform.position, direccion,100f, 1<<9 | 1<<10 );

            if (hit.collider != null)
            {
                Debug.Log(hit.collider.name);
            }

            Debug.DrawRay(owner.transform.position, direccion, Color.red);

           // Debug.Log(angle);

            yield return new WaitForFixedUpdate();
        } while (hit.collider.gameObject.tag != "Player");
        
        Debug.Log("termine");
        
            
        // yield return owner.StartCoroutine(owner.Ai());
        // owner.Think = owner.Think + 1;

        // Debug.Log(direccion);

        //yield return new WaitForFixedUpdate();
    }
}