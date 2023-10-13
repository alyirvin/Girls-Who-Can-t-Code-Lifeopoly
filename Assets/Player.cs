using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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

    public void setPlayerName(string name)
    {
        this.playerName = name;
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
}
