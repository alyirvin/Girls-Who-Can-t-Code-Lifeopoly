using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 
using PlayerSpace;
using UnityEngine.UI;
using TMPro;

public class PlayerNames : MonoBehaviour
{
    private string input;
    public GameObject NameInput;
    public TMP_Text PlayerNumber;
    public static int turn;
    public TMP_Text NameFieldText;
    public TMP_InputField NameInputField;
    public Button P4;
    public TextMeshProUGUI P4Name;
    public Button P3;
    public TextMeshProUGUI P3Name;
    public Button P2;
    public TextMeshProUGUI P2Name;
    public Button P1;
    public TextMeshProUGUI P1Name; 

    //public void createPlayer(string name);
    //public Player(string name);

    // Start is called before the first frame update
    void Start()
    {
        turn = 0;
        PlayerNumber.text = (turn+1).ToString();
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
        setPlayerToggle(input);
        turn++;
        NameInputField.text = "";
        if (turn < 4)
        {
            nextPlayer();
        }
    }

    public void nextPlayer()
    {
        PlayerNumber.text = (turn+1).ToString();
        NameInput.SetActive(!NameInput.activeInHierarchy);
    }

    public void ToggleNameInput()
    {
        NameInput.SetActive(!NameInput.activeInHierarchy);
    }

    public void setPlayerToggle(string name)
    {
        if (turn % 4 == 0)
        {
            P1.GetComponentInChildren<TMP_Text>().text = name;
            //P1Name.text = name;
        }
        else if (turn % 4 == 1)
        {
            P2Name.text = name;
        }
        else if (turn % 4 == 2)
        {
            P3Name.text = name;
        }
        else if (turn % 4 == 3)
        {
            P4Name.text = name;
        }
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
