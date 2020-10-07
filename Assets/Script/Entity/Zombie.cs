using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.XR.WSA;


public class Zombie : Entity
{     Player player;
    [SerializeField]private Transform[] positions;

    private float angle;
    private Rigidbody2D rigidbodyEnem;
    private RaycastHit2D hit;
    // Start is called before the first frame update
    void Start()
    {
        Hp = 80f;
        
        player = FindObjectOfType<Player>();
        rigidbodyEnem = GetComponent<Rigidbody2D>();
        StartCoroutine(Patrulla());
    }

    // Update is called once per frame
    void Update()
    {
        if (Hp <= 0)
        {
            Destroy(gameObject);
        }
    }

   private  IEnumerator Patrulla()
   {
      int takePosition = Random.Range(0, positions.Length);
        do
        {
            transform.position = Vector3.Lerp(transform.position, positions[takePosition].transform.position,
                velocity * Time.deltaTime);
            yield return new WaitForFixedUpdate();

        } while (Vector3.Distance(transform.position, positions[takePosition].transform.position) >=0.2f);

        StartCoroutine(Localizar());
        StopCoroutine(Patrulla());
    }

   private IEnumerator Localizar()
   {
       float count = 0;
       do
       {
           count++;
           var position = transform.position;
           Vector3 direccion = player.transform.position - position;

           direccion.Normalize();
            
           //Debug.Log(direccion);

           angle = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg - 90f;
            
           rigidbodyEnem.rotation = angle;
             
           hit = Physics2D.Raycast(position, direccion,100f, 1<<9 | 1<<10 );
           Debug.DrawRay(position, direccion, Color.red);
          yield return new WaitForFixedUpdate();
       } while (hit.collider.tag!=("Player")||count<=2);
       
       if (hit.collider.tag == "Player")
       {
           StartCoroutine(Attack());
           StopCoroutine(Localizar());
       }
       else
       {
           StartCoroutine(Patrulla());
           StopCoroutine(Localizar());
           yield return new WaitForEndOfFrame();
       }
       
       
   }

   private IEnumerator Attack()
   {
       do
       {
           transform.position = Vector3.Lerp(transform.position, player.transform.position,
                      velocity * Time.deltaTime);
                  
                  yield return new WaitForFixedUpdate();
           
       }while(Vector3.Distance(transform.position,player.transform.position)>=.3f);

       StartCoroutine(Damage());
       StopCoroutine(Attack());
       yield return new WaitForEndOfFrame();
   }


   private IEnumerator Damage()
   {
       do
       {
           player.Hp -= .2f;

         print(player.Hp);
         yield return new WaitForFixedUpdate();
       } while (Vector3.Distance(transform.position, player.transform.position) <= .3f);

       StartCoroutine(Localizar());
       StopCoroutine(Damage());
       yield return new WaitForEndOfFrame();
   }
}


