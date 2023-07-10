namespace LAB3_Parcial2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("FM");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Camara Doble");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Equipo 1", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Equipo 2");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Equipos", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.tvwEquipos = new System.Windows.Forms.TreeView();
            this.imgEquipos = new System.Windows.Forms.ImageList(this.components);
            this.optTodo = new System.Windows.Forms.RadioButton();
            this.optVentasPlan = new System.Windows.Forms.RadioButton();
            this.cmbPlanes = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.chtVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipos";
            // 
            // tvwEquipos
            // 
            this.tvwEquipos.ImageIndex = 0;
            this.tvwEquipos.ImageList = this.imgEquipos;
            this.tvwEquipos.Location = new System.Drawing.Point(12, 43);
            this.tvwEquipos.Name = "tvwEquipos";
            treeNode6.ImageIndex = 3;
            treeNode6.Name = "Nodo2";
            treeNode6.Text = "FM";
            treeNode7.ImageIndex = 3;
            treeNode7.Name = "Nodo3";
            treeNode7.Text = "Camara Doble";
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "Nodo1";
            treeNode8.Text = "Equipo 1";
            treeNode9.ImageIndex = 1;
            treeNode9.Name = "Nodo4";
            treeNode9.Text = "Equipo 2";
            treeNode10.ImageIndex = 2;
            treeNode10.Name = "Nodo0";
            treeNode10.Text = "Equipos";
            this.tvwEquipos.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.tvwEquipos.SelectedImageIndex = 0;
            this.tvwEquipos.Size = new System.Drawing.Size(165, 448);
            this.tvwEquipos.TabIndex = 1;
            this.tvwEquipos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwEquipos_AfterSelect);
            // 
            // imgEquipos
            // 
            this.imgEquipos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgEquipos.ImageStream")));
            this.imgEquipos.TransparentColor = System.Drawing.Color.Transparent;
            this.imgEquipos.Images.SetKeyName(0, "carpeta1.png");
            this.imgEquipos.Images.SetKeyName(1, "carpeta2.png");
            this.imgEquipos.Images.SetKeyName(2, "carpeta3.png");
            this.imgEquipos.Images.SetKeyName(3, "salir.png");
            // 
            // optTodo
            // 
            this.optTodo.AutoSize = true;
            this.optTodo.Location = new System.Drawing.Point(222, 27);
            this.optTodo.Name = "optTodo";
            this.optTodo.Size = new System.Drawing.Size(107, 17);
            this.optTodo.TabIndex = 2;
            this.optTodo.TabStop = true;
            this.optTodo.Text = "Todas las Ventas";
            this.optTodo.UseVisualStyleBackColor = true;
            // 
            // optVentasPlan
            // 
            this.optVentasPlan.AutoSize = true;
            this.optVentasPlan.Location = new System.Drawing.Point(366, 27);
            this.optVentasPlan.Name = "optVentasPlan";
            this.optVentasPlan.Size = new System.Drawing.Size(100, 17);
            this.optVentasPlan.TabIndex = 3;
            this.optVentasPlan.TabStop = true;
            this.optVentasPlan.Text = "Ventas por Plan";
            this.optVentasPlan.UseVisualStyleBackColor = true;
            this.optVentasPlan.CheckedChanged += new System.EventHandler(this.optVentasPlan_CheckedChanged);
            // 
            // cmbPlanes
            // 
            this.cmbPlanes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanes.FormattingEnabled = true;
            this.cmbPlanes.Location = new System.Drawing.Point(474, 24);
            this.cmbPlanes.Name = "cmbPlanes";
            this.cmbPlanes.Size = new System.Drawing.Size(145, 21);
            this.cmbPlanes.TabIndex = 4;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(688, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 42);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // chtVentas
            // 
            chartArea2.Name = "ChartArea1";
            this.chtVentas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtVentas.Legends.Add(legend2);
            this.chtVentas.Location = new System.Drawing.Point(199, 67);
            this.chtVentas.Name = "chtVentas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtVentas.Series.Add(series2);
            this.chtVentas.Size = new System.Drawing.Size(579, 381);
            this.chtVentas.TabIndex = 6;
            this.chtVentas.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Importe Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(678, 464);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chtVentas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cmbPlanes);
            this.Controls.Add(this.optVentasPlan);
            this.Controls.Add(this.optTodo);
            this.Controls.Add(this.tvwEquipos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Consultas de Ventas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvwEquipos;
        private System.Windows.Forms.RadioButton optTodo;
        private System.Windows.Forms.RadioButton optVentasPlan;
        private System.Windows.Forms.ComboBox cmbPlanes;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ImageList imgEquipos;
    }
}

