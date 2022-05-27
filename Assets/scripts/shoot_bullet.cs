using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_bullet : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bullet_prefab;
    // OnGUI is like the Update function.
    public Texture2D bao;
    private AudioSource shoot_sounds;
    private void Start()
    {
        shoot_sounds = GetComponent<AudioSource>();
    }
    private void OnGUI()
    {
        if(GUI.Button(new Rect(20,Screen.height - 220, 200, 180), bao))
        {
            shoot_sounds.Play();//play sound
            shoot();
        }
    }
    private void shoot()
    {
        if(SaveManager.Instance.state.bullet_num > 0)
        {
            Instantiate(bullet_prefab, firepoint.position, firepoint.rotation);
            SaveManager.Instance.state.bullet_num -=1;
        }
        
    }
}
