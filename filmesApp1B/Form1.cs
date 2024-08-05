using filmesApp1B.Models;
using System.Diagnostics;

namespace filmesApp1B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Contexto db;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.db = new Contexto();
            this.db.Database.EnsureCreated();
        }
    }
}
