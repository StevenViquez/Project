namespace GUI
{
    partial class FrmPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabTrabajos = new System.Windows.Forms.TabPage();
            this.tabGastos = new System.Windows.Forms.TabPage();
            this.tabEmpleados = new System.Windows.Forms.TabPage();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMantenimiento});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(870, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuMantenimiento
            // 
            this.menuMantenimiento.Name = "menuMantenimiento";
            this.menuMantenimiento.Size = new System.Drawing.Size(101, 20);
            this.menuMantenimiento.Text = "Mantenimiento";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabPrincipal);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer1.Size = new System.Drawing.Size(870, 446);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabTrabajos);
            this.tabPrincipal.Controls.Add(this.tabGastos);
            this.tabPrincipal.Controls.Add(this.tabEmpleados);
            this.tabPrincipal.Location = new System.Drawing.Point(3, 3);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(284, 443);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabTrabajos
            // 
            this.tabTrabajos.Location = new System.Drawing.Point(4, 22);
            this.tabTrabajos.Name = "tabTrabajos";
            this.tabTrabajos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrabajos.Size = new System.Drawing.Size(276, 417);
            this.tabTrabajos.TabIndex = 0;
            this.tabTrabajos.Text = "Trabajos";
            this.tabTrabajos.UseVisualStyleBackColor = true;
            // 
            // tabGastos
            // 
            this.tabGastos.Location = new System.Drawing.Point(4, 22);
            this.tabGastos.Name = "tabGastos";
            this.tabGastos.Padding = new System.Windows.Forms.Padding(3);
            this.tabGastos.Size = new System.Drawing.Size(276, 417);
            this.tabGastos.TabIndex = 1;
            this.tabGastos.Text = "Gastos";
            this.tabGastos.UseVisualStyleBackColor = true;
            // 
            // tabEmpleados
            // 
            this.tabEmpleados.Location = new System.Drawing.Point(4, 22);
            this.tabEmpleados.Name = "tabEmpleados";
            this.tabEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpleados.Size = new System.Drawing.Size(276, 417);
            this.tabEmpleados.TabIndex = 2;
            this.tabEmpleados.Text = "Empleados";
            this.tabEmpleados.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 470);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "Cuckoo";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuMantenimiento;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabTrabajos;
        private System.Windows.Forms.TabPage tabGastos;
        private System.Windows.Forms.TabPage tabEmpleados;
    }
}