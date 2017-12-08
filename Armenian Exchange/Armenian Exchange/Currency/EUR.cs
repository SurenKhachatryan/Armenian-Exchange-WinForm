
namespace Armenian_Exchange
{
    class EUR : Course, IAMD, IUSD, IRUB
    {
        public EUR()
        { }

        public EUR(double eurbuy, double eursell) : base(eurbuy: eurbuy, eursell: eursell, currency: "EUR")
        { }

        public double ToAmd(double eurvalue)
        {
            return eurvalue * Eurbuy;
        }

        public double ToRub(double eurvalue)
        {
            return (eurvalue * Eurbuy) / Rubsell;
        }

        public double ToUsd(double eurvalue)
        {
            return (eurvalue * Eurbuy) / Usdsell;
        }
    }
}
