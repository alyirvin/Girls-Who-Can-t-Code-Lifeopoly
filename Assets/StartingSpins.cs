using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyUI.PickerWheelUI;
using TMPro;

public class StartingSpins : MonoBehaviour
{
    public static int turn;
    public static int steps;
    public PickerWheel pickerWheel;
    public Player Player1;
    public Player Player2;
    public Player Player3;
    public Player Player4;
    public TMP_Text ResultAnnounce;
    public GameObject Spinner;
    public TMP_Text TurnHeader;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleSpinner()
    {
        Spinner.SetActive(!Spinner.activeInHierarchy);
    }

    public void nepoSpins()
    {
        ResultAnnounce.text = "Spin For Financial Status";
        if (turn == 4)
        {
            StartCoroutine(delay(30));
            TurnHeader.text = Player1.playerName.ToUpper() + "'S TURN" ;
            Player1.setFinStatus(pickerWheel.steps);
            ResultAnnounce.text = "Your Financial Status is: " + Player1.finStatus;
        }
        else if (turn == 5)
        {
            StartCoroutine(delay(30));
            TurnHeader.text = Player2.playerName.ToUpper() + "'S TURN" ;
            Player2.setFinStatus(pickerWheel.steps);
            ResultAnnounce.text = "Your Financial Status is: " + Player2.finStatus;
        }
        else if (turn == 6)
        {
            StartCoroutine(delay(30));
            TurnHeader.text = Player3.playerName.ToUpper() + "'S TURN" ;
            Player3.setFinStatus(pickerWheel.steps);
            ResultAnnounce.text = "Your Financial Status is: " + Player3.finStatus;
        }
        else if (turn == 7)
        {
            StartCoroutine(delay(30));
            TurnHeader.text = Player4.playerName.ToUpper() + "'S TURN" ;
            Player4.setFinStatus(pickerWheel.steps);
            ResultAnnounce.text = "Your Financial Status is: " + Player4.finStatus;
            toggleSpinner();
        }
        turn++;
    }

    public IEnumerator delay(int seconds)
    {
        yield return new WaitForSeconds(seconds);
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
