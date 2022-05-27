using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public Text scoreText;
    public GameObject shoppanel;
    public GameObject menupanel;
    public GameObject floorCompleteUI;
    private int score = 0;
    public GameObject restartPanel;//this func will display our restart panel
    private AudioSource button_sound;
    public GameObject  aboutPanel;
    //public Button shopButton;
    private void Awake() 
    {
        scoreText.text = "SCORE : " + score.ToString();
        button_sound = GetComponent<AudioSource>();
    }
    public void Restart()//this func will restart the game whenever we click on the button that it ll be call
    {
        button_sound.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void menuScene()
    {
        //button_sound.Play();
        SceneManager.LoadScene("MainMenu");
    }
    public void GameOver()
    {
        
        Invoke("GameEnd", 0.55f);
    }
    private void GameEnd()
    {
        restartPanel.SetActive(true);//display our restart panel when we lose
    }
    public void floorComplete()
    {
        floorCompleteUI.SetActive(true);
    }
    public void Play()
    {
        button_sound.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit()
    {
        button_sound.Play();
        Application.Quit();
    }
    public void score_num()
    {
        score += 10;
        scoreText.text = "SCORE : " + score.ToString();
    }
    public void shop()
    {
        button_sound.Play();
        shoppanel.SetActive(true);
        menupanel.SetActive(false); 
        

    }
    public void backToMenu()
    {
        button_sound.Play();
        shoppanel.SetActive(false);
        aboutPanel.SetActive(false);
        menupanel.SetActive(true);
    }
    public void about()
    {
        button_sound.Play();
        menupanel.SetActive(false);
        aboutPanel.SetActive(true);
    }
    
}
