using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_collision : MonoBehaviour
{
    public player_movement stop_move;
    public SpriteRenderer player_destroy;
    public AudioSource death_sound;
    public GameObject c;
    public GameObject fight_camera;
    void Start()
    {
        ParticleSystem exp = GetComponent<ParticleSystem>();
        exp.Stop();
        
    
    
    }
    void OnCollisionEnter2D(Collision2D collision_info)
    {
        if (collision_info.collider.tag != "ground" && collision_info.collider.name != "leveldoor")
        {
            c.SetActive(false);
            Explode();
            FindObjectOfType<GameMaster>().GameOver();
            death_sound.Play();
            stop_move.enabled = false;
            

            
        }
        
    }
    void Explode()
    {
        ParticleSystem exp = GetComponent<ParticleSystem>();
        exp.Play();
        player_destroy.enabled = false;
        Invoke("destroy", 0.5f);
        Invoke("camera", 0.6f);
        
    }
    private void destroy()
    {
        ParticleSystem exp = GetComponent<ParticleSystem>();
        exp.Stop();
        Destroy(gameObject, exp.main.duration + 0.2f);
    }
    private void camera()
    {
        fight_camera.SetActive(true);
    }
}
