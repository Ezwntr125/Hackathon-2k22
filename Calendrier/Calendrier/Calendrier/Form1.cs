using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendrier
{
    public partial class Calendrier : Form
    {
        int mois, annee;
        public static int static_mois, static_annee;
        public Calendrier()
        {
            InitializeComponent();
        }

        private void Calendrier_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            mois = now.Month;
            annee = now.Year;
            DateTime startofthemonth = new DateTime(annee, mois, 1);
            int days = DateTime.DaysInMonth(annee, mois);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            String montname = DateTimeFormatInfo.CurrentInfo.GetMonthName(mois);
            ltitre.Text = montname + " " + annee;

            static_mois = mois;
            static_annee = annee;

            for (int i = 1; i< daysoftheweek; i++)
            {
                UserControl1 ucblank = new UserControl1();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControl2 ucdays = new UserControl2();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);

            }
            
        }

        private void bPrecedent_Click(object sender, EventArgs e)
        {

            daycontainer.Controls.Clear();
            mois--;
            String montname = DateTimeFormatInfo.CurrentInfo.GetMonthName(mois);
            ltitre.Text = montname + " " + annee;
            DateTime startofthemonth = new DateTime(annee, mois, 1);
            int days = DateTime.DaysInMonth(annee, mois);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            static_mois = mois;
            static_annee = annee;
            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControl1 ucblank = new UserControl1();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControl2 ucdays = new UserControl2();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void bSuivant_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            mois++;
            String montname = DateTimeFormatInfo.CurrentInfo.GetMonthName(mois);
            ltitre.Text = montname + " " + annee;
            DateTime startofthemonth = new DateTime(annee, mois, 1);
            int days = DateTime.DaysInMonth(annee, mois);
            int daysoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControl1 ucblank = new UserControl1();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControl2 ucdays = new UserControl2();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);

            }
        }
    }
}
