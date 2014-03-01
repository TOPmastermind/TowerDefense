using UnityEngine;
using System.Collections;

public class DragTower : MonoBehaviour {
    
    // public SpringJoint2D spring;
    public bool canDrag = false;
    public Vector3 screenPoint;
    

    void Awake()
    {
        // spring = this.gameObject.GetComponent<SpringJoint2D>(); //"spring" is the SpringJoint2D component that I added to my object
        // spring.connectedAnchor = gameObject.transform.position;//i want the anchor position to start at the object's position
    }
    
    
    void OnMouseDown()
    {
        // spring.enabled = true;//I'm reactivating the SpringJoint2D component each time I'm clicking on my object becouse I'm disabling it after I'm releasing the mouse click so it will fly in the direction i was moving my mouse
        // canDrag = true;
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }
    
    
    void OnMouseDrag()     
    {
        /* 
        if (spring.enabled == true) 
        {
            spring.connectedAnchor = cursorPosition;    //the anchor get's cursor's position
        }
        **/
        /*
        if (canDrag)
        {
            Vector2 cursorPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);  //getting cursor position
            transform.position = new Vector3(cursorPosition.x, cursorPosition.y, transform.position.z);
        }
        **/
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x,
                                                 Input.mousePosition.y,
                                                 screenPoint.z);
        Vector3 currentPos = Camera.main.ScreenToWorldPoint(currentScreenPoint);
        transform.position = currentPos;
    }
    
    
    void OnMouseUp()     
    {
        
        // spring.enabled = false; //disabling the spring component
        // canDrag = false;
    }
    
}