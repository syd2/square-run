using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclecircle_movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform obstacle;
    public float end = 110f;
    public float beginning = 120f; 
    public float beginning1;
    public float beginning2; 
    public player_movement stop_move;
    

    void FixedUpdate()
    {
        
        if ( obstacle.position.x < beginning && obstacle.position.x > end) 
        {
           transform.Translate(Vector3.right*Time.deltaTime* 3f);
        }
        if (obstacle.position.x > beginning)
        {
            beginning = beginning1;
            transform.Translate(Vector3.left*Time.deltaTime* 4f);
            
        }
        if (obstacle.position.x < beginning)
        {
            beginning = beginning2;
            transform.Translate(Vector3.right*Time.deltaTime* 3f);
           
        }
      
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.name == "player")
        {
            FindObjectOfType<GameMaster>().GameOver();
            stop_move.enabled = false;
        }
    }
   
}
