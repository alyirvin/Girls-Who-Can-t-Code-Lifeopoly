using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobDatabase : MonoBehaviour
{
    public static List<Job> JobList = new List<Job>();

    void Awake()
    {
        JobList.Add(new Job(0, "Police Officer", 60000, 70000));
        JobList.Add(new Job(1, "Doctor", 80000, 160000));
        JobList.Add(new Job(2, "Vlogger", 50000, 90000));
        JobList.Add(new Job(3, "Lawyer", 80000, 120000));
        JobList.Add(new Job(4, "Athlete", 50000, 70000));
        JobList.Add(new Job(5, "Actor", 40000, 60000));
        JobList.Add(new Job(6, "Teacher", 50000, 100000));
        JobList.Add(new Job(7, "Pilot", 70000, 90000));
        JobList.Add(new Job(8, "Astronaut", 60000, 120000));
        JobList.Add(new Job(9, "Politician", 70000, 140000));
        JobList.Add(new Job(10, "Accountant", 70000, 80000));
        JobList.Add(new Job(11, "Musician", 40000, 80000));
        JobList.Add(new Job(12, "Chef", 60000, 80000));
        JobList.Add(new Job(13, "Scientist", 80000, 100000));
        JobList.Add(new Job(14, "App Developer", 60000, 100000));
        JobList.Add(new Job(15, "Engineer", 80000, 90000));
    }

    public void GenerateJobs()
    {
        //Random random = new Random();
        //int selected = random.Next();
        Debug.LogError(JobList[Random.Range(0, JobList.Count)]);
    }
}
