using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text inputBox;
    public Text consoleBox;

    string textConsole;
    string textInput;
    string currentTime;
    int currentMin;
    int currentHour;

    // Use this for initialization
    void Start () {
        consoleBox.text = "LUNCH BREAK IS OVER. LET'S BE HONEST, NO ONE REALLY WORKS AROUND HERE. " +
            "TRY TO WASTE TIME UNTIL THE END OF THE DAY. DON'T GET CAUGHT SLACKING OFF BY YOUR BOSS!\n\n" 
            + "TYPE START TO BEGIN.";
        inputBox.text = ">";

        

        textConsole = "";
        textInput = ">";

        currentMin = 0;
        currentHour = 1;
	}
	
	// Update is called once per frame
	void Update () {
        GetInput();
    }

    // All of the UI input keys
    void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            textInput = textInput + " ";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            textInput = textInput + "A";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            textInput = textInput + "B";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            textInput = textInput + "C";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            textInput = textInput + "D";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            textInput = textInput + "E";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            textInput = textInput + "F";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            textInput = textInput + "G";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            textInput = textInput + "H";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            textInput = textInput + "I";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            textInput = textInput + "J";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            textInput = textInput + "K";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            textInput = textInput + "L";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            textInput = textInput + "M";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            textInput = textInput + "N";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            textInput = textInput + "O";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            textInput = textInput + "P";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            textInput = textInput + "Q";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            textInput = textInput + "R";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            textInput = textInput + "S";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            textInput = textInput + "T";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            textInput = textInput + "U";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            textInput = textInput + "V";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            textInput = textInput + "W";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            textInput = textInput + "X";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            textInput = textInput + "Y";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            textInput = textInput + "Z";
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.Backspace) && textInput.Length > 0)
        {
            textInput = textInput.Remove(textInput.Length - 1);
            inputBox.text = textInput;
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            filterInput(textInput);
            textInput = ">";
            inputBox.text = ">";
        }
    }

    // filters out the action and target keywords
    void filterInput(string input)
    {
        string inputLo = input.ToLower();
        string[] filter = inputLo.Split('>',' ');
        string action = filter[1];
        string target;
        string currentLoc = "cubical";
        int j = 0;

        foreach(string s in filter)
        {
            if(s == "")
            {

            }
        }

        if (filter.Length > 2)
        {
            target = filter[2];
        }
        else
        {
            target = "";
        }
        
        if (currentLoc == "cubical")
        {
            cubical(action, target, input);
        }       
    }

    // Sets the clock for the game by adding minutes
    internal void setTime(int minute)
    {
        currentMin = currentMin + minute;

        if(currentMin >= 60)
        {
            currentMin = currentMin - 60;
            currentHour = currentHour + 1;
        };
        
        if(currentMin < 10)
        {
            currentTime = currentHour.ToString() + ":" + "0" + currentMin.ToString() + " PM";
        }
        else
        {
            currentTime = currentHour.ToString() + ":" + currentMin.ToString() + " PM";
        };
        
    }
    #region room functions
    enum rooms {cubical, cubeFarm, h1, h2, h3, h4, bathroom, landing, kitchen, serverRoom, confRoom, bossOffice, elevator};
    enum people {lexie, ed, boss};
    enum stuff {computer, cup, cabinet, coffeePot, fridge, vending, whiteboard, toilet, sink };
    enum bossPath { h3, h2, h1, cubeFarm, landing, h4};
    int compCount;
    int fileCount;
    int edCount;
    int lexCount;
    int coffeeCount;
    int printCount;
    int pooCount;

    void cubical(string action, string target, string input)
    {
        
        if(action == "help" && target == "")
        {
            consoleBox.text = "HELP STATEMENT GOES HERE\n" + currentTime + "\n";
        }
        else if (action == "start" && target == "")
        {
            setTime(0);
            textConsole = "YOU FIND YOURSELF IN YOUR CUBICAL AFTER LUNCH WITH NOTHING TO DO AND MR. BOSS WON'T LET YOU LEAVE EARLY. " +
                "IN YOUR CUBE THERE IS A DESK IN FRONT OF YOU TO THE WEST. " +
                "TO THE EAST THERE IS A FILING CABINET. " +
                "TO THE SOUTH IS THE ONLY OPENING AND JUST A WALL TO THE NORTH.\n" + currentTime + "\n\n" + textInput;

            consoleBox.text = textConsole;
        }
        else
        {
            error(101, input);
        }
    }

    void cubeFarm(string action, string target, string input)
    {

    }

    void h1(string action, string target, string input)
    {

    }

    void h2(string action, string target, string input)
    {

    }

    void h3(string action, string target, string input)
    {

    }

    void h4(string action, string target, string input)
    {

    }

    void bathroom(string action, string target, string input)
    {

    }

    void landing(string action, string target, string input)
    {

    }

    void kitchen(string action, string target, string input)
    {

    }

    void serverRoom(string action, string target, string input)
    {

    }

    void confRoom(string action, string target, string input)
    {

    }

    void bossOffice(string action, string target, string input)
    {

    }

    void elevator(string action, string target, string input)
    {
        if(currentHour >= 5)
        {

        }
    }

    #endregion
    // Error codes to send out to the UI console
    void error(int code, string input)
    {
        if(code == 101)
        {
            consoleBox.text = input + "?\n" + "I don't know how to do that. Press enter and try again.";
        }
        
    }
}


   

