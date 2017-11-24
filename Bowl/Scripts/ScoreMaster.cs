using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreMaster {
    
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
        List<int> frames = new List<int>();

        //Index i points to second bowl of frame
        for (int i = 1; i < rolls.Count; i += 2)                    
        {
            if (frames.Count == 10) { break; }                        // Prevents 11th frame score

            if (rolls[i - 1] + rolls[i] < 10)
            {                                                         // Normal OPEN frame
                frames.Add(rolls[i - 1] + rolls[i]);
            }

            if (rolls.Count - i <= 1) { break; }                     // Ensure at least one look-ahead

            if (rolls[i - 1] == 10)
            {                                                       // STRIKE
                i--;                                                // Strike frame has just one bowl
                frames.Add(10 + rolls[i + 1] + rolls[i + 2]);
            }
            else if (rolls[i - 1] + rolls[i] == 10)
            {                                                       // Calculate SPARE bonus
                frames.Add(10 + rolls[i + 1]);
            }
        }
        return frames;
    }
}
