using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LAB3_Parcial2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        ventas v = new ventas();
        string equipo = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            optTodo.Checked = true;
            cmbPlanes.Enabled = false;
            cmbPlanes.DisplayMember = "Nombre";
            cmbPlanes.ValueMember = "IdPlan";
            cmbPlanes.DataSource = v.GetPlan();
            tvwEquipos.Nodes.Clear(); // limpia los nodos colocados de ejemplo
            v.CargarTreeView(tvwEquipos);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string plan = cmbPlanes.Text;
            int eq = int.Parse(equipo);
            chtVentas.Titles.Clear();
            if (optTodo.Checked)
            {
                v.GraficarTodo(eq, chtVentas);
                txtTotal.Text = v.importe.ToString();
            }
            else
            {
                v.GraficarPorPlan(eq, plan, chtVentas);
                txtTotal.Text = v.importe.ToString();
                v.guardarArchivo(plan);
            }
        }

        private void tvwEquipos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            equipo = e.Node.Name;
        }

        private void optVentasPlan_CheckedChanged(object sender, EventArgs e)
        {
            if (optVentasPlan.Checked)
            {
                cmbPlanes.Enabled = true;
            }

        }
    }
}
