/*
author: Konrad and Dominic
date: 1/23/2022
League of Champions recommender
This is a way for a user to select inputs for their reccomended champ in a way
that is more similar to what a website interface would look like.
*/

/// <summary>
/// Recommends a champion to play
/// </summary>

class Program
{
    public static void Main()
    {

        //these bools will tell us when a user has written valid input and therefore wouldnt need to ask them for it anymore. 
        bool inmanaloop = true;
        bool inrangeloop = true;
        bool inclassloop = true;
        bool inclassloop2 = true;
        bool inlaneloop = true;
        bool inlaneloop2 = true;
        bool inlaneloop3 = true;
        bool indiffloop = true;
        bool inspikeloop = true;

        //these strings store the input the user put in, some of the strings may not get a value such as lanemain2,lanemain3 and classmain2 but that is ok due to the lookfor method only looking for specific inputs.
        string mananmain = "";
        string rangemain = "";
        string lanemain = "";
        string lanemain2 = "";
        string lanemain3 = "";
        string classmain = "";
        string classmain2 = "";
        string diffmain = "";
        string spikemain = "";


        //this main method is a way 
        Console.WriteLine("Welcome to our league reccomender program! This program gives you a champion that matches your playstyle");


            // loop until the user has given a valid manatype or they decide they dont care what it is
            Console.WriteLine("Please input mana type (Mana or Special) or Skip");
            while (inmanaloop) {
                mananmain =  Console.ReadLine();
                if (mananmain == "Mana" || mananmain == "Special" || mananmain == "Skip") {
                    inmanaloop = false;
                } else {
                    Console.WriteLine("Invalid Input please try again");
                }
            }

            // loop until the user has given a range type or they decide they dont care for what it is.
            Console.WriteLine("Please input range type (Melee, Ranged or Both) or Skip");
            while (inrangeloop) {
                rangemain =  Console.ReadLine();
                if (rangemain == "Melee" || rangemain == "Ranged" || rangemain == "Both" || rangemain == "Skip") {
                    inrangeloop = false;
                } else {
                    Console.WriteLine("Invalid Input please try again");
                }
            }

            // loop until the user has given a position or they decide they dont care what it is
            Console.WriteLine("Please input position of champion (Top, Jungle, Middle, Bottom or Sup) or Skip");
            while (inlaneloop) {
                lanemain =  Console.ReadLine();
                if (lanemain == "Top" || lanemain == "Jungle" || lanemain == "Middle" || lanemain == "Bottom" || lanemain == "Sup" || lanemain == "Skip") {
                    inlaneloop = false;
                    //if the user decided not to care about their position then dont care about additonal postions.
                    if (lanemain != "Skip") {
                        // loop until the user has given an additonal position or they decide they dont care what it is
                        Console.WriteLine("Would you like to add an additional position or Skip?");
                        while (inlaneloop2) {
                            lanemain2 =  Console.ReadLine();
                            if ((lanemain2 == "Top" || lanemain2 == "Jungle" || lanemain2 == "Middle" || lanemain2 == "Bottom" || lanemain2 == "Sup" || lanemain2 == "Skip") & lanemain2 != lanemain) {
                                inlaneloop2 = false;
                                //if the user decided not to care about their additonal position then dont care about other additonal postions.
                                if (lanemain2 != "Skip") {
                                // loop until the user has given an additonal^2 position or they decide they dont care what it is
                                Console.WriteLine("Would you like to add an additional position or Skip?");
                                while (inlaneloop3) {
                                    lanemain3 =  Console.ReadLine();
                                    if ((lanemain3 == "Top" || lanemain3 == "Jungle" || lanemain3 == "Middle" || lanemain3 == "Bottom" || lanemain3 == "Sup" || lanemain3 == "Skip") & lanemain3 != lanemain & lanemain3 != lanemain2) {
                                        inlaneloop3 = false;
                                    } else {
                                        Console.WriteLine("Invalid Input please try again");
                                    }
                                }
                                }
                            } else {
                                Console.WriteLine("Invalid Input please try again");
                            }
                        }
                    }
                } else {
                    Console.WriteLine("Invalid Input please try again");
                }
            }

            // loop until the user has given a class or they dont care what it is
            Console.WriteLine("Please input class (Fighter, Tank, Assassin, Mage, Support or Marksman) or Skip");
            while (inclassloop) {
                classmain =  Console.ReadLine();
                if (classmain == "Fighter" || classmain == "Tank" || classmain == "Assassin" || classmain == "Mage" || classmain == "Marksman" || classmain == "Support" || classmain == "Skip") {
                    inclassloop = false;
                    //if user didnt care about first class then they dont care for second class
                    if (classmain != "Skip") {
                    // loop until the user has given an additional class or they dont care what it is
                    Console.WriteLine("Would you like to add an additional class or Skip?");
                    while (inclassloop2) {
                        classmain2 =  Console.ReadLine();
                        if ((classmain2 == "Fighter" || classmain2 == "Tank" || classmain2 == "Assassin" || classmain2 == "Mage" || classmain2 == "Marksman" || classmain == "Support" || classmain2 == "Skip") & classmain2 != classmain) {
                            inclassloop2 = false;
                        } else {
                            Console.WriteLine("Invalid Input please try again");
                        }
                    }
                    }
                    } else {
                        Console.WriteLine("Invalid Input please try again");
                    }
            }

            // loop until the user has given a difficulty or they dont care what it is
            Console.WriteLine("Please input difficulty of champion (Hard, Medium or Easy) or Skip");
            while (indiffloop) {
                diffmain =  Console.ReadLine();
                if (diffmain == "Hard" || diffmain == "Medium" || diffmain == "Easy" || diffmain == "Skip") {
                    indiffloop = false;
                } else {
                    Console.WriteLine("Invalid Input please try again");
                }
            }

            // loop until the user has given a powerspike or they dont care what it is
            Console.WriteLine("Please input powerspike of champion (Early, Mid, Late or All) or Skip");
            while (inspikeloop) {
                spikemain =  Console.ReadLine();
                if (spikemain == "Early" || spikemain == "Mid" || spikemain == "Late" || spikemain == "All" || spikemain == "Skip") {
                    inspikeloop = false;
                } else {
                    Console.WriteLine("Invalid Input please try again");
                }
            }


        string[] varinput = {mananmain, rangemain, lanemain, lanemain2, lanemain3, classmain, classmain2, diffmain, spikemain};

        LofL a = new LofL(varinput);
        Console.WriteLine("The top 3 champs for you are: " + a.Solve());
        // Console.WriteLine(varinput);
    }
}
