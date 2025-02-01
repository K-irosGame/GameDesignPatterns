namespace DesignPatterns.BestPractice.DIP
{
    public interface ISwitchable
    {
        public bool IsActivate { get; }
        public void Activate();
        public void Desactivate();
    }
}
