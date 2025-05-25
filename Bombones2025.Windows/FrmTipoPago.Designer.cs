namespace Bombones2025.Windows
{
    partial class FrmTipoPago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            dgvDatosPago = new DataGridView();
            TxtCantidadPaginasPago = new TextBox();
            CboPaginasPago = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            BtnUltimo = new Button();
            BtnSiguiente = new Button();
            BtnAnterior = new Button();
            BtnPrimero = new Button();
            toolStrip1 = new ToolStrip();
            TsbNuevoPago = new ToolStripButton();
            TsbBorrarPago = new ToolStripButton();
            TsbEditarPago = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            TsbFiltrarPago = new ToolStripButton();
            TsbActualizarPago = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            TsbImprimirPago = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            TsbCerrarPago = new ToolStripButton();
            colId = new DataGridViewTextBoxColumn();
            colPago = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosPago).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 62);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatosPago);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtCantidadPaginasPago);
            splitContainer1.Panel2.Controls.Add(CboPaginasPago);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(BtnUltimo);
            splitContainer1.Panel2.Controls.Add(BtnSiguiente);
            splitContainer1.Panel2.Controls.Add(BtnAnterior);
            splitContainer1.Panel2.Controls.Add(BtnPrimero);
            splitContainer1.Size = new Size(800, 388);
            splitContainer1.SplitterDistance = 310;
            splitContainer1.TabIndex = 7;
            // 
            // dgvDatosPago
            // 
            dgvDatosPago.AllowUserToAddRows = false;
            dgvDatosPago.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatosPago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatosPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosPago.Columns.AddRange(new DataGridViewColumn[] { colId, colPago });
            dgvDatosPago.Dock = DockStyle.Fill;
            dgvDatosPago.Location = new Point(0, 0);
            dgvDatosPago.Name = "dgvDatosPago";
            dgvDatosPago.ReadOnly = true;
            dgvDatosPago.RowHeadersVisible = false;
            dgvDatosPago.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatosPago.Size = new Size(800, 310);
            dgvDatosPago.TabIndex = 2;
            // 
            // TxtCantidadPaginasPago
            // 
            TxtCantidadPaginasPago.Location = new Point(176, 38);
            TxtCantidadPaginasPago.Name = "TxtCantidadPaginasPago";
            TxtCantidadPaginasPago.ReadOnly = true;
            TxtCantidadPaginasPago.Size = new Size(85, 23);
            TxtCantidadPaginasPago.TabIndex = 19;
            // 
            // CboPaginasPago
            // 
            CboPaginasPago.DropDownStyle = ComboBoxStyle.DropDownList;
            CboPaginasPago.FormattingEnabled = true;
            CboPaginasPago.Location = new Point(73, 38);
            CboPaginasPago.Name = "CboPaginasPago";
            CboPaginasPago.Size = new Size(68, 23);
            CboPaginasPago.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 41);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 16;
            label2.Text = "de:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 41);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 17;
            label1.Text = "Pág.:";
            // 
            // BtnUltimo
            // 
            BtnUltimo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnUltimo.Image = Properties.Resources.last_24px;
            BtnUltimo.Location = new Point(1341, 33);
            BtnUltimo.Name = "BtnUltimo";
            BtnUltimo.Size = new Size(75, 41);
            BtnUltimo.TabIndex = 12;
            BtnUltimo.UseVisualStyleBackColor = true;
            // 
            // BtnSiguiente
            // 
            BtnSiguiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSiguiente.Image = Properties.Resources.next_24px;
            BtnSiguiente.Location = new Point(1260, 33);
            BtnSiguiente.Name = "BtnSiguiente";
            BtnSiguiente.Size = new Size(75, 41);
            BtnSiguiente.TabIndex = 13;
            BtnSiguiente.UseVisualStyleBackColor = true;
            // 
            // BtnAnterior
            // 
            BtnAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAnterior.Image = Properties.Resources.previous_24px;
            BtnAnterior.Location = new Point(1179, 33);
            BtnAnterior.Name = "BtnAnterior";
            BtnAnterior.Size = new Size(75, 41);
            BtnAnterior.TabIndex = 14;
            BtnAnterior.UseVisualStyleBackColor = true;
            // 
            // BtnPrimero
            // 
            BtnPrimero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnPrimero.Image = Properties.Resources.first_24px;
            BtnPrimero.Location = new Point(1098, 33);
            BtnPrimero.Name = "BtnPrimero";
            BtnPrimero.Size = new Size(75, 41);
            BtnPrimero.TabIndex = 15;
            BtnPrimero.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsbNuevoPago, TsbBorrarPago, TsbEditarPago, toolStripSeparator1, TsbFiltrarPago, TsbActualizarPago, toolStripSeparator2, TsbImprimirPago, toolStripSeparator3, TsbCerrarPago });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 62);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // TsbNuevoPago
            // 
            TsbNuevoPago.Image = Properties.Resources.Nuevo;
            TsbNuevoPago.ImageScaling = ToolStripItemImageScaling.None;
            TsbNuevoPago.ImageTransparentColor = Color.Magenta;
            TsbNuevoPago.Name = "TsbNuevoPago";
            TsbNuevoPago.Size = new Size(46, 59);
            TsbNuevoPago.Text = "Nuevo";
            TsbNuevoPago.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbNuevoPago.Click += TsbNuevoPago_Click;
            // 
            // TsbBorrarPago
            // 
            TsbBorrarPago.Image = Properties.Resources.Delete;
            TsbBorrarPago.ImageScaling = ToolStripItemImageScaling.None;
            TsbBorrarPago.ImageTransparentColor = Color.Magenta;
            TsbBorrarPago.Name = "TsbBorrarPago";
            TsbBorrarPago.Size = new Size(44, 59);
            TsbBorrarPago.Text = "Borrar";
            TsbBorrarPago.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbBorrarPago.Click += TsbBorrarPago_Click;
            // 
            // TsbEditarPago
            // 
            TsbEditarPago.Image = Properties.Resources.Edit;
            TsbEditarPago.ImageScaling = ToolStripItemImageScaling.None;
            TsbEditarPago.ImageTransparentColor = Color.Magenta;
            TsbEditarPago.Name = "TsbEditarPago";
            TsbEditarPago.Size = new Size(44, 59);
            TsbEditarPago.Text = "Editar";
            TsbEditarPago.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbEditarPago.Click += TsbEditarPago_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
            // 
            // TsbFiltrarPago
            // 
            TsbFiltrarPago.Image = Properties.Resources.filter_40px;
            TsbFiltrarPago.ImageScaling = ToolStripItemImageScaling.None;
            TsbFiltrarPago.ImageTransparentColor = Color.Magenta;
            TsbFiltrarPago.Name = "TsbFiltrarPago";
            TsbFiltrarPago.Size = new Size(44, 59);
            TsbFiltrarPago.Text = "Filtrar";
            TsbFiltrarPago.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbFiltrarPago.Click += TsbFiltrarPago_Click;
            // 
            // TsbActualizarPago
            // 
            TsbActualizarPago.Image = Properties.Resources.Update;
            TsbActualizarPago.ImageScaling = ToolStripItemImageScaling.None;
            TsbActualizarPago.ImageTransparentColor = Color.Magenta;
            TsbActualizarPago.Name = "TsbActualizarPago";
            TsbActualizarPago.Size = new Size(63, 59);
            TsbActualizarPago.Text = "Actualizar";
            TsbActualizarPago.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 62);
            // 
            // TsbImprimirPago
            // 
            TsbImprimirPago.Image = Properties.Resources.Print;
            TsbImprimirPago.ImageScaling = ToolStripItemImageScaling.None;
            TsbImprimirPago.ImageTransparentColor = Color.Magenta;
            TsbImprimirPago.Name = "TsbImprimirPago";
            TsbImprimirPago.Size = new Size(57, 59);
            TsbImprimirPago.Text = "Imprimir";
            TsbImprimirPago.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 62);
            // 
            // TsbCerrarPago
            // 
            TsbCerrarPago.Image = Properties.Resources.Close;
            TsbCerrarPago.ImageScaling = ToolStripItemImageScaling.None;
            TsbCerrarPago.ImageTransparentColor = Color.Magenta;
            TsbCerrarPago.Name = "TsbCerrarPago";
            TsbCerrarPago.Size = new Size(44, 59);
            TsbCerrarPago.Text = "Cerrar";
            TsbCerrarPago.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbCerrarPago.Click += TsbCerrarPago_Click;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colPago
            // 
            colPago.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPago.HeaderText = "Forma de Pago";
            colPago.Name = "colPago";
            colPago.ReadOnly = true;
            // 
            // FrmTipoPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "FrmTipoPago";
            Text = "FrmTipoPago";
            Load += FrmTipoPago_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatosPago).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvDatosPago;
        private TextBox TxtCantidadPaginasPago;
        private ComboBox CboPaginasPago;
        private Label label2;
        private Label label1;
        private Button BtnUltimo;
        private Button BtnSiguiente;
        private Button BtnAnterior;
        private Button BtnPrimero;
        private ToolStrip toolStrip1;
        private ToolStripButton TsbNuevoPago;
        private ToolStripButton TsbBorrarPago;
        private ToolStripButton TsbEditarPago;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TsbFiltrarPago;
        private ToolStripButton TsbActualizarPago;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton TsbImprimirPago;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton TsbCerrarPago;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colPago;
    }
}