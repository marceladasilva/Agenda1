namespace Agenda1.View
{
    partial class Alterar
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
            btn_Buscar = new Button();
            btn_Alterar = new Button();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            txb_Celular = new TextBox();
            txb_Email = new TextBox();
            txb_Nome = new TextBox();
            txb_MatriculaFunci = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_Buscar
            // 
            btn_Buscar.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            btn_Buscar.Location = new Point(363, 90);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(88, 33);
            btn_Buscar.TabIndex = 55;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // btn_Alterar
            // 
            btn_Alterar.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            btn_Alterar.Location = new Point(254, 395);
            btn_Alterar.Name = "btn_Alterar";
            btn_Alterar.Size = new Size(88, 33);
            btn_Alterar.TabIndex = 54;
            btn_Alterar.Text = "Alterar";
            btn_Alterar.UseVisualStyleBackColor = true;
            btn_Alterar.Click += btn_Alterar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label6.Location = new Point(65, 268);
            label6.Name = "label6";
            label6.Size = new Size(76, 30);
            label6.TabIndex = 52;
            label6.Text = "Celular";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label4.Location = new Point(65, 185);
            label4.Name = "label4";
            label4.Size = new Size(62, 30);
            label4.TabIndex = 51;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label3.Location = new Point(65, 145);
            label3.Name = "label3";
            label3.Size = new Size(68, 30);
            label3.TabIndex = 50;
            label3.Text = "Nome";
            // 
            // txb_Celular
            // 
            txb_Celular.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            txb_Celular.Location = new Point(139, 272);
            txb_Celular.Name = "txb_Celular";
            txb_Celular.Size = new Size(238, 29);
            txb_Celular.TabIndex = 48;
            // 
            // txb_Email
            // 
            txb_Email.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            txb_Email.Location = new Point(136, 189);
            txb_Email.Name = "txb_Email";
            txb_Email.Size = new Size(241, 29);
            txb_Email.TabIndex = 47;
            // 
            // txb_Nome
            // 
            txb_Nome.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            txb_Nome.Location = new Point(136, 149);
            txb_Nome.Name = "txb_Nome";
            txb_Nome.Size = new Size(241, 29);
            txb_Nome.TabIndex = 46;
            // 
            // txb_MatriculaFunci
            // 
            txb_MatriculaFunci.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            txb_MatriculaFunci.Location = new Point(181, 94);
            txb_MatriculaFunci.Name = "txb_MatriculaFunci";
            txb_MatriculaFunci.Size = new Size(176, 29);
            txb_MatriculaFunci.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label2.Location = new Point(65, 60);
            label2.Name = "label2";
            label2.Size = new Size(312, 30);
            label2.TabIndex = 44;
            label2.Text = "Digite a Matricula do Funcionario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.Location = new Point(192, 9);
            label1.Name = "label1";
            label1.Size = new Size(213, 37);
            label1.TabIndex = 43;
            label1.Text = "Alterar Usuário";
            // 
            // Alterar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 450);
            Controls.Add(btn_Buscar);
            Controls.Add(btn_Alterar);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txb_Celular);
            Controls.Add(txb_Email);
            Controls.Add(txb_Nome);
            Controls.Add(txb_MatriculaFunci);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Alterar";
            Text = "Alterar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Buscar;
        private Button btn_Alterar;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox txb_Celular;
        private TextBox txb_Email;
        private TextBox txb_Nome;
        private TextBox txb_MatriculaFunci;
        private Label label2;
        private Label label1;
    }
}