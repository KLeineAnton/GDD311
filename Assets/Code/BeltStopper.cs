using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltStopper : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GroceryItem")
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(0f, rb.velocity.y);
        }

    } 
}
