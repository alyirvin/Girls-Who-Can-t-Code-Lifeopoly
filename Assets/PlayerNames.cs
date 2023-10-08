using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 
using PlayerSpace;

public class PlayerNames : MonoBehaviour
{
    private string input;
    //public void createPlayer(string name);
    //public Player(string name);

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
        Debug.Log(input);
        (new PlayerMakers()).createPlayer(input);
    }

}

namespace PlayerSpace
{
    public class PlayerMakers
    {
        public static int turn;

        public void createPlayer(string name)
        {
            if (turn % 4 == 0)
            {
                Player player1 = new Player(name);
                Debug.Log(name);
            }
            else if (turn % 4 == 1)
            {
                Player player2 = new Player(name);
                Debug.Log(name);
            }
            else if (turn % 4 == 2)
            {
                Player player3 = new Player(name);
                Debug.Log(name);
            }
            else if (turn % 4 == 3)
            {
                Player player4 = new Player(name);
                Debug.Log(name);
            }
            turn++;
        }
    }
}
