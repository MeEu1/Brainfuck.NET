namespace Brainfuck.NET
{
    partial class Debug
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
            this.txtB_Output = new System.Windows.Forms.TextBox();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtB_Output
            // 
            this.txtB_Output.Location = new System.Drawing.Point(13, 13);
            this.txtB_Output.Multiline = true;
            this.txtB_Output.Name = "txtB_Output";
            this.txtB_Output.Size = new System.Drawing.Size(333, 324);
            this.txtB_Output.TabIndex = 0;
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(115, 343);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(112, 42);
            this.bt_Clear.TabIndex = 1;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 393);
            this.ControlBox = false;
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.txtB_Output);
            this.Name = "Debug";
            this.Text = "Debug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_Output;
        private System.Windows.Forms.Button bt_Clear;
    }
}