using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollider : MonoBehaviour
{
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.gameOver)
        {
            Invoke("fallDownCheck", 0.2f);
        }

    }

    private void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "Ball") { 
            
            Destroy(gameObject);
        }
       
    }


    void fallDownCheck () {
        Destroy(gameObject);
    }

}
