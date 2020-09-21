using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "WiteAction", menuName = "AbstractAction")]
public class WaitAction : AbstractAction
{
    // Start is called before the first frame update
    public override IEnumerator Execute(Enemy owner)
    {
        Debug.Log("Estoy Esperando");
        yield return new WaitForSeconds(3);
        //  return base.Execute(self, PlayerTarget, targetLocation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
