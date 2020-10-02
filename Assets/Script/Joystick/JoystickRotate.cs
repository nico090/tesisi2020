using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class JoystickRotate : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    [SerializeField]private float radio;
    private Vector3 posinicial;

    private Vector3 axis;
    // Start is called before the first frame update
    void Start()
    {
        posinicial = transform.position;
    }

    public Vector3 Axis()
    {
        return axis;

    }
    public float AxisHorizontal()
    {
       
        return axis.x;
       
    }
    
    public float AxisVertical()
    {
        
        return axis.y;
        
    }
    public void Drag()
    {
        Vector2 pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, Input.mousePosition,
            canvas.worldCamera, out pos);

        Vector3 newPos=  canvas.transform.TransformPoint(pos) - posinicial;
        newPos.x = Mathf.Clamp(newPos.x,-radio,radio);
       // newPos.y = Mathf.Clamp(newPos.y,-radio,radio);
        newPos.y = Mathf.Clamp(newPos.y,-radio,radio);
        
        
        
        transform.localPosition= newPos;
        axis = newPos / radio;

    }


    public void Drop()
    {
        axis = new Vector3(0, 0, 0);
        transform.position = posinicial;

    }
}

