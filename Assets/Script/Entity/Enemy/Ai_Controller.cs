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
        owner = FindObjectOfType<Enemy>();

        think=Random.Range(0, 2);

        Debug.Log(think);
        
        yield return owner.StartCoroutine(action[think].Execute());
        
        

       
    }
   
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

}
