﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
      
        }
    }

    public class Chanson
    {

        private string _nomArtiste;
        private string _TitreChanson;

        public string NomArtiste
        {
            get { return _nomArtiste; }
            set { _nomArtiste = value; }
        }

        public string TitreChanson
        {
            get { return _TitreChanson; }
            set { _TitreChanson = value; }
        }
       public  Chanson(string aTitreChanson, string aNomArtiste)
        {
            this.TitreChanson = aTitreChanson;
            this.NomArtiste = aNomArtiste;
        }
    }
}
