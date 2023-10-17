using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public static int turn;
    public Player Player1;
    public Player Player2;
    public Player Player3;
    public Player Player4;
    public TMP_Text TurnHeader;
    // Start is called before the first frame update
    void Start()
    {
        turn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player1.playerName != "" && Player2.playerName != "" && Player3.playerName != "" && Player4.playerName != "")
        {
            Debug.Log("all players created.");
            //turnCounter();
        }
    }

    public void turnCounter()
    {
        if (turn % 4 == 0)
        {
            TurnHeader.text = Player1.playerName.ToUpper() + "'S TURN" ;
        }
        else if (turn % 4 == 1)
        {
            TurnHeader.text = Player2.playerName.ToUpper() + "'S TURN" ;
        }
        else if (turn % 4 == 2)
        {
            TurnHeader.text = Player3.playerName.ToUpper() + "'S TURN" ;
        }
        else if (turn % 4 == 3)
        {
            TurnHeader.text = Player4.playerName.ToUpper() + "'S TURN" ;
        }
    }
}
