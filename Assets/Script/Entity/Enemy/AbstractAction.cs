using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractAction : ScriptableObject
{
    private string name;

    private float delay;

    private bool canBeInterrupted;
    // Start is called before the first frame update
    
    IEnumerator Execute(Transform self, Player PlayerTarget, Vector3 targetLocation)
    {
       
        yield return null;

    }
}
