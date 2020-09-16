using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
[CreateAssetMenu(fileName = "MovePositionAction", menuName = "MovePositionAction")]
public class MovePositionAction : AbstractAction
{
  public float delay = 3f;
    // Start is called before the first frame update
  

    public override IEnumerator Execute()
    {
        Debug.Log("Me Estoy Moviendo");
      yield return new WaitForSeconds(3);
      //  return base.Execute(self, PlayerTarget, targetLocation);
    }
}
