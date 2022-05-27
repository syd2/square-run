using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_talk : MonoBehaviour
{
    public GameObject talk;
    public GameObject talk2;//this will take the second sentence gameobject
    public player_movement p;
    public boss_movement  b;
    private void Start()
    {
        
        sentence1();
    }
    private void sentence1()//this func will display the sentence 1 in talk image
    {
        p.enabled = false;
        b.enabled = false;
        talk.SetActive(true);
        Invoke("sentence1_finish", 3f);
    }
    private void sentence1_finish()//this func will finish the sentence 1
    {
        p.enabled = true;
        b.enabled = true;
        talk.SetActive(false);
        sentence2();
    }
    private void sentence2()//this func will display the sentence 2 in talk2 image
    {

        p.enabled = false;
        b.enabled = false;
        talk2.SetActive(true);
        Invoke("sentence2_finish", 3f);//this will allow us to display sentence2 during 3s
    }
    private void sentence2_finish()//this func will finish the sentence 2
    {
        p.enabled = true;
        b.enabled = true;
        talk2.SetActive(false);
    }
    

    
}    
