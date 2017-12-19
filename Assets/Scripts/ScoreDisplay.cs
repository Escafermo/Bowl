using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{

    public Text[] rollTexts, frameTexts;

    public void FillRolls(List<int> rolls)
    {
        string scoreString = FormatRolls(rolls);

       for (int i = 0; i < scoreString.Length; i++)
        {
            rollTexts[i].text = scoreString[i].ToString();
        }
       
    }

    public void FillFrames(List<int> frames)
    {
        for (int i = 0; i < frames.Count; i++)
        { 
            frameTexts[i].text = frames[i].ToString();

        }
    }

    public static string FormatRolls (List<int> rolls)
    {
        //List<string> rollsStringList = new List<string>();

        string rollsString = "";

        for (int i = 0; i < rolls.Count; i++)
        {
            int box = rollsString.Length + 1;                                             //Score box 1 to 21

            if (rolls[i] == 0)                                                           //ZERO IS DASH
            {
                rollsString += "-";
            }
            else if ((box % 2 == 0 || box == 21) && rolls[i] + rolls[i - 1] == 10)        //SPARE
            {
                rollsString = rollsString + "/";                            
            }
            else if (box >= 19 && rolls[i] == 10)                                        //STRIKE IN LAST FRAME
            {
                rollsString += "X";
            }
            else if (rolls[i] == 10)                                                    //STRIKE
            {
                rollsString += "X ";                          
            }                                                               
            else                                                                       //NORMAL GAME
            {
                rollsString += rolls[i].ToString();
            }
        }
        return rollsString;
    }
}
