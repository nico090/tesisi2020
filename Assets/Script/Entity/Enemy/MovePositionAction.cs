using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
[CreateAssetMenu(fileName = "MovePositionAction", menuName = "MovePositionAction")]
public class MovePositionAction : AbstractAction
{
  
    // Start is called before the first frame update
    private GameObject[] positions;
    private int takePosition;
    public override IEnumerator Execute(Enemy owner)
    {
        
     do
     {
          takePosition = Random.Range(0, positions.Length);
         
         
        owner.transform.position = Vector3.Lerp(owner.transform.position, positions[takePosition].transform.position,
          owner.velocity * Time.deltaTime);
        yield return new WaitForFixedUpdate();

      } while (Vector3.Distance(owner.transform.position, positions[takePosition].transform.position) >= .5f);

     if (Vector3.Distance(owner.transform.position, positions[takePosition].transform.position) >= .5f)
     {
                
         yield return owner.StartCoroutine(owner.Ai());
         owner.Think = owner.Think + 1;

        owner.StopCoroutine(Execute(owner));
     }
     
    
    }
}
