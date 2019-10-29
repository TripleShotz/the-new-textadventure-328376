using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States
    {
        start,
        intro, 
        koelkast,
        uiteten,
        etenhalen,
        mcdonalds,
        dominos,
        jumbo,
        ah
    }

    private States currentStates = States.start;
    // Start is called before the first frame update
    void Start()
    
    {
       ShowMainmenu();
    }

    private void Update()
    {
        print(currentStates);
    }


    // Update is called once per frame
    void OnUserInput(string input)
    {
        if (currentStates == States.start)
        {
            if (input == "start")
            {
                StartIntro();
            }
            else if (input == "credits")
            {
                Terminal.WriteLine("Gemaakt door: Yannick van Baren");
            }
            else
            {
                Terminal.WriteLine("Typ start...");
            }
        }
    
        else if (currentStates == States.intro)
        {
            if (input == "koelkast")
            {
                Startkoelkast();
                currentStates = States.koelkast;
            }
            else if (input == "uiteten")
            {
                Startuiteten();
                currentStates = States.uiteten;
            }
            else
            {
                Terminal.WriteLine("typ het antwoordt...");
            }
        }
        
        else if (currentStates == States.koelkast)
        {
            if (input == "etenhalen")
            {
                startetenhalen();
                currentStates = States.etenhalen;
            }
            else if (input == "uiteten")
            {
                Startuiteten();
                currentStates = States.uiteten;
            }
            else
            {
                Terminal.WriteLine("typ het antwoordt...");
            }
        }
                
        else if (currentStates == States.uiteten)
        {
            if (input == "mcdonalds")
            {
                startMcDonalds();
                currentStates = States.mcdonalds;
            }
            else if (input == "dominos")
            {
                startDominos();
                currentStates = States.dominos;
            }
            else
            {
                Terminal.WriteLine("typ het antwoordt...");
            }
        }
        
        else if (currentStates == States.etenhalen)
        {
            if (input == "jumbo")
            {
                startJumbo();
                currentStates = States.jumbo;
            }
            else if (input == "ah")
            {
                startAH();
                currentStates = States.ah;
            }
            else
            {
                Terminal.WriteLine("typ het antwoordt...");
            }
        }
        
        else if (currentStates == States.dominos)
        {
            if (input == "menu")
            {
                ShowMainmenu();
                currentStates = States.start;
            }
            else
            {
                Terminal.WriteLine("typ het antwoordt...");
            }
        }        
        
        else if (currentStates == States.mcdonalds)
        {
            if (input == "menu")
            {
                ShowMainmenu();
                currentStates = States.start;
            }
            else
            {
                Terminal.WriteLine("typ het antwoordt...");
            }
        }        
        
        else if (currentStates == States.jumbo)
        {
            if (input == "menu")
            {
                ShowMainmenu();
                currentStates = States.start;
            }
            else
            {
                Terminal.WriteLine("typ het antwoordt...");
            }
        }        
        
        else if (currentStates == States.ah)
        {
            if (input == "menu")
            {
                ShowMainmenu();
                currentStates = States.start;
            }
            else
            {
                Terminal.WriteLine("typ het antwoordt...");
            }
        }
        

    }


    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("");
        Terminal.WriteLine("je wordt wakker na een lange nacht");
        Terminal.WriteLine("je hebt trek als een os");
        Terminal.WriteLine("je kunt twee dingen doen");
        Terminal.WriteLine("de koelkast checken of uit eten gaan");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ koelkast of uiteten");
        currentStates = States.intro;
    }

    void Startkoelkast()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je opent de koelkast en je ziet dat er niks is");
        Terminal.WriteLine("je bedenkt wat je kan doen");
        Terminal.WriteLine("je bedenkt twee dingen");
        Terminal.WriteLine("je gaat eten halen bij de supermarkt of je gaat uit eten");
        Terminal.WriteLine("typ etenhalen of uiteten");
        currentStates = States.koelkast;
    }

    void Startuiteten()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je gaat de deur uit");
        Terminal.WriteLine("je twijfelt waar je gaat eten");
        Terminal.WriteLine("je hebt vier plekken waar je heel graag wilt eten");
        Terminal.WriteLine("je moet er 2 kiezen");
        Terminal.WriteLine("je kiest de McDonalds of de Dominos");
        Terminal.WriteLine("typ mcdonalds of dominos");
        currentStates = States.uiteten;
    }


    void startetenhalen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je loopt de deur uit");
        Terminal.WriteLine("je loopt naar het centrum");
        Terminal.WriteLine("je komt uit tussen de AH en de jumbo");
        Terminal.WriteLine("je wilt 1 van de 2 en gaat kiezen");
        Terminal.WriteLine("typ jumbo of ah");
        currentStates = States.etenhalen;
    }

    void startDominos()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je loopt de Dominos binnen");
        Terminal.WriteLine("je bestelt je eten");
        Terminal.WriteLine("terwijl je dit doet loopt er iemand binnen");
        Terminal.WriteLine("de man heeft een geweer en schiet de boel rond");
        Terminal.WriteLine("je wordt meerdere malen geraakt");
        Terminal.WriteLine("je bent dood");
        Terminal.WriteLine("typ menu om terug te gaan naar het menu");
        currentStates = States.dominos;
    }

    void startMcDonalds()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je loopt de McDonalds in");
        Terminal.WriteLine("je besteld je eten en gaat een tafel zitten");
        Terminal.WriteLine("je eten wordt na 5 minuten wachten gebracht");
        Terminal.WriteLine("je eet je eten op en loopt naar huis");
        Terminal.WriteLine("als je thuis aankomt blijkt er ingebroken te zijn");
        Terminal.WriteLine("gelukkig dat je er niet was");
        Terminal.WriteLine("je hebt het overleeft");
        Terminal.WriteLine("typ menu om terug te gaan naar het menu");
        currentStates = States.mcdonalds;
    }

    void startJumbo()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je loopt de jumbo binnen");
        Terminal.WriteLine("je pakt wraps, sla en kip");
        Terminal.WriteLine("je loopt naar de kassa");
        Terminal.WriteLine("op hetzelfde moment staat er een man met een geweer");
        Terminal.WriteLine("je bedenkt je geen moment en valt de man aan");
        Terminal.WriteLine("je overwint de man en dan komt de politie binnen rennen");
        Terminal.WriteLine("de politie neemt het over je bent de redder in nood");
        Terminal.WriteLine("je hebt de dag overleeft");
        Terminal.WriteLine("typ menu om terug te gaan naar het menu");
        currentStates = States.jumbo;
    }

    void startAH()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je loopt de AH binnen");
        Terminal.WriteLine("je pakt een paar pizzas en loopt naar de kassa");
        Terminal.WriteLine("je betaalt en loopt de winkel uit");
        Terminal.WriteLine("je ziet aan de overkant allemaal politie en je loopt erheen");
        Terminal.WriteLine("je komt er aan en je hoort schoten");
        Terminal.WriteLine("je wordt geraakt door een kogel vanuit de winkel");
        Terminal.WriteLine("de ambulace wordt gebeld en je wordt meegevoert");
        Terminal.WriteLine("je overlijdt in het ziekenhuis");
        Terminal.WriteLine("typ menu om terug te gaan naar het menu");
        currentStates = States.ah;
    }



    void ShowMainmenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welkom bij de GameAdventure");
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("typ credits om de game maker te zien");
        Terminal.WriteLine("Typ start om te beginnen...");
    }
}


