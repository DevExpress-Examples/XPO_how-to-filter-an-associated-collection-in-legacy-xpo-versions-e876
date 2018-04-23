using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace FilteredAssociation {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            InitDal();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        private static void InitDal() {
            string conn = MSSqlConnectionProvider.GetConnectionString("(local)", "Northwind");
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(conn, AutoCreateOption.SchemaAlreadyExists);
        }
    }
}