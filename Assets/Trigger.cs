using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Renderer render = GetComponent<Renderer>();

        collegeRoll = Random.Range(1, 11);
        Debug.Log("Number Spun: " + collegeRoll);

        if (collegeRoll < 3)
        {
            
        }
        else
        {
            continue;
        }
    }
}