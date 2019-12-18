using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             Chanson Chanson1 = new Chanson("Teste moi", "Testeur");
            Chanson Chanson2 = new Chanson("Et moi aussi", "Testeur");
            Chanson Chanson3 = new Chanson("Mais moi pas", "UnAutreType");
            List<Chanson> listeArtiste = new List<Chanson>();
            listeArtiste.Add(Chanson1);
            listeArtiste.Add(Chanson2);
            listeArtiste.Add(Chanson3);
            DataTable tableVue = new DataTable();
            tableVue.Columns.Add("Titre");
            tableVue.Columns.Add("Artiste");
           for (int i = 0; i<listeArtiste.Count; i++)
            {
               DataRow row = tableVue.NewRow();
                row["Titre"] = listeArtiste[i].TitreChanson;
                row["Artiste"] = listeArtiste[i].NomArtiste;
                tableVue.Rows.Add(row);
            }
            DataView dataView = new DataView(tableVue, "Artiste = 'Testeur'", "", DataViewRowState.CurrentRows);
            dataGridView1.DataSource = dataView;
           
        }
    }

}
