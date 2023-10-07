using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

namespace Test
{
    public class TakeSteps : MonoBehaviour
    {
        public static void doThing(int steps)
        {

            Debug.LogError("Steps recieved are:" + steps);
        }
    }
}
