using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CreateWalls : MonoBehaviour

    
{

    bool creating;
    public GameObject start;
    public GameObject end;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        getInput();
    }

    void getInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            setStart();
        }else if (Input.GetMouseButtonUp(0))
        {
            setEnd();
        }
        else
        {
            if (creating)
            {
                adjust();
            }
        }
    }

    void setStart()
    {
        creating = true;
    }
    void setEnd()
    {
        creating = false;
    }

    void adjust()
    {

    }
}
