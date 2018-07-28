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
            this.InputPlasmidName = new System.Windows.Forms.TextBox();
            this.InputPlasmidSequenz = new System.Windows.Forms.TextBox();
            this.LblPlasmidName = new System.Windows.Forms.Label();
            this.LblPlasmidSequenz = new System.Windows.Forms.Label();
            this.LblOutputPlasmidSequenz = new System.Windows.Forms.Label();
            this.LblOutputPlasmidName = new System.Windows.Forms.Label();
            this.LblOutput = new System.Windows.Forms.Label();
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
            // InputPlasmidName
            // 
            this.InputPlasmidName.Location = new System.Drawing.Point(39, 90);
            this.InputPlasmidName.Name = "InputPlasmidName";
            this.InputPlasmidName.Size = new System.Drawing.Size(172, 20);
            this.InputPlasmidName.TabIndex = 1;
            this.InputPlasmidName.TextChanged += new System.EventHandler(this.InputPlasmidName_TextChanged);
            // 
            // InputPlasmidSequenz
            // 
            this.InputPlasmidSequenz.Location = new System.Drawing.Point(39, 128);
            this.InputPlasmidSequenz.Name = "InputPlasmidSequenz";
            this.InputPlasmidSequenz.Size = new System.Drawing.Size(172, 20);
            this.InputPlasmidSequenz.TabIndex = 1;
            this.InputPlasmidSequenz.TextChanged += new System.EventHandler(this.InputPlasmidSequenz_TextChanged);
            // 
            // LblPlasmidName
            // 
            this.LblPlasmidName.AutoSize = true;
            this.LblPlasmidName.Location = new System.Drawing.Point(36, 74);
            this.LblPlasmidName.Name = "LblPlasmidName";
            this.LblPlasmidName.Size = new System.Drawing.Size(74, 13);
            this.LblPlasmidName.TabIndex = 2;
            this.LblPlasmidName.Text = "Plasmid-Name";
            // 
            // LblPlasmidSequenz
            // 
            this.LblPlasmidSequenz.AutoSize = true;
            this.LblPlasmidSequenz.Location = new System.Drawing.Point(36, 112);
            this.LblPlasmidSequenz.Name = "LblPlasmidSequenz";
            this.LblPlasmidSequenz.Size = new System.Drawing.Size(88, 13);
            this.LblPlasmidSequenz.TabIndex = 2;
            this.LblPlasmidSequenz.Text = "Plasmid-Sequenz";
            // 
            // LblOutputPlasmidSequenz
            // 
            this.LblOutputPlasmidSequenz.AutoSize = true;
            this.LblOutputPlasmidSequenz.Location = new System.Drawing.Point(264, 134);
            this.LblOutputPlasmidSequenz.Name = "LblOutputPlasmidSequenz";
            this.LblOutputPlasmidSequenz.Size = new System.Drawing.Size(36, 13);
            this.LblOutputPlasmidSequenz.TabIndex = 2;
            this.LblOutputPlasmidSequenz.Text = "(input)";
            this.LblOutputPlasmidSequenz.Click += new System.EventHandler(this.LblOutputPlasmidSequenz_Click);
            // 
            // LblOutputPlasmidName
            // 
            this.LblOutputPlasmidName.AutoSize = true;
            this.LblOutputPlasmidName.Location = new System.Drawing.Point(264, 93);
            this.LblOutputPlasmidName.Name = "LblOutputPlasmidName";
            this.LblOutputPlasmidName.Size = new System.Drawing.Size(0, 13);
            this.LblOutputPlasmidName.TabIndex = 2;
            this.LblOutputPlasmidName.Click += new System.EventHandler(this.LblOutputPlasmidName_Click);
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(258, 43);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(42, 13);
            this.LblOutput.TabIndex = 2;
            this.LblOutput.Text = "Output:";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.LblOutputPlasmidSequenz);
            this.Controls.Add(this.LblOutputPlasmidName);
            this.Controls.Add(this.LblPlasmidSequenz);
            this.Controls.Add(this.LblPlasmidName);
            this.Controls.Add(this.InputPlasmidSequenz);
            this.Controls.Add(this.InputPlasmidName);
            this.Controls.Add(this.CmdEnterPlasmi);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdEnterPlasmi;
        private System.Windows.Forms.TextBox InputPlasmidName;
        private System.Windows.Forms.TextBox InputPlasmidSequenz;
        private System.Windows.Forms.Label LblPlasmidName;
        private System.Windows.Forms.Label LblPlasmidSequenz;
        private System.Windows.Forms.Label LblOutputPlasmidSequenz;
        private System.Windows.Forms.Label LblOutputPlasmidName;
        private System.Windows.Forms.Label LblOutput;
    }
}