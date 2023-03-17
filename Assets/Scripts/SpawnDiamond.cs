using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDiamond : MonoBehaviour
{
    public GameObject Diamond;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnerDiamond",0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnerDiamond()
    {
        Vector3 pos =  transform.parent.position;
        pos.y += 1.05f;

        int random = Random.Range(0, 10);
        if(random <= 3 )
        {
        Instantiate(Diamond, pos ,Diamond.transform.rotation, transform.parent);
        }else if(random > 3)
        {
            return;
        }
    }

}
