using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMaster {

    private GameManager gameManager;
    

    public static List<int> ScoreCumulative (List<int> rolls)
    {
        //returns a list of cumulative scores -> the scorecard

        List<int> cumulativeScore = new List<int>();
        
        int runningTotal = 0;

        foreach (int frameScore in ScoreFrames(rolls))
        {
            runningTotal += frameScore;
            cumulativeScore.Add(runningTotal);
        }

        return cumulativeScore;
    }

	public static List<int> ScoreFrames (List<int> rolls)
    {
        List<int> frameList = new List<int>();

        int frameValue = 0;
        int spareValue = 0;
        int strikeValue = 0;

        int n = 1; // number of frames
        int i = 0; //list index


        foreach (int frame in rolls)
        {
            if (n % 2 != 0)
            {
                frameValue += frame;

                if (frameValue == 10)
                {
                    strikeValue += 10;

                    if (strikeValue == 30)
                    {
                        frameList.Insert(i, strikeValue);

                        i = i + 1;

                        strikeValue -= 10;

                    } else if (spareValue == 10)
                    {
                        frameList.Insert(i, spareValue + strikeValue);

                        i = i + 1;

                        spareValue = 0;
                    }

                    frameValue = 0;

                    n = n + 1;

                } else if (spareValue == 10)
                {
                    frameList.Insert(i, frameValue + spareValue);

                    i = i + 1;

                    spareValue = 0;
                    
                } else if (frameList.Count == 9 && strikeValue == 20)
                {
                    frameList.Insert(i, frameValue + strikeValue);

                    i = i + 1;

                    strikeValue = 0;

                }

            } else if (n % 2 == 0)
            {

                frameValue += frame;

                if (frameValue == 10)
                {
                    spareValue += 10;
                    

                    if (strikeValue == 10)
                    {
                        frameList.Insert(i, spareValue + strikeValue);

                        i = i + 1;

                        strikeValue -= 10;


                    } else if (strikeValue == 20)
                    {
                        frameList.Insert(i, (frameValue - frame) + strikeValue);

                        i = i + 1;

                        if (spareValue == 10)
                        {
                            frameList.Insert(i, strikeValue);

                            i = i + 1;
                        }

                        strikeValue = 0;
                        
                    } 

                    frameValue = 0;

                }
                else if (strikeValue == 10)
                {

                    frameList.Insert(i, frameValue + strikeValue);
                    
                    i = i + 1;

                    frameList.Insert(i, frameValue);

                    i = i + 1;

                    strikeValue -= 10;

                    frameValue = 0;

                } else if (strikeValue > 10)
                {
                    frameList.Insert(i, (frameValue - frame) + strikeValue);

                    i = i + 1;
                    
                    strikeValue -= 10;

                    frameList.Insert(i, frameValue + strikeValue);

                    i = i + 1;

                    frameList.Insert(i, frameValue);

                    i = i + 1;

                    strikeValue -= 10;
                    
                    frameValue = 0;


                } else
                {
                    frameList.Insert(i, frameValue);

                    i = i + 1;

                    frameValue = 0;
                    
                }
            } if (frameList.Count == 11)
            {

                frameList.RemoveAt(i-1);
            }
            n = n + 1;
        }
        return frameList;

        //return a list of individual framescores, NOT cumulative

        // 18 lines here
    }
}
