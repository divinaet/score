namespace MyScore.Model
{
    public class GamePlayer
    {
        public int PlayerNumber { get; set; }
        public Player Player { get; set; }
        public List<Round> Rounds { get; set; }
    }
}
