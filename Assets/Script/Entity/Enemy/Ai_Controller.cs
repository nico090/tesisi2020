using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemys")]
public class Ai_Controller : ScriptableObject
{

    public int Think { get; set; }
    private Enemy owner;

    private float delay = 2;
    
[SerializeField] public AbstractAction[] action;

   public IEnumerator ThinkRoutine(Enemy _owner)
   {
        owner = _owner;
        
        
     
       Debug.Log("prueba" + Random.Range(0,8));
        yield return owner.StartCoroutine(action[Think].Execute(owner));
   }
   
   
    
    // Start is called before the first frame update
    

}
