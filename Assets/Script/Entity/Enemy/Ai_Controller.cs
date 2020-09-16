using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemys")]
public class Ai_Controller : ScriptableObject
{

    public int think;
    
[SerializeField] public AbstractAction[] action;

   public IEnumerator ThinkRoutine()
    {
   
        think=Random.Range(1, 2);

        action[think].Prueba();
        
        Debug.Log(think);
        
        
        yield return new WaitForEndOfFrame();
        
        
    }
   
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

}
