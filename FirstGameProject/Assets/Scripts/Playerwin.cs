using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerwin : MonoBehaviour
{
    public bool player1 = false;
    public bool player2 = false;
    public Text printtext;
    void Start()
    {
        printtext.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(player1)
        {
            printtext.text = "Player 2 Won";
        }
        if(player2)
        {
            printtext.text = "Player 1 Won";
        }
    }
}
