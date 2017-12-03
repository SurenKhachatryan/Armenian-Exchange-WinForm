using System.Collections.Generic;
using System.Windows.Forms;

namespace Armenian_Exchange
{
    class Course
    {
        private static double usdbuy;
        private static double usdsell;
        private static double rubbuy;
        private static double rubsell;
        private static double eurbuy;
        private static double eursell;
        private static List<double> courselist = new List<double>();

        public static List<double> CourseList { get { return courselist; } }

        protected static double Usdbuy
        {
            get { return usdbuy; }
            private set
            {
                if (value >= 300.00 && value <= 999.99)
                {
                    usdbuy = value;
                }
                else
                {
                    MessageBox.Show("Minimum Course 300.00 AMD Maximum 999.99 AMD");
                }
            }
        }

        protected static double Usdsell
        {
            get { return usdsell; }
            private set
            {
                if (value >= 300.00 && value <= 999.99)
                {
                    usdsell = value;
                }
                else
                {
                    MessageBox.Show("Minimum Course 300.00 AMD Maximum 999.99 AMD");
                }
            }
        }

        protected static double Rubbuy
        {
            get { return rubbuy; }
            private set
            {
                if (value >= 4.00 && value <= 30.00)
                {
                    rubbuy = value;
                }
                else
                {
                    MessageBox.Show("Minimum Course 4.00 AMD Maximum 30.00 AMD");
                }
            }
        }

        protected static double Rubsell
        {
            get { return rubsell; }

            private set
            {
                if (value >= 4.00 && value <= 30.00)
                {
                    rubsell = value;
                }
                else
                {
                    MessageBox.Show("Minimum Course 4.00 AMD Maximum 30.00 AMD");
                }
            }
        }

        protected static double Eurbuy
        {
            get { return eurbuy; }

            private set
            {
                if (value >= 400.00 && value <= 999.99)
                {
                    eurbuy = value;
                }
                else
                {
                    MessageBox.Show("Minimum Course 400.00 AMD Maximum 999.99 AMD");
                }
            }
        }

        protected static double Eursell
        {
            get { return eursell; }

            private set
            {
                if (value >= 400.00 && value <= 999.99)
                {
                    eursell = value;
                }
                else
                {
                    MessageBox.Show("Minimum Course 400.00 AMD Maximum 999.99 AMD");
                }
            }
        }

        static Course()
        {
            AddListCourse(483.10, 485.60, 8.09, 8.40, 576.50, 570, "ALL");
        }

        public Course()
        {

        }
        public Course(double usdbuy, double usdsell,
                      double rubbuy, double rubsell,
                      double eurbuy, double eursell) :
                 this(usdbuy, usdsell, rubbuy, rubsell,
                      eurbuy, eursell, "ALL")
        {
        }

        protected Course(double usdbuy = 483.10, double usdsell = 485.60,
                         double rubbuy = 8.09, double rubsell = 8.40,
                         double eurbuy = 576.50, double eursell = 570,
                         string currency = "ALL")
        {
            AddListCourse(usdbuy, usdsell, rubbuy, rubsell, eurbuy, eursell, currency);
        }

        private static void AddListCourse(double usdbuy, double usdsell,
                                          double rubbuy, double rubsell,
                                          double eurbuy, double eursell,
                                          string currency)
        {
            if (currency == "ALL" || currency == "USD")
            {
                if (courselist.Count == 0)
                {
                    courselist.Add((Usdbuy = usdbuy));
                    courselist.Add((Usdsell = usdsell));
                }
                else
                {
                    Usdbuy = usdbuy;
                    Usdsell = usdsell;
                    courselist[0] = Usdbuy;
                    courselist[1] = Usdsell;
                }
            }
            if (currency == "ALL" || currency == "RUB")
            {
                if (courselist.Count == 2)
                {
                    courselist.Add((Rubbuy = rubbuy));
                    courselist.Add((Rubsell = rubsell));
                }
                else
                {
                    Rubbuy = rubbuy;
                    Rubsell = rubsell;
                    courselist[2] = Rubbuy;
                    courselist[3] = Rubsell;
                }
            }
            if (currency == "ALL" || currency == "EUR")
            {
                if (courselist.Count == 4)
                {
                    courselist.Add((Eurbuy = eurbuy));
                    courselist.Add((Eursell = eursell));
                }
                else
                {
                    Eurbuy = eurbuy;
                    Eursell = eursell;
                    courselist[4] = Eurbuy;
                    courselist[5] = Eursell;
                }

            }
        }
    }

}
