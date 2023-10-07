using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EasyUI.PickerWheelUI;   //required
using Test;

public class Demo : MonoBehaviour
{
    // Reference to the PickerWheel GameObject (step 3):
    [SerializeField] private PickerWheel pickerWheel;
    [SerializeField] private Button Button1;
 

    private void Start()
    {
        // Start spinning:
        Button1.onClick.AddListener (() =>
        {
            pickerWheel.Spin ();
            // steps should be a number 1 - 10
            // run the board game
            TakeSteps.doThing(pickerWheel.steps);
        });
    }
}