namespace lab5
{
    public abstract class AbstractTecher
    {
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public int BaseSalary { get; set; }
        public int Level { get; set; }
        public bool IsSenior { get; set; }
        public double Bonus { get; set; }

        public abstract double CalculateSalary();
    }
}