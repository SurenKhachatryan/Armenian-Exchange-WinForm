
namespace Armenian_Exchange
{
    class RUB : Course, IAMD, IEUR, IUSD
    {
        public RUB()
        { }

        public RUB(double rubbuy, double rubsell) : base(rubbuy: rubbuy, rubsell: rubsell, currency: "RUB")
        { }

        public double ToAmd(double rubvalue)
        {
            return rubvalue * Rubbuy;
        }

        public double ToEur(double rubvalue)
        {
            return (rubvalue * Rubbuy) / Eursell;
        }

        public double ToUsd(double rubvalue)
        {
            return (rubvalue * Rubbuy) / Usdsell;
        }
    }
}
