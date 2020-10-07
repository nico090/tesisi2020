using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
//[CreateAssetMenu(fileName = "MovePositionAction", menuName = "MovePositionAction")]
// public class MovePositionAction : AbstractAction
//{
  /*
    // Start is called before the first frame update
    private Transform[] positions;
    private int takePosition;
    public override IEnumerator Execute(Enemy owner)
    {
        positions = FindObjectOfType<PuntosPatrullaje>().positions;
        takePosition = Random.Range(0,positions.Length);
        
     do
     {
        
         
         
         
        owner.transform.position = Vector3.Lerp(owner.transform.position, positions[takePosition].transform.position,
          owner.velocity * Time.deltaTime);
        yield return new WaitForFixedUpdate();

      } while (Vector3.Distance(owner.transform.position, positions[takePosition].transform.position) >= .5f);

     if (Vector3.Distance(owner.transform.position, positions[takePosition].transform.position) >= .5f)
     {
                
         yield return owner.StartCoroutine(owner.Ai());
         owner.Think = Random.Range(0,3);

        owner.StopCoroutine(Execute(owner));
     }
     
    
    }
    */
//}
