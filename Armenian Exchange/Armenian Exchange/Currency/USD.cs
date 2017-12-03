
namespace Armenian_Exchange
{
    class USD : Course, IAMD, IEUR, IRUB
    {
        public USD()
        { }

        public USD(double usdbuy, double usdsell) : base(usdbuy: usdbuy, usdsell: usdsell, currency: "USD")
        { }

        public double ToAmd(double value)
        {
            return value * Usdbuy;
        }

        public double ToRub(double value)
        {
            return (value * Usdbuy) / Rubsell;
        }

        public double ToEur(double value)
        {
            return (value * Usdbuy) / Eursell;
        }
    }
}

