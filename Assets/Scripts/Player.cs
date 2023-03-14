using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public int speed = 5;
    bool direction = false;
    bool canMove = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            move();
        }

        if (Input.GetMouseButtonDown(0))
        {
            canMove = true;
            direction = !direction;
        }
        fallDownBallChecking();
    }

    void fallDownBallChecking ( )
    {
        if(transform.position.y < -20)
        {
            Destroy(gameObject);
        }
    }

    void move()
    {
        if(!direction)
        { 
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
