using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIMananger : MonoBehaviour
{

    public GameObject TapToStart;

    public static UIMananger Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToStart()
    {
        TapToStart.GetComponent<Animator>().Play("DropStarter");
    }
}
