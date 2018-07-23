namespace PlasmidDatabase2
{
    partial class View
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
            this.CmdEnterPlasmi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdEnterPlasmi
            // 
            this.CmdEnterPlasmi.Location = new System.Drawing.Point(45, 163);
            this.CmdEnterPlasmi.Name = "CmdEnterPlasmi";
            this.CmdEnterPlasmi.Size = new System.Drawing.Size(148, 27);
            this.CmdEnterPlasmi.TabIndex = 0;
            this.CmdEnterPlasmi.Text = "Eingabe";
            this.CmdEnterPlasmi.UseVisualStyleBackColor = true;
            this.CmdEnterPlasmi.Click += new System.EventHandler(this.CmdEnterPlasmid_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 1;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CmdEnterPlasmi);
            this.Name = "View";
            this.Text = "View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdEnterPlasmi;
        private System.Windows.Forms.TextBox textBox1;
    }
}