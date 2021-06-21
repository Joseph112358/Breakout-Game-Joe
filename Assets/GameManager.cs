using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public int lives =5;
    public Text score_text;
    public Text lives_text;
    public bool isgameover;
    public int bricknumber;
    public GameObject GameOverPanel;


    // Start is called before the first frame update
    void Start()
    {
        lives_text.text = "Lives: " + lives;
        score_text.text = "Score: " + score;
        bricknumber = GameObject.FindGameObjectsWithTag("Brick").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Update_lives(int changelives) 
    { 
        lives += changelives; //adds or subtracts lives.
        lives_text.text = "Lives: " + lives;//updates UI
        
        if(lives <= 0)
        {
            EndGame();
        }
    }
    public void Update_score()
    {
        score++; //adds 1 to the score
        score_text.text = "Score: " + score; //updates UI 
    }
    public void Update_Bricks()
    {
        bricknumber--;
        if(bricknumber <= 0)
        {
            EndGame();
        }
    }
    public void EndGame() // ends the game
    {
        isgameover = true; 
        GameOverPanel.SetActive(true); //displays game over UI board
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");//reloads the game
    }
    public void Exit()
    {
        Application.Quit(); 
        
    }
    
}
