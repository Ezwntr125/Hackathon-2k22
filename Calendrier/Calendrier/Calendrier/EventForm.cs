using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Calendrier
{
    public partial class EventForm : Form
    {
        string connString = @"server=server2.alelix.com;userid=winter;database=winter;password=GKezyslr857*";
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            tbDate.Text = Calendrier.static_annee + "/" + Calendrier.static_mois + "/" + UserControl2.static_jour;
            
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            var conn = new MySqlConnection(connString);
            conn.Open();
            String sql = "INSERT INTO tache (dateAjoutTache,descriptionTache)values(@date,@description)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@date", tbDate.Text);
            cmd.Parameters.AddWithValue("@description", tbTache.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Enregistré avec succès !");
            cmd.Dispose();
            conn.Close();

        }
    }
}
