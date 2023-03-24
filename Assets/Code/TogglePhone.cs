using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class TogglePhone : MonoBehaviour
{
    public int TF;
    public int PhoneChecker = 0;
    void Start()
    {
        TF = 0;
    }

    // Update is called once per frame
    public void TogglePhonePress()
    {
        
            GetComponent<RectTransform>().DOMove(new Vector3(5.16f, -1.8f, 0), 1f);
        PhoneChecker = PhoneChecker + 1;
        if(PhoneChecker == 4)
        {
            SceneManager.LoadScene(1);
        }
    
    }
    public void TogglePhoneDown()
    {
 
            GetComponent<RectTransform>().DOMove(new Vector3(5f, -6.6f, 0), 1f);
      
    }
   
}
