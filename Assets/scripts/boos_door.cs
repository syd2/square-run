using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boos_door : MonoBehaviour
{
    public SpriteRenderer visible;
    public SpriteRenderer visible1;
    public BoxCollider2D door;
    public BoxCollider2D door1;
    public SpriteRenderer box_visible;
    public GameObject healthbar;
    public Transform player;
    public boss_movement boss;
    public float room_pos = 151f;
    public float room_out = 181f;
    public  GameObject congrat;
    private player_movement moving;


    private void Start()
    {
        moving = GetComponent<player_movement>();
    }

    private void Update()
    {
        if (player.position.x >= room_pos && player.position.x <= room_out && box_visible != null)
        {
            visible.enabled = true;
            door.enabled = true;
            visible1.enabled = true;
            box_visible.enabled = true;
            door1.enabled = true;
            boss.enabled = true;
            healthbar.SetActive(true);

        
        }
        
    }
    public void boss_defeat()
    {
        visible.enabled = false;
        door.enabled = false;
        box_visible = null;
        visible1.enabled = false;
        door1.enabled = false;
    
        
        Invoke("Congrat", 0.6f);
        
        
    }
    
    private void Congrat()
    {
        congrat.SetActive(true);
        moving.enabled = false;
        Invoke("congrat_finish", 2f);

    }
    private void congrat_finish()
    {
        congrat.SetActive(false);
        moving.enabled = true;
    }
 
}
