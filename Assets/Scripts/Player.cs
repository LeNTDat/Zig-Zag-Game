using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.ParticleSystem;

public class Player : MonoBehaviour
{

    public GameObject particle;
    Rigidbody rb;
    public int speed;
    bool direction = false;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveBall();

        if(GameManager.instance.started && !GameManager.instance.gameOver)
        {
            UIMananger.Instance.ToStart();
            switchDirection();

        }

        Debug.DrawRay(transform.position, Vector3.down, Color.red);

        if(!Physics.Raycast(transform.position, Vector3.down, 1f))
        {
            GameManager.instance.gameOver = true;
            rb.velocity = new Vector3(0,-30f,0);
            fallDownBallChecking();
        }


        // My way to get move ball

        //if (Input.GetMouseButtonDown(0))
        //{
        //    canMove = true;
        //    direction = !direction;
        //}
        //fallDownBallChecking();
    }

    void moveBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector3(speed, 0, 0);
            GameManager.instance.started = true;
            direction = !direction;
        }

    }

    void switchDirection ()
    {
        if (direction)
        {
            rb.velocity = new Vector3(0, 0, speed);
        }
        else
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Diamond")
        {
            GameObject part =  Instantiate(particle, other.gameObject.transform.position, Quaternion.identity) as GameObject;
            Destroy(other.gameObject);
            Destroy(part ,1f);
        }
    }

    // My way to get move ball
    //void move()
    //{
    //    if(!direction)
    //    { 
    //        transform.Translate(Vector3.right * Time.deltaTime * speed);
    //    }else
    //    {
    //        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    //    }
    //}
    void fallDownBallChecking()
    {
        if (transform.position.y < -30f)
        {
            Destroy(gameObject);
        }
    }
}
