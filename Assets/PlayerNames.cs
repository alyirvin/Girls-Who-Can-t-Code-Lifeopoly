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
    public Button P3;
    public Button P2;
    public Button P1; 
    public GameObject HUD;

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
        input = NameInputField.text;
        Debug.Log(input);
        //HUD.AddComponent(HUD.createPlayer(input));
        if (turn < 4)
        {
            setPlayerToggle(input);
        }
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
        if (turn == 0)
        {
            P1.GetComponentInChildren<TMP_Text>().text = name;
        }
        else if (turn == 1)
        {
            P2.GetComponentInChildren<TMP_Text>().text = name;
        }
        else if (turn == 2)
        {
            P3.GetComponentInChildren<TMP_Text>().text = name;
        }
        else if (turn == 3)
        {
            P4.GetComponentInChildren<TMP_Text>().text = name;
        }
    }

    public void togglePlayerCard(GameObject card)
    {
        card.SetActive(!card.activeInHierarchy);
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
                player4.generateCard(player4);
                Debug.Log(name);
            }
            turn++;
        }
    }
}
