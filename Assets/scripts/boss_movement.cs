using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_movement : MonoBehaviour
{
    public Transform player;
    public Transform boss;
    public float room_door = 153;
    public float room_out = 181f;
    public float beginning;
    public float beginning1;
    public float beginning2;
    public float end;
    public float speed1 = 6;
    public float speed2 = 8;


    void FixedUpdate()
    {
        
        
        if ( boss.position.x < beginning && boss.position.x > end) 
        {
            transform.Translate(Vector3.right*Time.deltaTime* speed1);
            

        }
        if (boss.position.x > beginning)
        {
            beginning = beginning1;
            transform.Translate(Vector3.left*Time.deltaTime* speed2);
            
        }
        if (boss.position.x < beginning)
        {
            
            beginning = beginning2;
            transform.Translate(Vector3.right*Time.deltaTime* speed1);
            
        }
      
        
        
    }

}
