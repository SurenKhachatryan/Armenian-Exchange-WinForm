
namespace Armenian_Exchange
{
    class EUR : Course, IAMD, IUSD, IRUB
    {
        public EUR()
        { }

        public EUR(double eurbuy, double eursell) : base(eurbuy: eurbuy, eursell: eursell, currency: "EUR")
        { }

        public double ToAmd(double value)
        {
            return value * Eurbuy;
        }

        public double ToRub(double value)
        {
            return (value * Eurbuy) / Rubsell;
        }

        public double ToUsd(double value)
        {
            return (value * Eurbuy) / Usdsell;
        }
    }
}
