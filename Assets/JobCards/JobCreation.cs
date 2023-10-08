using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]

public class Job
{
    private int ID;
    private string JobTitle;
    private int Income;
    private int Bonus;
    //public ArrayList JobOptions;

    public Job()
    {

    }


    public Job(int id, string title, int job_income, int job_bonus)
    {
        JobTitle = title;
        ID = id;
        Income = job_income;
        Bonus = job_bonus;
    }
/*
    // Start is called before the first frame update
    void Start()
    {
        JobOptions = new ArrayList();
        JobOptions.Add(Job Police = new Job("Police Officer", 0, 60000, 70000));
        JobOptions.Add(Job Doctor = new Job("Doctor", 1, 80000, 160000));
        JobOptions.Add(Job Vlogger = new Job("Vlogger", 2, 50000, 90000));
        JobOptions.Add(Job Lawyer = new Job("Lawyer", 3, 80000, 120000));
        JobOptions.Add(Job Athlete = new Job("Athlete", 4, 50000, 70000));
        JobOptions.Add(Job Actor = new Job("Actor", 5, 40000, 60000));
        JobOptions.Add(Job Teacher = new Job("Teacher", 6, 50000, 100000));
        JobOptions.Add(Job Pilot = new Job("Pilot", 7, 70000, 90000));
        JobOptions.Add(Job Astronaut = new Job("Astronaut", 8, 60000, 120000));
        JobOptions.Add(Job Politician = new Job("Politician", 9, 70000, 140000));
        JobOptions.Add(Job Accountant = new Job("Accountant", 10, 70000, 80000));
        JobOptions.Add(Job Musician = new Job("Musician", 11, 40000, 80000));
        JobOptions.Add(Job Chef = new Job("Chef", 12, 60000, 80000));
        JobOptions.Add(Job Scientist = new Job("Scientist", 13, 80000, 10000));
        JobOptions.Add(Job Developer = new Job("App Developer", 14, 60000, 100000));
        JobOptions.Add(Job Engineer = new Job("Engineer", 15, 80000, 90000,));
    }
*/
    // Update is called once per frame
    void Update()
    {
        //JobList[Random.Range(0, deckList.Count)];
        // Debug.LogError(JobList[Random.Range(0, deckList.Count)]);
    }
}
