using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    Vector3 mouseLocation;

    //grabs mouse location
    private Vector3 CurrentMouseLocation()
    {
        //fetching coordinates of mouse
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    //account for any offset
    private void OnMouseDown()
    {
        mouseLocation = gameObject.transform.position - CurrentMouseLocation();
    }
    //move the piece
    private void OnMouseDrag()
    {
        transform.position = CurrentMouseLocation() + mouseLocation;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Scanner")
        {
           // Destroy(gameObject);
        }
        
    }

}
