using System;
namespace ChallengeSets
{
    public class Business
    {
        public string Name { get; set; }
        public double TotalRevenue { get; set; }
        public double TotalExpenses { get; set; }
        public Business ParentCompany { get; set; }
        public int Length { get; internal set; }
        public bool IsNotProfitable()
        {

            return TotalRevenue - TotalExpenses < 0;
        }
        public bool IsProfitable()
        {
            return TotalRevenue - TotalExpenses > 0;
        }
        internal string ToString(object p)
        {
            throw new NotImplementedException();
        }
    }
}
