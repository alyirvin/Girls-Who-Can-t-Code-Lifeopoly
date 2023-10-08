using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNames : MonoBehaviour
{
    private string input;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadInput(string s)
    {
        input = s;
        Debug.log(input);
    }
}
