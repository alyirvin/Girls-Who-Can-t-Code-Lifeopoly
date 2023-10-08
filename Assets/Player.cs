using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player
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

    public TMP_Text PlayerName;
    public TMP_Text CarCountNum;
    public TMP_Text JobTitle;
    public TMP_Text JobSalary;
    public TMP_Text BonusNum;
    public TMP_Text HomesArray;
    public TMP_Text FStatusArray;

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

    public void generateCard(Player player)
    {
        PlayerName.text = player.playerName;
        CarCountNum.text = player.numPeople.ToString();
        JobTitle.text = player.jobTitle;
        JobSalary.text = player.salary.ToString();
        BonusNum.text = player.bonus.ToString();
        FStatusArray.text = player.finStatus;
    }
}

