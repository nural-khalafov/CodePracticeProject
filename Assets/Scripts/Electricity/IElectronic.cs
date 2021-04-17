namespace Scripts.Electricity
{
    public interface IElectronic
    {
        bool State { get; }
        int RequiredPower { get; }

        void SetPowerManagement(int power);
    }
}