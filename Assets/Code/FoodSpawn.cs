using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
    //spawns food to the scanned, moves it down to converybelt
    public GameObject[] FoodArray;
    private float Timer = 1;

    private void Start()
    {
        Timer = 1;
    }
    private void Update()
    {
        Timer -= 1 * Time.deltaTime;
        int randomIndex = Random.Range(0,3);
        //FoodItem

        if (Timer <= 0)
        {
            Instantiate(FoodArray[randomIndex], new Vector3(9f, -2.5f, 0f), Quaternion.identity);

            Timer = 2;
        }
  
    }
}
