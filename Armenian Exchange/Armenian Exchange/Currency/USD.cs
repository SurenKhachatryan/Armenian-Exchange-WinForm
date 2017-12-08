
namespace Armenian_Exchange
{
    class USD : Course, IAMD, IEUR, IRUB
    {
        public USD()
        { }

        public USD(double usdbuy, double usdsell) : base(usdbuy: usdbuy, usdsell: usdsell, currency: "USD")
        { }

        public double ToAmd(double usdvalue)
        {
            return usdvalue * Usdbuy;
        }

        public double ToRub(double usdvalue)
        {
            return (usdvalue * Usdbuy) / Rubsell;
        }

        public double ToEur(double usdvalue)
        {
            return (usdvalue * Usdbuy) / Eursell;
        }
    }
}

