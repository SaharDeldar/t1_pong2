using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    float speed = 40;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollsionEnter2D(Collision2D mihman)
    {
        if(mihman.gameObject.name == "ritht")
        {

        }
        else if (mihman.gameObject.name == "leht")
        {
            
        }
        //    if (other.gameObject.tag == "leht_wall")
        //    {
        // score.right_score++;
        //  }
        //   if (other.gameObject.tag == "ritht_wall")
        //   {
        //  score.left_scoret++;
        //   }
    }
}
