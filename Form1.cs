using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campo_Minato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("minefield.ico");

            this.BackColor = Color.Green;//da cambiare

            //da aggiungere qua il cod per aprire Form per impostazione difficoltà   <------

            //prepara di dgv
            PreparaDgv();

        }

        void PreparaDgv()
        {
            //setta il colore delle celle alternato
            int xLung = 10;
            int yLung = 10;

            int difficolta; //1->Facile, 2-> Medio, 3-> Difficile

            difficolta = 1; //da togliere

            int cell = 20;
            switch (difficolta) 
            {
                case 1:
                    cell = 30;
                    xLung = 10;
                    yLung = 10;
                    break;
                case 2:
                    cell = 30;
                    xLung = 15;
                    yLung = 15;
                    break;
                case 3:
                    cell = 25;
                    xLung = 20;
                    yLung = 20;
                    break;
            }

            dgv_scheda.RowCount = yLung;
            dgv_scheda.ColumnCount = xLung;

            dgv_scheda.Width = xLung * cell;
            dgv_scheda.Height = yLung * cell;

            this.Width = dgv_scheda.Width + 50;
            this.Height = dgv_scheda.Height + 50;

            dgv_scheda.Location = new Point((this.ClientSize.Width - dgv_scheda.Width) / 2, (this.ClientSize.Height - dgv_scheda.Height) / 2);

            for (int i = 0; i < xLung; i++)
            {
                dgv_scheda.Rows[i].Height = cell;
                for (int j = 0; j < yLung; j++)
                {
                    dgv_scheda.Columns[i].Width = cell;
                    if ((i + j) % 2 == 0)
                    {
                        dgv_scheda.Rows[i].Cells[j].Style.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        dgv_scheda.Rows[i].Cells[j].Style.BackColor = Color.LawnGreen;
                    }
                }
            }
        }
    }
}
