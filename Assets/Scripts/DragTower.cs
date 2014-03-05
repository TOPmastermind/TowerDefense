using UnityEngine;
using System.Collections;

public class DragTower : MonoBehaviour {
    
    // public SpringJoint2D spring;
    public bool canDrag = false;
    public Vector3 screenPoint;
    

    void Awake()
    {

    }
    
    
    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }
    
    
    void OnMouseDrag()     
    {
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x,
                                                 Input.mousePosition.y,
                                                 screenPoint.z);
        Vector3 currentPos = Camera.main.ScreenToWorldPoint(currentScreenPoint);
        transform.position = currentPos;
    }
    
    
    void OnMouseUp()     
    {

    }
    
}