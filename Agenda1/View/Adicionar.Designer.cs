namespace Agenda1.View
{
    partial class Adicionar
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
            mtxb_telefone = new MaskedTextBox();
            btn_Cadastrar = new Button();
            txb_email = new TextBox();
            txb_nome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // mtxb_telefone
            // 
            mtxb_telefone.Font = new Font("Segoe UI", 12F);
            mtxb_telefone.Location = new Point(67, 291);
            mtxb_telefone.Mask = "(999) 000-0000";
            mtxb_telefone.Name = "mtxb_telefone";
            mtxb_telefone.Size = new Size(156, 29);
            mtxb_telefone.TabIndex = 32;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic);
            btn_Cadastrar.Location = new Point(172, 382);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(130, 34);
            btn_Cadastrar.TabIndex = 31;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = true;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // txb_email
            // 
            txb_email.Font = new Font("Segoe UI", 12F);
            txb_email.Location = new Point(67, 200);
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(331, 29);
            txb_email.TabIndex = 30;
            // 
            // txb_nome
            // 
            txb_nome.Font = new Font("Segoe UI", 12F);
            txb_nome.Location = new Point(67, 127);
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(331, 29);
            txb_nome.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label4.Location = new Point(67, 258);
            label4.Name = "label4";
            label4.Size = new Size(76, 30);
            label4.TabIndex = 28;
            label4.Text = "Celular";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label3.Location = new Point(67, 167);
            label3.Name = "label3";
            label3.Size = new Size(62, 30);
            label3.TabIndex = 27;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label2.Location = new Point(67, 94);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 26;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            label1.Location = new Point(172, 32);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 25;
            label1.Text = "Cadastro de Cliente";
            // 
            // Adicionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 450);
            Controls.Add(mtxb_telefone);
            Controls.Add(btn_Cadastrar);
            Controls.Add(txb_email);
            Controls.Add(txb_nome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Adicionar";
            Text = "Adicionar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtxb_telefone;
        private Button btn_Cadastrar;
        private TextBox txb_email;
        private TextBox txb_nome;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}