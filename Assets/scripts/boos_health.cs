using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boos_health : MonoBehaviour
{
    public int max_health = 30;
    public int current_health;
    public boss_healthbar healthbar;
    public boos_door defeat;
    public GameObject money;
    public GameObject door;
    public boss_movement boss_M;
    public SpriteRenderer sp;

    void Start()
    {
        ParticleSystem exp = GetComponent<ParticleSystem>();
        exp.Stop();
        current_health = max_health;
        healthbar.SetMaxHealth(max_health);
    }

    public void takeDamage(int damage)
    {
        current_health -= damage;
        healthbar.SetHealth(current_health);
        if(current_health <= 0)
        {
            boss_M.enabled = false;
           
            door.SetActive(false);
            defeat.boss_defeat();
            explode();
            money.SetActive(true);
        }
    }
  
    private void explode()
    {
        ParticleSystem exp = GetComponent<ParticleSystem>();
        exp.Play();
        sp.enabled = false;
        Destroy(gameObject, exp.main.duration + 0.2f);
        Invoke("destroy", 0.5f);
    }
    private void destroy()
    {
        ParticleSystem exp = GetComponent<ParticleSystem>();
        exp.Stop();
    }
}
