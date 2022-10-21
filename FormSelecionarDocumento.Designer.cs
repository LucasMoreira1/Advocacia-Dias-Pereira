namespace Advocacia_Dias_Pereira
{
    partial class FormSelecionarDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelecionarDocumento));
            this.cboxDocumento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGerarDocumento = new System.Windows.Forms.Button();
            this.txtIDAutor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboxDocumento
            // 
            this.cboxDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxDocumento.FormattingEnabled = true;
            this.cboxDocumento.Items.AddRange(new object[] {
            "1 - CONTRATO DE HONORARIOS ADVOCATÍCIOS",
            "2 - DECLARAÇÃO DE HIPOSSUFICIÊNCIA",
            "3 - MANIFESTAÇÃO",
            "4 - PROCURAÇÃO"});
            this.cboxDocumento.Location = new System.Drawing.Point(133, 137);
            this.cboxDocumento.Name = "cboxDocumento";
            this.cboxDocumento.Size = new System.Drawing.Size(477, 24);
            this.cboxDocumento.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Confirme o Autor e selecione o tipo de documento que deseja criar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(133, 88);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(477, 23);
            this.txtAutor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Documento";
            // 
            // btnGerarDocumento
            // 
            this.btnGerarDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarDocumento.Location = new System.Drawing.Point(261, 193);
            this.btnGerarDocumento.Name = "btnGerarDocumento";
            this.btnGerarDocumento.Size = new System.Drawing.Size(133, 47);
            this.btnGerarDocumento.TabIndex = 3;
            this.btnGerarDocumento.Text = "Gerar";
            this.btnGerarDocumento.UseVisualStyleBackColor = true;
            this.btnGerarDocumento.Click += new System.EventHandler(this.btnGerarDocumento_Click);
            // 
            // txtIDAutor
            // 
            this.txtIDAutor.Location = new System.Drawing.Point(39, 220);
            this.txtIDAutor.Name = "txtIDAutor";
            this.txtIDAutor.Size = new System.Drawing.Size(100, 20);
            this.txtIDAutor.TabIndex = 4;
            this.txtIDAutor.Visible = false;
            // 
            // FormSelecionarDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 287);
            this.Controls.Add(this.txtIDAutor);
            this.Controls.Add(this.btnGerarDocumento);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxDocumento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSelecionarDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Documento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cboxDocumento;
        public System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGerarDocumento;
        public System.Windows.Forms.TextBox txtIDAutor;
    }
}