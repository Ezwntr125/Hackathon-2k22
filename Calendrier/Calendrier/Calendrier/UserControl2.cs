using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendrier
{
    public partial class UserControl2 : UserControl
    {
        string connString = @"server=server2.alelix.com;userid=winter;database=winter;password=GKezyslr857*";
        public static string static_jour;

        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            
        }

        public void days(int numday)
        {
            lDay.Text = numday + "";
        }

        private void lDay_Click(object sender, EventArgs e)
        {
            static_jour = lDay.Text;
            displayEvent();
            EventForm f = new EventForm();
            f.Show();
        }

        private void displayEvent()
        {
            var conn = new MySqlConnection(connString);
            conn.Open();
            
            string sql = "SELECT descriptionTache FROM tache where dateAjoutTache = @date";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@date", Calendrier.static_annee + "/" + Calendrier.static_mois + "/" + UserControl2.static_jour);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lTache.Text = reader["descriptionTache"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            //UserControl2.Refresh();
            conn.Close(); 

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}
