using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{


    public float speed =5;
    public GameManager gm; // links to game manager

    // set as public so can be accessed throughout the program (e.g. change speed depending on difficulty)

    
    void Start()
    {
        reset(); // puts ball back at origin
    }

    // Update is called once per frame
    void Update()
    {
        
  
        

        if (gm.isgameover)
        {

            speed = 0;  // stops the update function (game loop)
            reset();//brings ball back to origin.
        }
    }

    public void reset()
    {
        if (gm.lives > 0)
        {
            transform.position = Vector3.zero;// puts ball back to origin.
            GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle* speed; // picks direction ball travels in.
        }
        else speed = 0;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bottom"))
        {
            gm.Update_lives(-1);
            reset();
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Brick")) // if a brick is hit...
        {
            
            Destroy(collision.gameObject);
            gm.Update_score(); //increase score function
            gm.Update_Bricks(); // keeps track of how many bricks there are left
        }
    }
     
}
