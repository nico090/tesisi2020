using System.Collections;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Atack_Dis", menuName = "Atack_Dis")]
public class Atack_Dis : AbstractAction
{
    public float angle;
    private Vector3 direccion;

    private GameObject owner_;
    
    private RaycastHit2D hit;

    private Rigidbody2D ownerRb;
Transform playerTransform;

    

    public float velocidadDeRotacion = 3f;
    
 [SerializeField] private GameObject arrow;
    // private Rigidbody2D rb;
    // public Transform player;
    public override IEnumerator Execute(Enemy owner)
    {
        ownerRb = owner.GetComponent<Rigidbody2D>();
        playerTransform = FindObjectOfType<Player>().transform;
        owner_ = owner.GetComponent<GameObject>();
        do
        {
            
            direccion = playerTransform.position - owner.transform.position;

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

        if (hit.collider.gameObject.tag == "Player")
        {
            Object.Instantiate(arrow , owner.transform.position, owner.transform.rotation);
            
            yield return owner.StartCoroutine(owner.Ai());
            
            owner.Think = owner.Think + 1;
            
            owner.StopCoroutine(Execute(owner));
        }
        
        
        Debug.Log(Random.Range(0,8));
       // owner.Think = owner.Think + 1;
       // Object.Instantiate(arrow , owner.transform.position, owner.transform.rotation);
       // yield return owner.StartCoroutine(owner.Ai());
       //  owner.Think = owner.Think + 1;
        
        
       
        //owner.StopCoroutine(Execute(owner));

    }
}