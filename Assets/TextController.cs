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

    GameTime time = new GameTime();
    Player player = new Player();
    Boss boss = new Boss();
    Room room = new Room();

    // Use this for initialization
    void Start () {
        consoleBox.text = "LUNCH BREAK IS OVER. LET'S BE HONEST, NO ONE REALLY WORKS AROUND HERE. " +
            "TRY TO WASTE TIME UNTIL THE END OF THE DAY. DON'T GET CAUGHT SLACKING OFF BY YOUR BOSS!\n\n" 
            + "TYPE START TO BEGIN.";
        inputBox.text = ">";
        textConsole = "";
        textInput = ">";

        player.currentLocation = "cubical";
        time.setTime(60);
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
        string currentLoc = player.currentLocation;
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
        
        switch(currentLoc)
        {
            case "cubical":
                consoleBox.text = room.cubical(action, target, input);
                break;
            case "cubeFarm":
                consoleBox.text = room.cubeFarm(action, target, input);
                break;
            case "h1":
                consoleBox.text = room.h1(action, target, input);
                break;
            case "h2":
                consoleBox.text = room.h2(action, target, input);
                break;
            case "h3":
                consoleBox.text = room.h3(action, target, input);
                break;
            case "h4":
                consoleBox.text = room.h4(action, target, input);
                break;
            case "bathroom":
                consoleBox.text = room.bathroom(action, target, input);
                break;
            case "landing":
                consoleBox.text = room.landing(action, target, input);
                break;
            case "kitchen":
                consoleBox.text = room.kitchen(action, target, input);
                break;
            case "serverRoom":
                consoleBox.text = room.serverRoom(action, target, input);
                break;
            case "confRoom":
                consoleBox.text = room.confRoom(action, target, input);
                break;
            case "bossOffice":
                consoleBox.text = room.bossOffice(action, target, input);
                break;
            case "elevator":
                consoleBox.text = room.elevator(action, target, input);
                break;
        }       
    }
   
}
public class Room
{
    GameTime time = new GameTime();
    Err error = new Err();
    enum rooms { cubical, cubeFarm, h1, h2, h3, h4, bathroom, landing, kitchen, serverRoom, confRoom, bossOffice, elevator };
    enum people { lexie, ed, boss };
    enum stuff { computer, cup, cabinet, coffeePot, fridge, vending, whiteboard, toilet, sink };
    enum bossPath { h3, h2, h1, cubeFarm, landing, h4 };
    enum actions { look, take, put, talk, interact };


   public string cubical(string action, string target, string input)
    {

        if (action == "help" && target == "")
        {
            return "HELP STATEMENT GOES HERE\n" + time.getTime() + "\n";
        }
        else if (action == "start" && target == "")
        {
            time.setTime(0);
            return "YOU FIND YOURSELF IN YOUR CUBICAL AFTER LUNCH WITH NOTHING TO DO AND MR. BOSS WON'T LET YOU LEAVE EARLY. " +
                "IN YOUR CUBE THERE IS A DESK IN FRONT OF YOU TO THE WEST. " +
                "TO THE EAST THERE IS A FILING CABINET. " +
                "TO THE SOUTH IS THE ONLY OPENING AND JUST A WALL TO THE NORTH.\n" + time.getTime() + "\n\n" + input;

        }
        else if (action == "" && target == "")
        {
            return "\n" + time.getTime() + "\n\n" + input;
            
        }
        else
        {
            return error.error(101, input);
        }
    }

    public string cubeFarm(string action, string target, string input)
    {
        return "THIS IS THE CUBE FARM";
    }

    public string h1(string action, string target, string input)
    {
        return "THIS IS THE HALLWAY";
    }

    public string h2(string action, string target, string input)
    {
        return "THIS IS THE HALLWAY";
    }

    public string h3(string action, string target, string input)
    {
        return "THIS IS THE HALLWAY";
    }

    public string h4(string action, string target, string input)
    {
        return "THIS IS THE HALLWAY";
    }

    public string bathroom(string action, string target, string input)
    {
        return "THIS IS THE BATHROOM";
    }

    public string landing(string action, string target, string input)
    {
        return "THIS IS THE ELEVATOR LANDING";
    }

    public string kitchen(string action, string target, string input)
    {
        return "THIS IS THE KITCHEN";
    }

    public string serverRoom(string action, string target, string input)
    {
        return "THIS IS THE SERVER ROOM";
    }

    public string confRoom(string action, string target, string input)
    {
        return "THIS IS THE CONFERENCE ROOM";
    }

    public string bossOffice(string action, string target, string input)
    {
        return "THIS IS YOUR BOSS'S OFFICE";
    }

    public string elevator(string action, string target, string input)
    {
        if (time.getGameOver() == false)
        {
            return "GAME OVER, WOULD YOU LIKE TO PLAY AGAIN?";
        }
        else
        {
            return "IT IS NOT 5PM YET. IT IS NOT TIME TO LEAVE.";
        }
    }
}
public class GameTime
{
    public string currentTime;
    public bool gameOver;
    int currentMin;
    int currentHour;
    public void setTime(int minute)
    {
        currentMin = currentMin + minute;

        if (currentMin >= 60)
        {
            currentHour = currentHour + 1;
            currentMin = currentMin - 60;
        }
        if (currentMin < 10)
        {
            currentTime = currentHour.ToString() + ":" + "0" + currentMin.ToString() + " PM";
        }
        else
        {
            currentTime = currentHour.ToString() + ":" + currentMin.ToString() + " PM";
        };

        finished();
    }
    public string getTime()
    {
        return currentTime;
    }
    void finished()
    {
        if (currentHour >= 5)
        {
            gameOver = true;
        }
        else
        {
            gameOver = false;
        }
    }
    public bool getGameOver()
    {
        return gameOver;
    }

}
public class Player
{
    public string currentLocation { get; set; }
    public int compCount { get; set; }
    public int fileCount { get; set; }
    public int edCount { get; set; }
    public int lexCount { get; set; }
    public int coffeeCount { get; set; }
    public int printCount { get; set; }
    public int pooCount { get; set; }
    public string[] inventory;
    public int invCount;
    public string invMax;

    public void addInventory(string item)
    {
        if(invCount <= 3)
        {
            push(item);
        }
        else
        {
            invMax = "YOU ARE CARRYING TOO MANY ITEMS";
        }
    }

    public int dropInventory(string item)
    {
        return pop(item);
    }
    void push(string item)
    {
        int i = 0;
        while(i < 4)
        {
            if(inventory[i] == null)
            {
                inventory[i] = item;
                break;
            }
            i++;
        }
    }
    int pop(string item)
    {
        int x = 0;
        int i = 0;
        while (i < 4)
        {
            if (inventory[i] == item)
            {
                inventory[i] = null;
                x = 1;  
            }
            i++;
        }
        return x;
    }
}

public class Boss
{
    public string currentLocation { get; set; }
    void move()
    {

    }
}

public class Err
{
    // Error codes to send out to the UI console
    public string error(int code, string input)
    {
        if (code == 101)
        {
           return input + "?\n" + "I DON'T KNOW HOW TO DO THAT. TYPE START AND TRY AGAIN.";
        }
        else
        {
            return "NO ERROR CODE GIVEN";
        }

    }
}


   

