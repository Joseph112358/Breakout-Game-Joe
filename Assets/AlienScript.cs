using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienScript : MonoBehaviour
{
    public GameManager gm;
    public bool isAlienon;
    public float speed = 5f;
    private bool direction;
    private SpriteRenderer SpriteRenderer;
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlienon == true)
        {
            if (direction) 
            {
                MoveRight();
            }
            if (!direction)
            {
                MoveLeft();
            }

            //reach right barrier, flip Alien and send left, direction = false ==> move left
            if (transform.position.x >= 5)
            {
                direction = false;//switches direction
                SpriteRenderer.flipX = true; //flips sprite
            }
            //reach left barrier, flip Alien and send right, direction = true ==> move right
            if (transform.position.x < -5)
            {
                direction = true; 
                SpriteRenderer.flipX = false;
            }
        }
        
        
       
    }
   
    public void MoveRight() // moves the alien right
    {
       transform.Translate(speed*Time.deltaTime,0,0);
    }
    public void MoveLeft() // moves the alien left
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    
}
    public void ToggleAlien()
    {
        if (isAlienon)
        {
            gameObject.transform.Translate(-20, 0, 0); //moves alien off screen
            isAlienon = false; //stops alien from moving
        }
        else
        {
            
            isAlienon = true; // tells alien to come back onto screen.
        }
    }
}

