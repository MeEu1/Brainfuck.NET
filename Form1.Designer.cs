namespace Brainfuck.NET
{
    partial class Form1
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
            this.txtB_Code = new System.Windows.Forms.TextBox();
            this.bt_Run = new System.Windows.Forms.Button();
            this.bt_Stop = new System.Windows.Forms.Button();
            this.txtB_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtB_Code
            // 
            this.txtB_Code.Location = new System.Drawing.Point(45, 106);
            this.txtB_Code.Multiline = true;
            this.txtB_Code.Name = "txtB_Code";
            this.txtB_Code.Size = new System.Drawing.Size(410, 213);
            this.txtB_Code.TabIndex = 0;
            // 
            // bt_Run
            // 
            this.bt_Run.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Run.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_Run.Location = new System.Drawing.Point(45, 34);
            this.bt_Run.Name = "bt_Run";
            this.bt_Run.Size = new System.Drawing.Size(127, 42);
            this.bt_Run.TabIndex = 1;
            this.bt_Run.Text = "Run";
            this.bt_Run.UseVisualStyleBackColor = false;
            this.bt_Run.Click += new System.EventHandler(this.bt_Run_Click);
            // 
            // bt_Stop
            // 
            this.bt_Stop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_Stop.Location = new System.Drawing.Point(328, 34);
            this.bt_Stop.Name = "bt_Stop";
            this.bt_Stop.Size = new System.Drawing.Size(127, 42);
            this.bt_Stop.TabIndex = 2;
            this.bt_Stop.Text = "Stop";
            this.bt_Stop.UseVisualStyleBackColor = true;
            this.bt_Stop.Click += new System.EventHandler(this.bt_Stop_Click);
            // 
            // txtB_Input
            // 
            this.txtB_Input.Location = new System.Drawing.Point(45, 338);
            this.txtB_Input.Name = "txtB_Input";
            this.txtB_Input.Size = new System.Drawing.Size(410, 20);
            this.txtB_Input.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(509, 389);
            this.Controls.Add(this.txtB_Input);
            this.Controls.Add(this.bt_Stop);
            this.Controls.Add(this.bt_Run);
            this.Controls.Add(this.txtB_Code);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_Code;
        private System.Windows.Forms.Button bt_Run;
        private System.Windows.Forms.Button bt_Stop;
        private System.Windows.Forms.TextBox txtB_Input;
    }
}

