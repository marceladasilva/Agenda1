namespace Agenda1.View
{
    partial class BuscarCod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarCod));
            bnt_Buscar = new Button();
            txb_Email = new TextBox();
            txb_Nome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txb_Celular = new TextBox();
            txb_IdBuscar = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // bnt_Buscar
            // 
            bnt_Buscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic);
            bnt_Buscar.Location = new Point(299, 165);
            bnt_Buscar.Name = "bnt_Buscar";
            bnt_Buscar.Size = new Size(130, 34);
            bnt_Buscar.TabIndex = 39;
            bnt_Buscar.Text = "Buscar";
            bnt_Buscar.UseVisualStyleBackColor = true;
            bnt_Buscar.Click += bnt_Buscar_Click;
            // 
            // txb_Email
            // 
            txb_Email.Font = new Font("Segoe UI", 12F);
            txb_Email.Location = new Point(192, 346);
            txb_Email.Name = "txb_Email";
            txb_Email.Size = new Size(331, 29);
            txb_Email.TabIndex = 38;
            // 
            // txb_Nome
            // 
            txb_Nome.Font = new Font("Segoe UI", 12F);
            txb_Nome.Location = new Point(192, 273);
            txb_Nome.Name = "txb_Nome";
            txb_Nome.Size = new Size(331, 29);
            txb_Nome.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label4.Location = new Point(192, 404);
            label4.Name = "label4";
            label4.Size = new Size(76, 30);
            label4.TabIndex = 36;
            label4.Text = "Celular";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label3.Location = new Point(192, 313);
            label3.Name = "label3";
            label3.Size = new Size(62, 30);
            label3.TabIndex = 35;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label2.Location = new Point(192, 240);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 34;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            label1.Location = new Point(251, 27);
            label1.Name = "label1";
            label1.Size = new Size(222, 25);
            label1.TabIndex = 33;
            label1.Text = "Agenda Buscar Codigo";
            // 
            // txb_Celular
            // 
            txb_Celular.Font = new Font("Segoe UI", 12F);
            txb_Celular.Location = new Point(192, 437);
            txb_Celular.Name = "txb_Celular";
            txb_Celular.Size = new Size(331, 29);
            txb_Celular.TabIndex = 40;
            // 
            // txb_IdBuscar
            // 
            txb_IdBuscar.Font = new Font("Segoe UI", 12F);
            txb_IdBuscar.Location = new Point(192, 114);
            txb_IdBuscar.Name = "txb_IdBuscar";
            txb_IdBuscar.Size = new Size(331, 29);
            txb_IdBuscar.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(298, 91);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 42;
            label5.Text = "Digite o Código";
            // 
            // BuscarCod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 572);
            Controls.Add(label5);
            Controls.Add(txb_IdBuscar);
            Controls.Add(txb_Celular);
            Controls.Add(bnt_Buscar);
            Controls.Add(txb_Email);
            Controls.Add(txb_Nome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BuscarCod";
            Text = "BuscarCod";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bnt_Buscar;
        private TextBox txb_Email;
        private TextBox txb_Nome;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txb_Celular;
        private TextBox txb_IdBuscar;
        private Label label5;
    }
}