using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buying : MonoBehaviour
{
   
   public GameObject no_money;
   private int cost1 = 70;
   private int cost2 = 250;
   private int cost3 = 300;
  
   public void buy_1()
   {
       if (SaveManager.Instance.state.money >= cost1)
       {
            SaveManager.Instance.state.bullet_num += 25;
            SaveManager.Instance.state.money -= cost1;
            SaveManager.Instance.Save();
       }
       else
       {
           no_money.SetActive(true);
           Invoke("delay", 1.5f);
       }
   }
   public void buy_2()
   {
       if (SaveManager.Instance.state.money >= cost2)
       {
            SaveManager.Instance.state.bullet_num += 25;
            SaveManager.Instance.state.money -= cost2;
            SaveManager.Instance.Save();
       }
       else
       {
           no_money.SetActive(true);
           Invoke("delay", 1.5f);
       }
   }
   public void buy_3()
   {
       if (SaveManager.Instance.state.money >= cost3)
       {
           SaveManager.Instance.state.bullet_num += 25;
           SaveManager.Instance.state.money -= cost3;
           SaveManager.Instance.Save();
       }
       else
       {
           no_money.SetActive(true);
           Invoke("delay", 1.5f);
       }
   }
    private void delay()
    {
        no_money.SetActive(false);
    }
}
