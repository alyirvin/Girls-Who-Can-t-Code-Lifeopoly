using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    public GameObject StartingScreen;
    public GameObject BigInstructions;
    public GameObject InstructRef;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        InstructRef.SetActive(!InstructRef.activeInHierarchy);
        StartingScreen.SetActive(!StartingScreen.activeInHierarchy);
    }

    public void MainInstructions()
    {
        BigInstructions.SetActive(!BigInstructions.activeInHierarchy);
    }

    public void ReturnStarting()
    {
        BigInstructions.SetActive(!BigInstructions.activeInHierarchy);
    }
}
