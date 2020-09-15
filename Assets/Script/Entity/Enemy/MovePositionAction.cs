using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
[CreateAssetMenu(fileName = "MovePositionAction", menuName = "MovePositionAction")]
public class MovePositionAction : AbstractAction
{
  public float delay = 3f;
    // Start is called before the first frame update
   
    IEnumerator Execute(Transform self, Player PlayerTarget, Vector3 targetLocation)
    {

        Debug.Log("move");
        
        yield return new WaitForSeconds(delay);

    }
    
}
