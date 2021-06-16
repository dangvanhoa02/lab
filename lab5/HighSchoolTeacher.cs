namespace lab5
{
    public class HighSchoolTeacher: AbstractTecher
    {
        public string HightSchoolCode { get; set; }

        public override double CalculateSalary()
        {
            if (Bonus > 10000)
            {
                throw new AmountException("Bonus is more than 10,000", Name);
            }
            
            var salary = BaseSalary * Level + Bonus;
            if (IsSenior && salary < 60000)
            {
                throw new AmountException("Senior Lecturer gets less than 60,000 salary", Name);
            }
            return salary;
        }
    }
}