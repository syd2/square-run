using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour
{
    public AudioSource bullet_sound;

    private void Start()
    {
        ParticleSystem exp = GetComponent<ParticleSystem>();
        exp.Stop();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.name == "player")
        {
            
            SaveManager.Instance.state.bullet_num +=1;//this will add one to the bullet
            SaveManager.Instance.Save();
            bullet_sound.Play();
            collect_coins();
            
            
            
        }
    }
    private void collect_coins()
    {
        ParticleSystem exp = GetComponent<ParticleSystem>();
        exp.Play();
        Destroy(gameObject, exp.main.duration + 0.2f);

    }
   
}
