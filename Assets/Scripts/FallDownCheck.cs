using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDownCheck : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "Ball" || GameManager.instance.gameOver)
        {
            Invoke("fallDown", 0.5f);
        }
    }

    void fallDown()
    {
        GetComponentInParent<Rigidbody>().useGravity = true;
        Destroy(transform.parent.gameObject , 1f);
    }
}
