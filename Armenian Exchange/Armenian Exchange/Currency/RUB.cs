
namespace Armenian_Exchange
{
    class RUB : Course, IAMD, IEUR, IUSD
    {
        public RUB()
        { }

        public RUB(double rubbuy, double rubsell) : base(rubbuy: rubbuy, rubsell: rubsell, currency: "RUB")
        { }

        public double ToAmd(double value)
        {
            return value * Rubbuy;
        }

        public double ToEur(double value)
        {
            return (value * Rubbuy) / Eursell;
        }

        public double ToUsd(double value)
        {
            return (value * Rubbuy) / Usdsell;
        }
    }
}
