namespace SuperTrunfo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnDistribuirCartas = new Button();
            lstCartasJogador1 = new ListBox();
            lstCartasJogador2 = new ListBox();
            RdoAtaque = new RadioButton();
            RdoDefesa = new RadioButton();
            RdoMagia = new RadioButton();
            LblTotalCartasJogador2 = new Label();
            LblTotalCartasJogador1 = new Label();
            BtnDesafiar = new Button();
            BtnNovaRodada = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 94);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Carta Jogador 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(573, 94);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Carta Jogador 2";
            // 
            // btnDistribuirCartas
            // 
            btnDistribuirCartas.Location = new Point(352, 248);
            btnDistribuirCartas.Name = "btnDistribuirCartas";
            btnDistribuirCartas.Size = new Size(75, 49);
            btnDistribuirCartas.TabIndex = 4;
            btnDistribuirCartas.Text = "Distribuir Cartas";
            btnDistribuirCartas.UseVisualStyleBackColor = true;
            btnDistribuirCartas.Click += btnDistribuirCartas_Click;
            // 
            // lstCartasJogador1
            // 
            lstCartasJogador1.Enabled = false;
            lstCartasJogador1.FormattingEnabled = true;
            lstCartasJogador1.ItemHeight = 15;
            lstCartasJogador1.Location = new Point(58, 112);
            lstCartasJogador1.Name = "lstCartasJogador1";
            lstCartasJogador1.Size = new Size(120, 94);
            lstCartasJogador1.TabIndex = 5;
            // 
            // lstCartasJogador2
            // 
            lstCartasJogador2.Enabled = false;
            lstCartasJogador2.FormattingEnabled = true;
            lstCartasJogador2.ItemHeight = 15;
            lstCartasJogador2.Location = new Point(573, 112);
            lstCartasJogador2.Name = "lstCartasJogador2";
            lstCartasJogador2.Size = new Size(120, 94);
            lstCartasJogador2.TabIndex = 6;
            // 
            // RdoAtaque
            // 
            RdoAtaque.AutoSize = true;
            RdoAtaque.Location = new Point(58, 318);
            RdoAtaque.Name = "RdoAtaque";
            RdoAtaque.Size = new Size(63, 19);
            RdoAtaque.TabIndex = 7;
            RdoAtaque.TabStop = true;
            RdoAtaque.Text = "Ataque";
            RdoAtaque.UseVisualStyleBackColor = true;
            // 
            // RdoDefesa
            // 
            RdoDefesa.AutoSize = true;
            RdoDefesa.Location = new Point(58, 343);
            RdoDefesa.Name = "RdoDefesa";
            RdoDefesa.Size = new Size(60, 19);
            RdoDefesa.TabIndex = 8;
            RdoDefesa.TabStop = true;
            RdoDefesa.Text = "Defesa";
            RdoDefesa.UseVisualStyleBackColor = true;
            // 
            // RdoMagia
            // 
            RdoMagia.AutoSize = true;
            RdoMagia.Location = new Point(58, 368);
            RdoMagia.Name = "RdoMagia";
            RdoMagia.Size = new Size(58, 19);
            RdoMagia.TabIndex = 9;
            RdoMagia.TabStop = true;
            RdoMagia.Text = "Magia";
            RdoMagia.UseVisualStyleBackColor = true;
            // 
            // LblTotalCartasJogador2
            // 
            LblTotalCartasJogador2.AutoSize = true;
            LblTotalCartasJogador2.Location = new Point(573, 209);
            LblTotalCartasJogador2.Name = "LblTotalCartasJogador2";
            LblTotalCartasJogador2.Size = new Size(13, 15);
            LblTotalCartasJogador2.TabIndex = 10;
            LblTotalCartasJogador2.Text = "0";
            // 
            // LblTotalCartasJogador1
            // 
            LblTotalCartasJogador1.AutoSize = true;
            LblTotalCartasJogador1.Location = new Point(58, 209);
            LblTotalCartasJogador1.Name = "LblTotalCartasJogador1";
            LblTotalCartasJogador1.Size = new Size(13, 15);
            LblTotalCartasJogador1.TabIndex = 11;
            LblTotalCartasJogador1.Text = "0";
            // 
            // BtnDesafiar
            // 
            BtnDesafiar.Enabled = false;
            BtnDesafiar.Location = new Point(352, 377);
            BtnDesafiar.Name = "BtnDesafiar";
            BtnDesafiar.Size = new Size(75, 29);
            BtnDesafiar.TabIndex = 12;
            BtnDesafiar.Text = "Desafiar";
            BtnDesafiar.UseVisualStyleBackColor = true;
            BtnDesafiar.Click += BtnDesafiar_Click;
            // 
            // BtnNovaRodada
            // 
            BtnNovaRodada.Enabled = false;
            BtnNovaRodada.Location = new Point(352, 313);
            BtnNovaRodada.Name = "BtnNovaRodada";
            BtnNovaRodada.Size = new Size(75, 49);
            BtnNovaRodada.TabIndex = 13;
            BtnNovaRodada.Text = "Nova Rodada";
            BtnNovaRodada.UseVisualStyleBackColor = true;
            BtnNovaRodada.Click += BtnNovaRodada_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnNovaRodada);
            Controls.Add(BtnDesafiar);
            Controls.Add(LblTotalCartasJogador1);
            Controls.Add(LblTotalCartasJogador2);
            Controls.Add(RdoMagia);
            Controls.Add(RdoDefesa);
            Controls.Add(RdoAtaque);
            Controls.Add(lstCartasJogador2);
            Controls.Add(lstCartasJogador1);
            Controls.Add(btnDistribuirCartas);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "SuperTrunfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnDistribuirCartas;
        private ListBox lstCartasJogador1;
        private ListBox lstCartasJogador2;
        private RadioButton RdoAtaque;
        private RadioButton RdoDefesa;
        private RadioButton RdoMagia;
        private Label LblTotalCartasJogador2;
        private Label LblTotalCartasJogador1;
        private Button BtnDesafiar;
        private Button BtnNovaRodada;
    }
}
