public class LofL
{
    private string[] varinput;
    //Constructor setting value for varinput
    public LofL(string[] varinput)
    {
        this.varinput = varinput;
    }
    /// <summary>
    /// uses list to produce a league champion suggestion 
    /// </summary>
    /// <returns>Top 3 champions that best fit users description</returns>
    public string Solve()
    {
        wantedchamp<string> epic = new wantedchamp<string>(varinput);



        bool searchRange = false;
        bool searchResource = false;
        bool searchClass = false;
        bool searchLane = false;
        bool searchDiff = false;
        bool searchPower = false;
        //Key words to search for from the txt file
        if (epic.LookFor("Mana") || epic.LookFor("Special")) {
            searchResource = true;
        }
        if (epic.LookFor("Melee") || epic.LookFor("Ranged") || epic.LookFor("Both")) {
            searchRange = true;
        } 
        if (epic.LookFor("Assassin") || epic.LookFor("Tank") || epic.LookFor("Fighter") || epic.LookFor("Mage") || epic.LookFor("Support") || epic.LookFor("Marksman")) {
            searchClass = true;
        }
        if (epic.LookFor("Top") || epic.LookFor("Jungle") || epic.LookFor("Middle") || epic.LookFor("Bot") || epic.LookFor("Sup")) {
            searchLane = true;
        }
        if (epic.LookFor("Easy") || epic.LookFor("Medium") || epic.LookFor("Hard")) {
            searchDiff = true;
        }
        if (epic.LookFor("Early") || epic.LookFor("Mid") || epic.LookFor("Late") || epic.LookFor("All")) {
            searchPower = true;
        }
        
        
        string[][] fileSepSep = new string[162][];
        int[] pointsofChampion = new int[162];

        string fileLines = File.ReadAllText("LeagueSpread.txt");
        string[] fileSep = fileLines.Split("\n");

        for (int i=0;i < 162; i++) {
            fileSepSep[i] = fileSep[i].Split(",");
        }

        // Searches for keywords to supply points to each champion
        if (searchResource) {
            for (int i=0; i < 162; i++) {
                if (epic.Get("Mana") == fileSepSep[i][1].ToString()) {
                    pointsofChampion[i] += 1;
                } else if (epic.Get("Special") == fileSepSep[i][1].ToString()) {
                    pointsofChampion[i] += 1;
                }
            }
        } 
        if (searchRange) {
            for (int i=0; i < 162; i++) {
                if (epic.Get("Melee") == fileSepSep[i][2].ToString()) {
                    pointsofChampion[i] += 4;
                } else if (epic.Get("Ranged") == fileSepSep[i][2].ToString()) {
                    pointsofChampion[i] += 4;
                } else if (epic.Get("Both") == fileSepSep[i][2].ToString()) {
                    pointsofChampion[i] += 4;
                }
            }
        }
        if (searchClass) {
            for (int i=0; i < 162; i++) {
                if (epic.Get("Assassin") == fileSepSep[i][3].ToString()) {
                    pointsofChampion[i] += 2;
                } else if (epic.Get("Tank") == fileSepSep[i][3].ToString()) {
                    pointsofChampion[i] += 2;
                } else if (epic.Get("Fighter") == fileSepSep[i][3].ToString()) {
                    pointsofChampion[i] += 2;
                } else if (epic.Get("Mage") == fileSepSep[i][3].ToString()) {
                    pointsofChampion[i] += 2;
                } else if (epic.Get("Support") == fileSepSep[i][3].ToString()) {
                    pointsofChampion[i] += 2;
                } else if (epic.Get("Marksman") == fileSepSep[i][3].ToString()) {
                    pointsofChampion[i] += 2;
                }
            }
        }
        if (searchClass) {
            for (int i=0; i < 162; i++) {
                if (epic.Get("Assassin") == fileSepSep[i][4].ToString()) {
                    pointsofChampion[i] += 2;
                } else if (epic.Get("Tank") == fileSepSep[i][4].ToString()) {
                    pointsofChampion[i] += 2;
                } else if (epic.Get("Fighter") == fileSepSep[i][4].ToString()) {
                    pointsofChampion[i] += 2;
                } else if (epic.Get("Mage") == fileSepSep[i][4].ToString()) {
                    pointsofChampion[i] += 2;
                } else if (epic.Get("Support") == fileSepSep[i][4].ToString()) {
                    pointsofChampion[i] += 2;
                } else if (epic.Get("Marksman") == fileSepSep[i][4].ToString()) {
                    pointsofChampion[i] += 2;
                }
            }
        }
        if (searchLane) {
            for (int i=0; i < 162; i++) {
                if (epic.Get("Top") == fileSepSep[i][5].ToString()) {
                    pointsofChampion[i] += 3;
                } else if (epic.Get("Middle") == fileSepSep[i][5].ToString()) {
                    pointsofChampion[i] += 3;
                } else if (epic.Get("Jungle") == fileSepSep[i][5].ToString()) {
                    pointsofChampion[i] += 3;
                } else if (epic.Get("Bot") == fileSepSep[i][5].ToString()) {
                    pointsofChampion[i] += 3;
                } else if (epic.Get("Sup") == fileSepSep[i][5].ToString()) {
                    pointsofChampion[i] += 3;
                }
            }
        }
        if (searchLane) {
            for (int i=0; i < 162; i++) {
                if (epic.Get("Top") == fileSepSep[i][6].ToString()) {
                    pointsofChampion[i] += 3;
                } else if (epic.Get("Middle") == fileSepSep[i][6].ToString()) {
                    pointsofChampion[i] += 3;
                } else if (epic.Get("Jungle") == fileSepSep[i][6].ToString()) {
                    pointsofChampion[i] += 3;
                } else if (epic.Get("Bot") == fileSepSep[i][6].ToString()) {
                    pointsofChampion[i] += 3;
                } else if (epic.Get("Sup") == fileSepSep[i][6].ToString()) {
                    pointsofChampion[i] += 3;
                }
            }
        }
        if (searchLane) {
            for (int i=0; i < 162; i++) {
                if (epic.Get("Top") == fileSepSep[i][7].ToString()) {
                    pointsofChampion[i] += 2;
                } else if (epic.Get("Middle") == fileSepSep[i][7].ToString()) {
                    pointsofChampion[i] += 2;
                } else if (epic.Get("Jungle") == fileSepSep[i][7].ToString()) {
                    pointsofChampion[i] += 2;
                } else if (epic.Get("Bot") == fileSepSep[i][7].ToString()) {
                    pointsofChampion[i] += 2;
                } else if (epic.Get("Sup") == fileSepSep[i][7].ToString()) {
                    pointsofChampion[i] += 2;
                }
            }
        }
        if (searchDiff) {
            for (int i=0; i < 162; i++) {
                if (epic.Get("Easy") == fileSepSep[i][8].ToString()) {
                    pointsofChampion[i] += 4;
                } else if (epic.Get("Medium") == fileSepSep[i][8].ToString()) {
                    pointsofChampion[i] += 4;
                } else if (epic.Get("Hard") == fileSepSep[i][8].ToString()) {
                    pointsofChampion[i] += 4;
                }
            }
        }
        if (searchPower) {
            for (int i=0; i < 162; i++) {
                if (epic.Get("Early") == fileSepSep[i][9].ToString()) {
                    pointsofChampion[i] += 2;
                } else if (epic.Get("Mid") == fileSepSep[i][9].ToString()) {
                    pointsofChampion[i] += 2;
                } else if (epic.Get("Late") == fileSepSep[i][9].ToString()) {
                    pointsofChampion[i] += 2;
                } else if (epic.Get("All") == fileSepSep[i][9].ToString()) {
                    pointsofChampion[i] += 2;
                }
            }
        }

        //getting top 3 best champions
        int firstcharacterindex = 0;
        int secondcharacterindex = 0;
        int thirdcharacterindex = 0;
        int first = 0;
        int second = 0;
        int third = 0;
        for (int i=0; i<162; i++) {
            Console.WriteLine(fileSepSep[i][0] + ":" + pointsofChampion[i]);
        }
        for (int i=0; i<162; i++) {
            if (pointsofChampion[i] > first) {
                thirdcharacterindex = secondcharacterindex;
                secondcharacterindex = firstcharacterindex;
                firstcharacterindex = i;
                first = pointsofChampion[i];
            }
            else if (pointsofChampion[i] > second) {
                thirdcharacterindex = secondcharacterindex;
                secondcharacterindex = i;
                second = pointsofChampion[i];
            }
             else if (pointsofChampion[i] > third) {
                thirdcharacterindex = i;
                third = pointsofChampion[i];
            }
        }
        // Connects 3 champs and returns them
        string idk = fileSepSep[firstcharacterindex][0] + ", " + fileSepSep[secondcharacterindex][0] + ", " + fileSepSep[thirdcharacterindex][0];
        return idk;
    }
    /// <summary>
    /// This fetches a part of an list, this can be used to debug and test the code for inaccuracies
    /// </summary>
    /// <param name="e">A string we are checking for in the list</param>
    /// <returns>the value of the string if present and if not then an empty string.</returns>
    public string GetPartOfArray(string e) {
        wantedchamp<string> epic2 = new wantedchamp<string>(varinput);
        return epic2.Get(e);
    }
}