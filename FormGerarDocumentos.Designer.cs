namespace Advocacia_Dias_Pereira
{
    partial class FormGerarDocumentos
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
            this.txtMatriculaDependente = new System.Windows.Forms.TextBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // txtMatriculaDependente
            // 
            this.txtMatriculaDependente.Location = new System.Drawing.Point(431, 192);
            this.txtMatriculaDependente.Name = "txtMatriculaDependente";
            this.txtMatriculaDependente.Size = new System.Drawing.Size(112, 20);
            this.txtMatriculaDependente.TabIndex = 5;
            this.txtMatriculaDependente.Visible = false;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(278, 192);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(112, 20);
            this.txtIDCliente.TabIndex = 4;
            this.txtIDCliente.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Advocacia_Dias_Pereira.Report_Declaracao_Hipo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 665);
            this.reportViewer1.TabIndex = 3;
            // 
            // FormGerarDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.txtMatriculaDependente);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormGerarDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGerarDocumentos";
            this.Load += new System.EventHandler(this.FormGerarDocumentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtMatriculaDependente;
        public System.Windows.Forms.TextBox txtIDCliente;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}