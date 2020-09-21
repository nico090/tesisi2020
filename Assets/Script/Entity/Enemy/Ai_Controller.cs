using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemys")]
public class Ai_Controller : ScriptableObject
{

    public int think;
    private Enemy owner;

    private float delay = 2;
    
[SerializeField] public AbstractAction[] action;

   public IEnumerator ThinkRoutine(Enemy _owner)
   {
        owner = _owner;
        
        think = Random.Range(0,2);
       Debug.Log("prueba");
        yield return owner.StartCoroutine(action[think].Execute(owner));
   }
   
   
    
    // Start is called before the first frame update
    

}
