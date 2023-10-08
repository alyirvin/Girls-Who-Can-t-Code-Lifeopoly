using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayJob : MonoBehaviour
{
    public List<Job> DisplayJob = new list<Job>();
    public int ID;

    public string JobTitle;
    public int Income;
    public int Bonus;

    public Text nameText;
    public Text incomeText;
    public Text bonusText;

    // Start is called before the first frame update
    void Start()
    {
        DisplayJob[0] = JobDatabase.JobList[ID];
    }

    // Update is called once per frame
    void Update()
    {
        id = displayJob[0].id;
        JobTitle = displayJob[0].JobTitle;
        Income = displayJob[0].Income;
        Bonus = displayJob[0].Bonus;

        nameText.text = " " + JobTitle;
        incomeText.text = " " + Income;
        bonusText.text = " " + Bonus;
    }
}
