using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

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
        if(col.gameObject.tag == "Ball")
        {
            Invoke("fallDown", 0.2f);
        }
    }

    void fallDown()
    {
        ScoreManager.instance.increaseScore();
        GetComponentInParent<Rigidbody>().useGravity = true;
        Destroy(transform.parent.gameObject , 1f);
    }
}
