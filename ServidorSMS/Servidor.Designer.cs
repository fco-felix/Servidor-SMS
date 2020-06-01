namespace ServidorSMS
{
    partial class Servidor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.bT_Iniciar = new System.Windows.Forms.Button();
            this.tB_Porta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rT_LogSMS = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bT_Iniciar);
            this.panel1.Controls.Add(this.tB_Porta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 44);
            this.panel1.TabIndex = 3;
            // 
            // bT_Iniciar
            // 
            this.bT_Iniciar.Location = new System.Drawing.Point(155, 12);
            this.bT_Iniciar.Name = "bT_Iniciar";
            this.bT_Iniciar.Size = new System.Drawing.Size(75, 23);
            this.bT_Iniciar.TabIndex = 5;
            this.bT_Iniciar.Text = "Iniciar";
            this.bT_Iniciar.UseVisualStyleBackColor = true;
            this.bT_Iniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tB_Porta
            // 
            this.tB_Porta.Location = new System.Drawing.Point(49, 13);
            this.tB_Porta.Name = "tB_Porta";
            this.tB_Porta.Size = new System.Drawing.Size(100, 20);
            this.tB_Porta.TabIndex = 4;
            this.tB_Porta.Text = "8000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Porta:";
            // 
            // rT_LogSMS
            // 
            this.rT_LogSMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rT_LogSMS.Location = new System.Drawing.Point(0, 44);
            this.rT_LogSMS.Name = "rT_LogSMS";
            this.rT_LogSMS.Size = new System.Drawing.Size(800, 406);
            this.rT_LogSMS.TabIndex = 4;
            this.rT_LogSMS.Text = "";
            // 
            // Servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rT_LogSMS);
            this.Controls.Add(this.panel1);
            this.Name = "Servidor";
            this.Text = "Servidor SMS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bT_Iniciar;
        private System.Windows.Forms.TextBox tB_Porta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rT_LogSMS;
    }
}

