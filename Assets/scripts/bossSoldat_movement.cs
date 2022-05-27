using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bossSoldat_movement : MonoBehaviour
{
    //moving of the soldat
    public Transform soldat;
    public float beginning;
    public float beginning1;
    public float beginning2;
    public float end;
    //health of the soldat
    //referring of the soldat_HealthBar
    public soldat_healthbar healthbar;//the max health of the soldat
    public int current_health;//the health of soldat
    public int max_health = 12;//this is the max health of the soldat
    public BoxCollider2D box;
    public SpriteRenderer sp;
    private void Start()
    {
        sp = GetComponent<SpriteRenderer>();// we are reffering the sprite renderer in the inspector
        box = GetComponent<BoxCollider2D>();
        current_health = max_health;//at the beginning the soldat have to start with the max health
        healthbar.SetMaxHealth(max_health);//we set the maxhealth of the health bar to max_health
    }
    public player_movement stop_move;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.name == "player")
        {
            FindObjectOfType<GameMaster>().GameOver();
            stop_move.enabled = false;
        }

    }
    void Update()
    {
        if ( soldat.position.x < beginning && soldat.position.x > end) 
        {
            transform.Translate(Vector3.right*Time.deltaTime* 4f);
        }
        if (soldat.position.x > beginning)
        {
            beginning = beginning1;
            transform.Translate(Vector3.left*Time.deltaTime* 4f);
            
        }
        if (soldat.position.x < beginning)
        {
            beginning = beginning2;
            transform.Translate(Vector3.right*Time.deltaTime* 4f);
           
        }
    }
    public void Die( int damage)
    {
        current_health -= damage;//we damage the current health
        healthbar.SetHealth(current_health);
        if (current_health <= 0)
        {
            explode();
            
        }
    }
    void explode()
    {
        ParticleSystem Exp = GetComponent<ParticleSystem>();
        Exp.Play();
        box.enabled = false;//this will make it impossible to interact
        sp.enabled = false;//this will make it disapear when the particle play before it destroys
        Destroy(gameObject, Exp.main.duration + 0.2f);
        Debug.Log("exploded");
    }
  
}
