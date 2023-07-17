public class ElfHealth : IHealthStat
{
    private IHealthStat _healthStat;
    private int _healMultipier;

    public ElfHealth(IHealthStat healthStat, int healMultipier)
    {
        //провекра
        _healthStat = healthStat;
        _healMultipier = healMultipier;
    }

    public int MaxHealth => _healthStat.MaxHealth;

    public int Value => _healthStat.Value;

    public void Add(int value)
    {
        value *= _healMultipier;

        _healthStat.Add(value);
    }

    public void Reduce(int value) => _healthStat.Reduce(value); 
}
