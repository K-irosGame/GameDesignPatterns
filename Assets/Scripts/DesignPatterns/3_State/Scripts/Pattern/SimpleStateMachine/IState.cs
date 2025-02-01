
namespace DesignPatterns.StatePattern
{
    // Interface repr�sentant un �tat
    public interface IState 
    {
        public void Enter();
        public void Update();
        public void Exit();
    }
}
