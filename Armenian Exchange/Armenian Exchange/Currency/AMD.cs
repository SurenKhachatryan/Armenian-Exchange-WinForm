
namespace Armenian_Exchange
{
    class AMD : Course, IUSD, IEUR, IRUB
    {
        public double ToEur(double amdvalue)
        {
            return amdvalue / Eursell;
        }
        public double ToRub(double amdvalue)
        {
            return amdvalue / Rubsell;
        }
        public double ToUsd(double amdvalue)
        {
            return amdvalue / Usdsell;
        }
    }
}
