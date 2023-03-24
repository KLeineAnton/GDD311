using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scan : MonoBehaviour
{
    public int foodCount = 0;
    public int total;

    private void Start()
    {
       
      
        //(on trigger)
        // make sound go off and grocery counter go up
        
    }
    //triggers sound and food counter
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GroceryItem")
        {
            foodCount = foodCount + 1; 

        }
        if(foodCount == total)
        {
            SceneManager.LoadScene(2);
        }
    }

}
