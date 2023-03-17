using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class SpawnFlatform : MonoBehaviour
{
    public GameObject platForm;
    Vector3 lastPos;
    float size;

    void Start()
    {

        size = platForm.transform.localScale.x;
        lastPos = transform.position;
        lastPos.x -= platForm.transform.localScale.x / 2;
        lastPos.z -= platForm.transform.localScale.x / 2;
        for(int i = 0; i < 20; i++)
        {
            FirstSpawn();
        }
        InvokeRepeating("spawnRandomPlatform", 2f, 0.2f);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.gameOver)
        {
            CancelInvoke("spawnRandomPlatform");
        }
    }

    void spawnX()
    {
        Vector3 pos = lastPos;
        pos.x += size;
        lastPos = pos;
        Instantiate(platForm, lastPos,Quaternion.identity);
    }

    void spawnZ()
    {
        Vector3 pos = lastPos;
        pos.z += size;
        lastPos = pos;
        Instantiate(platForm, lastPos, Quaternion.identity);
    }

    void FirstSpawn()
    {
        int random = Random.Range(0, 6);

        if (random < 3)
        {
            spawnX();
        }
        else if (random >= 3)
        {
            spawnZ();
        }
    }
    void spawnRandomPlatform()
    {
       if(GameManager.instance.started)
        {
            int random = Random.Range(0, 6);

            if (random < 3)
            {
                spawnX();
            }
            else if (random >= 3)
            {
                spawnZ();
            }
        }
    }
}
