namespace Caelum_CaixaEletronico
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.boxContas = new System.Windows.Forms.ComboBox();
            this.numeroContaText = new System.Windows.Forms.TextBox();
            this.titularDaContaText = new System.Windows.Forms.TextBox();
            this.saldoDaContaText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.valorText = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTipoConta = new System.Windows.Forms.Label();
            this.btn_RemoveConta = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Depositar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // boxContas
            // 
            this.boxContas.FormattingEnabled = true;
            this.boxContas.Location = new System.Drawing.Point(108, 24);
            this.boxContas.Name = "boxContas";
            this.boxContas.Size = new System.Drawing.Size(121, 21);
            this.boxContas.TabIndex = 1;
            this.boxContas.SelectedIndexChanged += new System.EventHandler(this.boxContas_SelectedIndexChanged);
            // 
            // numeroContaText
            // 
            this.numeroContaText.Location = new System.Drawing.Point(108, 62);
            this.numeroContaText.Name = "numeroContaText";
            this.numeroContaText.Size = new System.Drawing.Size(100, 20);
            this.numeroContaText.TabIndex = 2;
            // 
            // titularDaContaText
            // 
            this.titularDaContaText.Location = new System.Drawing.Point(108, 98);
            this.titularDaContaText.Name = "titularDaContaText";
            this.titularDaContaText.Size = new System.Drawing.Size(100, 20);
            this.titularDaContaText.TabIndex = 3;
            // 
            // saldoDaContaText
            // 
            this.saldoDaContaText.Location = new System.Drawing.Point(108, 138);
            this.saldoDaContaText.Name = "saldoDaContaText";
            this.saldoDaContaText.Size = new System.Drawing.Size(100, 20);
            this.saldoDaContaText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Titular";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Saldo";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Sacar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contas";
            // 
            // valorText
            // 
            this.valorText.Location = new System.Drawing.Point(108, 246);
            this.valorText.Name = "valorText";
            this.valorText.Size = new System.Drawing.Size(100, 20);
            this.valorText.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(268, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Cadastros";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo Conta:";
            // 
            // lbTipoConta
            // 
            this.lbTipoConta.AutoSize = true;
            this.lbTipoConta.Location = new System.Drawing.Point(281, 32);
            this.lbTipoConta.Name = "lbTipoConta";
            this.lbTipoConta.Size = new System.Drawing.Size(40, 13);
            this.lbTipoConta.TabIndex = 13;
            this.lbTipoConta.Text = "Contas";
            // 
            // btn_RemoveConta
            // 
            this.btn_RemoveConta.Location = new System.Drawing.Point(260, 80);
            this.btn_RemoveConta.Name = "btn_RemoveConta";
            this.btn_RemoveConta.Size = new System.Drawing.Size(75, 49);
            this.btn_RemoveConta.TabIndex = 14;
            this.btn_RemoveConta.Text = "Remover Conta";
            this.btn_RemoveConta.UseVisualStyleBackColor = true;
            this.btn_RemoveConta.Click += new System.EventHandler(this.btn_RemoveConta_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(296, 314);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 39);
            this.button5.TabIndex = 15;
            this.button5.Text = "String e arquivos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(198, 314);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 39);
            this.button6.TabIndex = 16;
            this.button6.Text = "LINQ e Lambda";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(97, 314);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 39);
            this.button7.TabIndex = 17;
            this.button7.Text = "Metodos Extras";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(383, 365);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_RemoveConta);
            this.Controls.Add(this.lbTipoConta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.valorText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saldoDaContaText);
            this.Controls.Add(this.titularDaContaText);
            this.Controls.Add(this.numeroContaText);
            this.Controls.Add(this.boxContas);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox boxContas;
        private System.Windows.Forms.TextBox numeroContaText;
        private System.Windows.Forms.TextBox titularDaContaText;
        private System.Windows.Forms.TextBox saldoDaContaText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox valorText;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTipoConta;
        private System.Windows.Forms.Button btn_RemoveConta;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

