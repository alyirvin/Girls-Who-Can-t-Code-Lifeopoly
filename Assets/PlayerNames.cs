using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 
using PlayerSpace;
using UnityEngine.UI;
using TMPro;

namespace PlayerSpace
{
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
        //public GameObject P1Card;
        public TMP_Text PlayerStatsHeader;
        public TMP_Text CarCountNum;
        public TMP_Text JobTitle;
        public TMP_Text JobSalary;
        public TMP_Text BonusNum;
        public TMP_Text HomesArray;
        public TMP_Text FStatusArray;
        public Player Player1;
        public Player Player2;
        public Player Player3;
        public Player Player4;
        public GameObject Spinner;
        public TMP_Text TurnHeader;

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
            if (turn == 4)
            {
                toggleSpinner();
                TurnHeader.text = "";
            }
        }

        public void nextPlayer()
        {
            PlayerNumber.text = (turn+1).ToString();
            NameInput.SetActive(!NameInput.activeInHierarchy);
        }

        public void toggleSpinner()
        {
            Spinner.SetActive(!Spinner.activeInHierarchy);
        }

        public void ToggleNameInput()
        {
            NameInput.SetActive(!NameInput.activeInHierarchy);
        }

        public void setPlayerToggle(string name)
        {
            if (turn == 0)
            {
                P1.GetComponentInChildren<TMP_Text>().text = name.ToUpper();
                //PlayerStatsHeader.text = name.ToUpper() + " STATS";
                Player1.setPlayerName(name);
                //P1Card.GetComponent<Player>().playerName = name;
            }
            else if (turn == 1)
            {
                P2.GetComponentInChildren<TMP_Text>().text = name.ToUpper();
                //PlayerStatsHeader.text = name.ToUpper() + " STATS";
                Player2.setPlayerName(name);
            }
            else if (turn == 2)
            {
                P3.GetComponentInChildren<TMP_Text>().text = name.ToUpper();
                //PlayerStatsHeader.text = name.ToUpper() + " STATS";
                Player3.setPlayerName(name);
            }
            else if (turn == 3)
            {
                P4.GetComponentInChildren<TMP_Text>().text = name.ToUpper();
                //PlayerStatsHeader.text = name.ToUpper() + " STATS";
                Player4.setPlayerName(name);
            }
        }

        public void togglePlayerCard(GameObject card)
        {
            card.SetActive(!card.activeInHierarchy);
        }

        public void callCard(Player player)
        {
            PlayerStatsHeader.text = player.playerName.ToUpper() + " STATS";
            CarCountNum.text = player.numPeople.ToString();
            JobTitle.text = player.jobTitle;
            JobSalary.text = player.salary.ToString();
            BonusNum.text = player.bonus.ToString();
            FStatusArray.text = player.finStatus;
        }

    /*
        public static void generateCard()
        {
            CarCountNum.text = Player1.numPeople.ToString();
            JobTitle.text = Player1.jobTitle;
            JobSalary.text = Player1.salary.ToString();
            BonusNum.text = Player1.bonus.ToString();
            FStatusArray.text = Player1.finStatus;
        }*/
    }
/*
    public class PlayerMakers
    {
        public static int turn;

        public static void createPlayer(string name, int turn)
        {
            if (turn % 4 == 0)
            {
                Player player1 = new Player(name);
                Debug.Log(name);
                (new PlayerNames()).generateCard(player1);
            }
            else if (turn % 4 == 1)
            {
                Player player2 = new Player(name);
                Debug.Log(name);
                generateCard(player2);
            }
            else if (turn % 4 == 2)
            {
                Player player3 = new Player(name);
                Debug.Log(name);
                generateCard(player3);
            }
            else if (turn % 4 == 3)
            {
                Player player4 = new Player(name);
                Debug.Log(name);
                generateCard(player4);
            }
            turn++;
        }
    }*/
/*
    public class Player : MonoBehaviour
    {
        public string playerName;
        public string jobTitle;
        public int balance;
        public int numPeople;
        public static string[] statuses = {"Low Income", "Low Income", "Low Income", "Middle Class", "Middle Class", "Middle Class", "Middle Class", "Top 1%", "Top 1%", "Top 1%"};
        public string finStatus;
        public int salary;
        public int bonus;
        public ArrayList homes;

        public Player(string name)
        {
            playerName = name;
            jobTitle = "Unemployed";
            balance = 0;
            numPeople = 0;
            finStatus = "Unknown";
            salary = 0;
            bonus = 0;
            homes = new ArrayList();
        }

        public Player()
        {
            playerName = "Unnamed";
            jobTitle = "Unemployed";
            balance = 0;
            numPeople = 0;
            finStatus = "Unknown";
            salary = 0;
            bonus = 0;
            homes = new ArrayList();
        }

        public void setJobInfo(string jobTitle, int salary, int bonus)
        {
            this.jobTitle = jobTitle;
            this.salary = salary;
            this.bonus = bonus;
        }

        public void addBalance(int add)
        {
            this.balance += add;
        }

        public void subBalance(int sub)
        {
            this.balance -= sub;
        }

        public void addPeople(int add)
        {
            this.numPeople += add;
        }

        public void getFinStatus(int stat)
        {
            this.finStatus = statuses[stat-1];
        }

        public void addHomes(string color)
        {
            this.homes.Add(color);
        }
    }*/
}
