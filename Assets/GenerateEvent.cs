using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GenerateEvent : MonoBehaviour
{
    public TMP_Text EventText;

    //Create event array
    public string[] eventTextList =
        {

            "Take the whole crew on vacation! Pay 10K to the bank for each peg in your car.",
            "Start an ant farm! insects are the protein of the future. Pay 30K to the bank.",
            "You fall while saving a kitten in a tree. The town pays your bills. Collect 20K from each player.",
            "Its time to finally achieve your dream home! Pay 10K for a home renovation.",
            "Tax refund! Collect 10K",
            "You've got talent!Collect 20K in prize money",
            "Yum! You won a cooking competition! Collect 20K in prize money.",
            "Oh no! Grandma died. Inherit 50K.",
            "It's your birthday! Collect 10K from each player.",
            "Sold! Host a neighborhood garage sale. Collect 20K in sales.",
            "Is this a cult? Join Scientology! Pay 40K in fees.",
            "Receive a bonus at work! Collect 10K.",
            "Is this what fame feels like? Win a reality TV show! Collect 20K in prize money.",
            "Ahhh. Pay 10k for a luxury spa weekend.",
            "Huh? It's a lost wallet. Collect 30K in your newly found cash.",
            "Lose your wallet! Pay 30K to replace your lost cards and cash.",
            "Time to get into shape! Pay 20K for your new fitness coach.",
            "A bookcase fell on your face! Luckily, your cousin caught it on film. Collect 20K from your Youtube fame.",
            "You dropped a half-eaten banana on the floor. The local museum pays you 50K for your modern art.",
            "You toss a take-out container out your car window. Pay 20K in littering fees.",
            "You've won a local trivia contest! Collect 20K in prize money.",
            "Embrace healthy living! Pay 10K in gardening supplies for your new home garden.",
            "Did you eat raw chicken again? Pay 30K in cooking lessons.",
            "Start a side hustle as a rideshare driver. Collect 10K for every space you just drove.",
            "Nothing like bad weather, evil bugs, no sleep, and angry relatives. Pay 10K for a family camping trip ",
            "You've won a radio contest! Collect 20K in prize money.",
            "You invested in cryptocurrency! It did not go well. Lose 30K.",
            "You invested in cryptocurrency! You won big! Collect 30K.",
            "You've written a bestselling book! Collect 30K in royalties.",
            "Start a podcast. Collect 10K in advertising revenue.",
            "Receive a grant for your innovative startup idea! Collect 10K.",
            "Start a new hobby, collecting vintage cars. Pay 40K.",
            "Host a successful charity event. You are corrupt. Collect 10K in donations.",
            "Vegas Trip! Lose 20K to your gambling debts.",
            "You invested in a local business. It failed. Pay 20K. ",
            "Win a singing competition! Collect 20K in prize money.",
        };

    // Start is called before the first frame update
    void Start()
    {
        string evliststring = eventTextList[Random.Range(0, eventTextList.Length)];
        EventText.text = evliststring;

}

    // Update is called once per frame
   
}
