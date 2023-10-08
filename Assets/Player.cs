using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string playerName;
    private string jobTitle;
    private int balance;
    private int numPeople;
    private static string[] statuses = {"Low Income", "Low Income", "Low Income", "Middle Class", "Middle Class", "Middle Class", "Middle Class", "Top 1%", "Top 1%", "Top 1%"};
    private string finStatus;
    private int salary;
    private int bonus;
    private ArrayList homes;

    public Player(string name)
    {
        playerName = name;
        jobTitle = "Unemployed";
        balance = 0;
        numPeople = 0;
        finStatus = "Unknown";
        salary = 0;
        bonus = 0;
        homes = new ArrayList(){};
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

