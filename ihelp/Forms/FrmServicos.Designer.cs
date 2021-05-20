namespace ihelp.Forms
{
    partial class FrmServicos
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
            this.btnLimparTrab = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.listBoxServicos = new System.Windows.Forms.ListBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLimparTrab
            // 
            this.btnLimparTrab.Location = new System.Drawing.Point(258, 359);
            this.btnLimparTrab.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimparTrab.Name = "btnLimparTrab";
            this.btnLimparTrab.Size = new System.Drawing.Size(70, 30);
            this.btnLimparTrab.TabIndex = 88;
            this.btnLimparTrab.Text = "Limpar";
            this.btnLimparTrab.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(165, 90);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(36, 20);
            this.txtId.TabIndex = 81;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(68, 90);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(90, 20);
            this.txtStatus.TabIndex = 75;
            // 
            // listBoxServicos
            // 
            this.listBoxServicos.FormattingEnabled = true;
            this.listBoxServicos.Location = new System.Drawing.Point(258, 13);
            this.listBoxServicos.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxServicos.Name = "listBoxServicos";
            this.listBoxServicos.Size = new System.Drawing.Size(522, 342);
            this.listBoxServicos.TabIndex = 74;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(672, 391);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(108, 46);
            this.btnFechar.TabIndex = 73;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(131, 188);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(70, 30);
            this.btnEditar.TabIndex = 71;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Status";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(37, 188);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(70, 30);
            this.btnListar.TabIndex = 90;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // FrmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimparTrab);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.listBoxServicos);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnEditar);
            this.Name = "FrmServicos";
            this.Text = "FrmServicos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimparTrab;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ListBox listBoxServicos;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListar;
    }
}