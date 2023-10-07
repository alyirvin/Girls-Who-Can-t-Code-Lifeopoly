using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggledInstructions : MonoBehaviour
{
    public GameObject RefInstructions;
    public GameObject SmallInstructions;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstructionsMenu()
    {
        SmallInstructions.SetActive(!SmallInstructions.activeInHierarchy);
    }
}
