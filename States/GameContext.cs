namespace Labirint.States
{
    public class GameContext
    {
        public IState State { get; set; }

        public GameContext(IState state)
        {
            State = state;
        }

        public void HandleState(Player player)
        {
            State.Interact(this, player);
        }
    }
}