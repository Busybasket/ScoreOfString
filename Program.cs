int ScoreOfString(string s)
{
    int score = 0;
    int letterScore = 0;
    foreach (char c in s)
    {

        if (letterScore == 0)
            letterScore = System.Convert.ToInt32(c);
        else if (letterScore == System.Convert.ToInt32(c))
        {

        }
        else
        {
            score = score + Math.Abs(letterScore - System.Convert.ToInt32(c));
            letterScore = System.Convert.ToInt32(c);
        }
    }

    return score;
}