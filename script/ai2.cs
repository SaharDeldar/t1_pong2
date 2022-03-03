using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai2 : MonoBehaviour
{
    float speed = 20;
    public GameObject ball1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ball1_y = ball1.transform.position.y;
        float ball1_x = ball1.transform.position.x;
        float rocket_y = transform.position.y;
        float rocket_h = GetComponent<BoxCollider2D>().transform.localScale.y;
        float direction;

        if (ball1_x > 0)
        {


            if (ball1_y + rocket_h < rocket_y)
            {
                direction = -1;
            }
            else if (ball1_y - rocket_h > rocket_y)
            {
                direction = +1;
            }
            else
            {
                direction = 0;
            }
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, direction) * speed;
        }
    }
}
