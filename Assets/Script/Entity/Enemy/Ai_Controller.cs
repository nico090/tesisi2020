using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemys")]
public class Ai_Controller : ScriptableObject
{

    public int think;
    public Enemy owner;
[SerializeField] public AbstractAction[] action;

   public IEnumerator ThinkRoutine()
    {
   
        think=Random.Range(1, 2);

        yield return owner.StartCoroutine(action[think].Execute());
        
        Debug.Log(think);
    }
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

}
