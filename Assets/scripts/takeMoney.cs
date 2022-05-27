using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeMoney : MonoBehaviour
{
    public  int the_amount;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "player")
        {
            SaveManager.Instance.state.money += the_amount;
            SaveManager.Instance.Save();
            Destroy(gameObject);
            Debug.Log("70$ earned");
        }
    }
}
