using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//whenever that we are working with UI

public class soldat_healthbar : MonoBehaviour
{
    public Slider slider;//this ll refer our slider
    public void SetMaxHealth(int health)//setting of the max value of the slider.
    {
        slider.maxValue = health;
        slider.value = health;// we set it to health to make sure that the health it at the max value.
    }
    public void SetHealth(int health)
    {
        slider.value = health;//this will set the value of the slider to the health
    }
    //now our health bar is ready to be inplement to any kind of script(player, boss, soldat..)
}
