using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public float paddle_speed;
    public float screen_edge_right;
    public float screen_edge_left;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() //runs every frame.
    {
        float horizontal = Input.GetAxis("Horizontal"); //takes in user input

        transform.Translate(Vector2.right * horizontal * paddle_speed * Time.deltaTime ); //adjusts paddle location in x coordinate.
                                                                                          // I have used Time.deltaTime to ensure that the game runs at the same speed regardless of FPS.
    
         //below code stops paddle going off screen.
        if (transform.position.x < screen_edge_left)
        {
            transform.position = new Vector2(screen_edge_left, transform.position.y);
        }
        if (transform.position.x > screen_edge_right)
        {
            transform.position = new Vector2(screen_edge_right, transform.position.y);
        }
    }
}
