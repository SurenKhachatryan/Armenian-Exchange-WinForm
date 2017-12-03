
namespace Armenian_Exchange
{
    class AMD : Course, IUSD, IEUR, IRUB
    {
        public double ToEur(double value)
        {
            return value / Eurbuy;
        }
        public double ToRub(double value)
        {
            return value / Rubbuy;
        }
        public double ToUsd(double value)
        {
            return value / Usdbuy;
        }
    }
}
