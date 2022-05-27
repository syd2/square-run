using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class number_bullet : MonoBehaviour
{
    //creating of bulet counter
    public Text bulletText;
    void Update()
    {
        try
        {
            bulletText.text = "BULLET : " + SaveManager.Instance.state.bullet_num;
        }
        catch (NullReferenceException ex)
        {
            Debug.Log("not set in the inspector");
        }
    }    
}
