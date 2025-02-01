
namespace DesignPatterns.StatePattern
{
    // Interface représentant un état
    public interface IState 
    {
        public void Enter();
        public void Update();
        public void Exit();
    }
}
