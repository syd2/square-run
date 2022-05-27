using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    // this will shoot the bullet
    public float shoot_speed = 25f;
    public int damage = 2;
    public Rigidbody2D rb;
    private AudioSource bullet_sound;
    void Start()
    {
        bullet_sound = GetComponent<AudioSource>();
        rb.velocity = transform.right * shoot_speed;

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name != "player" && col.tag != "bullet")
        {
            

            //damaging of boss_soldat when we shoot them
            bossSoldat_movement soldat_health = col.GetComponent<bossSoldat_movement>();
            if (soldat_health != null)
            {
                FindObjectOfType<GameMaster>().score_num();
                soldat_health.Die(damage);
            }
            Destroy(gameObject);

            boos_health boss_health = col.GetComponent<boos_health>();

            if (boss_health != null)
            {
                FindObjectOfType<GameMaster>().score_num();
                boss_health.takeDamage(damage);
            }
            bullet_sound.Play();
            Destroy(gameObject);


        }
       
         
    }
}
