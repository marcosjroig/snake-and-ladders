namespace SnakesAndLadders.Players
{
    public interface IPlayer
    {
        int CurrentPosition { get; set; }
        string Name { get; set; }
        void Move();
    }
}
