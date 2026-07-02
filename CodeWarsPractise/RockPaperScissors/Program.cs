public class Kata
{
    public string Rps(string p1, string p2)
    {
        //if(p1 == p2)
        //return "Draw!";
        //else if(p2 == "scissors" && p1 == "paper" || p2 == "paper" && p1 == "rock" || p2 == "rock" && p1 == "scissors")
        //return "Player 2 won!";
        //else
        //return "Player 1 won!";
        if (p1 == p2) return "Draw!";

        else
        {
            switch (p1, p2)
            {
                case ("rock", "scissors"):
                case ("scissors", "paper"):
                case ("paper", "rock"):
                    return "Player 1 won!";

                default:
                    return "Player 2 won!";
            }
        }
    }
}