using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace LAB3_Parcial2
{
    public class ventas
    {
        DataSet DS;
        public int importe;
        public ventas()
        {
            try
            {
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Moviles.mdb";
                cnn.Open();
                DS = new DataSet();
                OleDbCommand cmdV = new OleDbCommand();
                cmdV.Connection = cnn;
                cmdV.CommandType = CommandType.TableDirect;
                cmdV.CommandText = "Ventas";
                OleDbDataAdapter DAV = new OleDbDataAdapter(cmdV);
                DAV.Fill(DS, "Ventas");
                DataColumn[] pkV = new DataColumn[1];
                pkV[0] = DS.Tables["Ventas"].Columns["IdVenta"];
                DS.Tables["Ventas"].PrimaryKey = pkV;
                OleDbCommandBuilder cb = new OleDbCommandBuilder(DAV);
                //
                OleDbCommand cmdP = new OleDbCommand();
                cmdP.Connection = cnn;
                cmdP.CommandType = CommandType.TableDirect;
                cmdP.CommandText = "Planes";
                OleDbDataAdapter DAP = new OleDbDataAdapter(cmdP);
                DAP.Fill(DS, "Planes");
                DataColumn[] pkP = new DataColumn[1];
                pkP[0] = DS.Tables["Planes"].Columns["IdPlan"];
                DS.Tables["Planes"].PrimaryKey = pkP;
                OleDbCommandBuilder cbP = new OleDbCommandBuilder(DAP);
                //
                OleDbCommand cmdE = new OleDbCommand();
                cmdE.Connection = cnn;
                cmdE.CommandType = CommandType.TableDirect;
                cmdE.CommandText = "Equipos";
                OleDbDataAdapter DAE = new OleDbDataAdapter(cmdE);
                DAE.Fill(DS, "Equipos");
                DataColumn[] pkE = new DataColumn[1];
                pkE[0] = DS.Tables["Equipos"].Columns["IdEquipo"];
                DS.Tables["Equipos"].PrimaryKey = pkE;
                OleDbCommandBuilder cbE = new OleDbCommandBuilder(DAE);
                cnn.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Ventas: " + ex.Message);
            }
        }
        public void CargarTreeView(TreeView tvw)
        {
            tvw.Nodes.Clear();
            // agregar la raiz
            TreeNode raiz = tvw.Nodes.Add("raiz", "Equipos");
            try
            {
                foreach (DataRow drE in DS.Tables["Equipos"].Rows)
                {
                    TreeNode equipos = raiz.Nodes.Add(drE["IdEquipo"].ToString(), drE["MarcaModelo"].ToString());

                    if ((bool)drE["FM"] == true)
                    {                            
                        equipos.Nodes.Add(drE["IdEquipo"].ToString(), "FM");
                    }
                    if ((bool)drE["CamaraDoble"] == true)
                    {                        
                        equipos.Nodes.Add(drE["IdEquipo"].ToString(), "CamaraDoble");
                    }
                    if ((bool)drE["Bluetooth"] == true)
                    {                        
                        equipos.Nodes.Add(drE["IdEquipo"].ToString(), "Bluetooth");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ventas: " + ex.Message);
            }

        }

        public void GraficarTodo(int equipo, Chart cht)
        {
            try
            {
                importe = 0;
                cht.Visible = true;
                cht.Series.Clear();
                cht.Titles.Add("Todas las ventas");
                // crear una tabla temporal
                DataTable tb = new DataTable();
                tb.Columns.Add("IdVenta");
                tb.Columns.Add("Fecha");
                tb.Columns.Add("IdEquipo");
                tb.Columns.Add("Plan");
                tb.Columns.Add("Importe");
                
                foreach (DataRow dr in DS.Tables["Ventas"].Rows)
                {
                    
                    if (equipo == int.Parse(dr["IdEquipo"].ToString()))
                    {
                        // se agrega el registro nuevo a la tabla temporal
                        DataRow nuevo = tb.NewRow();
                        nuevo["IdVenta"] = int.Parse(dr["IdVenta"].ToString());
                        nuevo["Fecha"] = dr["Fecha"].ToString();
                        nuevo["IdEquipo"] = int.Parse(dr["IdEquipo"].ToString());
                        nuevo["Plan"] = dr["Plan"].ToString();
                        nuevo["Importe"] = int.Parse(dr["Importe"].ToString());

                        tb.Rows.Add(nuevo);
                        importe += int.Parse(dr["Importe"].ToString());
                    }
                }
                // Crear una nueva serie en el control Chart
                Series serie = cht.Series.Add(equipo.ToString());
                serie.ChartType = SeriesChartType.Column; // tipo de grafico = columnas
                serie.YValueMembers = "Importe"; // Establecer los valores en el eje Y de la serie
                serie.XValueMember = "IdVenta"; // Establecer los valores en el eje X de la serie
                cht.Series[0].IsValueShownAsLabel = true;

                // Enlazar la tabla temporal al control Chart
                cht.DataSource = tb.DefaultView;

                // Establecer título del eje Y
                cht.ChartAreas[0].AxisY.Title = "Importes ($)";
                // Establecer título del eje X
                cht.ChartAreas[0].AxisX.Title = "IdVenta";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void GraficarPorPlan(int equipo, string plan, Chart cht)
        {
            try
            {
                importe = 0;
                cht.Visible = true;
                cht.Series.Clear();
                cht.Titles.Add("Ventas por Plan");
                // crear una tabla temporal
                DataTable tb = new DataTable();
                tb.Columns.Add("IdVenta");
                tb.Columns.Add("Fecha");
                tb.Columns.Add("IdEquipo");
                tb.Columns.Add("Plan");
                tb.Columns.Add("Importe");

                foreach (DataRow dr in DS.Tables["Ventas"].Rows)
                {

                    if (equipo == int.Parse(dr["IdEquipo"].ToString()) && plan == dr["Plan"].ToString())
                    {
                        // se agrega el registro nuevo a la tabla temporal
                        DataRow nuevo = tb.NewRow();
                        nuevo["IdVenta"] = int.Parse(dr["IdVenta"].ToString());
                        nuevo["Fecha"] = dr["Fecha"].ToString();
                        nuevo["IdEquipo"] = int.Parse(dr["IdEquipo"].ToString());
                        nuevo["Plan"] = dr["Plan"].ToString();
                        nuevo["Importe"] = int.Parse(dr["Importe"].ToString());

                        tb.Rows.Add(nuevo);
                        importe += int.Parse(dr["Importe"].ToString());
                    }
                }
                // Crear una nueva serie en el control Chart
                Series serie = cht.Series.Add(equipo.ToString());
                serie.ChartType = SeriesChartType.Column; // tipo de grafico = columnas
                serie.YValueMembers = "Importe"; // Establecer los valores en el eje Y de la serie
                serie.XValueMember = "IdVenta"; // Establecer los valores en el eje X de la serie
                cht.Series[0].IsValueShownAsLabel = true;

                // Enlazar la tabla temporal al control Chart
                cht.DataSource = tb.DefaultView;

                // Establecer título del eje Y
                cht.ChartAreas[0].AxisY.Title = "Importes ($)";
                // Establecer título del eje X
                cht.ChartAreas[0].AxisX.Title = "IdVenta";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void guardarArchivo(string plan)
        {
            int importe = 0;
            string venta= "";
            StreamWriter sw = new StreamWriter("Consulta.txt", true);
            sw.Write(plan + ",");
            foreach(DataRow dr in DS.Tables["Ventas"].Rows)
            {
                if(plan == dr["Plan"].ToString())
                {
                    if (int.Parse(dr["Importe"].ToString()) > importe){
                        importe = int.Parse(dr["Importe"].ToString());
                        venta = dr["IdVenta"].ToString();
                    }
                }
            }
            sw.Write(venta + ",");
            sw.WriteLine(importe.ToString());
            sw.Close();
            sw.Dispose();
        }
        public DataTable GetPlan()
        {
            if (DS.Tables.Count == 3)
            {
                return DS.Tables["Planes"];
            }
            else
            {
                throw new Exception("La tabla no existe");
            }
        }
    }
}
