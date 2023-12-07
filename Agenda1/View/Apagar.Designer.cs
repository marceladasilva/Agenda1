namespace Agenda1.View
{
    partial class Apagar
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
            btn_Excluir = new Button();
            btn_Buscar = new Button();
            tbx_IdBuscar = new TextBox();
            tbx_Celular = new TextBox();
            tbx_Email = new TextBox();
            tbx_Nome = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_Excluir
            // 
            btn_Excluir.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            btn_Excluir.Location = new Point(335, 474);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(94, 40);
            btn_Excluir.TabIndex = 48;
            btn_Excluir.Text = "Excluir";
            btn_Excluir.UseVisualStyleBackColor = true;
            btn_Excluir.Click += btn_Excluir_Click;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            btn_Buscar.Location = new Point(383, 149);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(94, 40);
            btn_Buscar.TabIndex = 47;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // tbx_IdBuscar
            // 
            tbx_IdBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            tbx_IdBuscar.Location = new Point(158, 156);
            tbx_IdBuscar.Name = "tbx_IdBuscar";
            tbx_IdBuscar.Size = new Size(205, 29);
            tbx_IdBuscar.TabIndex = 46;
            // 
            // tbx_Celular
            // 
            tbx_Celular.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            tbx_Celular.Location = new Point(143, 362);
            tbx_Celular.Margin = new Padding(5, 6, 5, 6);
            tbx_Celular.Name = "tbx_Celular";
            tbx_Celular.Size = new Size(184, 29);
            tbx_Celular.TabIndex = 45;
            // 
            // tbx_Email
            // 
            tbx_Email.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            tbx_Email.Location = new Point(143, 309);
            tbx_Email.Margin = new Padding(5, 6, 5, 6);
            tbx_Email.Name = "tbx_Email";
            tbx_Email.Size = new Size(323, 29);
            tbx_Email.TabIndex = 44;
            // 
            // tbx_Nome
            // 
            tbx_Nome.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            tbx_Nome.Location = new Point(143, 245);
            tbx_Nome.Margin = new Padding(5, 6, 5, 6);
            tbx_Nome.Name = "tbx_Nome";
            tbx_Nome.Size = new Size(323, 29);
            tbx_Nome.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label6.Location = new Point(65, 362);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 30);
            label6.TabIndex = 42;
            label6.Text = "Celular";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label4.Location = new Point(65, 305);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 30);
            label4.TabIndex = 41;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label3.Location = new Point(65, 241);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 30);
            label3.TabIndex = 40;
            label3.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label2.Location = new Point(61, 114);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(312, 30);
            label2.TabIndex = 39;
            label2.Text = "Digite a Matricula do Funcionário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.Location = new Point(165, 37);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 37);
            label1.TabIndex = 38;
            label1.Text = "Excluir Usuário";
            // 
            // Apagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 557);
            Controls.Add(btn_Excluir);
            Controls.Add(btn_Buscar);
            Controls.Add(tbx_IdBuscar);
            Controls.Add(tbx_Celular);
            Controls.Add(tbx_Email);
            Controls.Add(tbx_Nome);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Apagar";
            Text = "Celular";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Excluir;
        private Button btn_Buscar;
        private TextBox tbx_IdBuscar;
        private TextBox tbx_Celular;
        private TextBox tbx_Email;
        private TextBox tbx_Nome;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}