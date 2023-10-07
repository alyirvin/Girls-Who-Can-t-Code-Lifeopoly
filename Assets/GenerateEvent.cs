using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GenerateEvent : MonoBehaviour
{
    public TMP_Text EventText;

    //Create event array
    public string[] eventTextList =
        {
            "Description 1",
            "Description 2",
            "Description 3",
            "Description 4",
            "Description 5",
        };

    // Start is called before the first frame update
    void Start()
    {
        string evliststring = eventTextList[Random.Range(0, eventTextList.Length)];
        EventText.text = evliststring;

}

    // Update is called once per frame
   
}
