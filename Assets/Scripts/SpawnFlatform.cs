using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlatform : MonoBehaviour
{
    public GameObject platForm;
    bool isOver = false;
    float zpos, xpos;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        spawnFlatForm();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnFlatForm ( )
    {
            
            for (int i = 1; i < 50 ; i++)
            {
                xpos =(transform.localScale.x + i * platForm.transform.localScale.x) / 2;
                zpos = (transform.localScale.z - platForm.transform.localScale.z) / 2;
                pos = new Vector3(xpos, platForm.transform.position.y, zpos);

                Instantiate(platForm, pos, Quaternion.identity);
               
            }
    }
}
