namespace Caesar
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.rad_encrypt = new System.Windows.Forms.RadioButton();
            this.rad_decrypt = new System.Windows.Forms.RadioButton();
            this.box_input = new System.Windows.Forms.RichTextBox();
            this.box_output = new System.Windows.Forms.RichTextBox();
            this.num_key = new System.Windows.Forms.NumericUpDown();
            this.lbl_key = new System.Windows.Forms.Label();
            this.lbl_input = new System.Windows.Forms.Label();
            this.lbl_output = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_key)).BeginInit();
            this.SuspendLayout();
            // 
            // rad_encrypt
            // 
            this.rad_encrypt.AutoSize = true;
            this.rad_encrypt.Checked = true;
            this.rad_encrypt.Location = new System.Drawing.Point(12, 37);
            this.rad_encrypt.Name = "rad_encrypt";
            this.rad_encrypt.Size = new System.Drawing.Size(90, 17);
            this.rad_encrypt.TabIndex = 1;
            this.rad_encrypt.TabStop = true;
            this.rad_encrypt.Text = "Verschlüsseln";
            this.rad_encrypt.UseVisualStyleBackColor = true;
            this.rad_encrypt.CheckedChanged += new System.EventHandler(this.rad_encrypt_CheckedChanged);
            // 
            // rad_decrypt
            // 
            this.rad_decrypt.AutoSize = true;
            this.rad_decrypt.Location = new System.Drawing.Point(12, 61);
            this.rad_decrypt.Name = "rad_decrypt";
            this.rad_decrypt.Size = new System.Drawing.Size(90, 17);
            this.rad_decrypt.TabIndex = 2;
            this.rad_decrypt.TabStop = true;
            this.rad_decrypt.Text = "Entschlüsseln";
            this.rad_decrypt.UseVisualStyleBackColor = true;
            // 
            // box_input
            // 
            this.box_input.Location = new System.Drawing.Point(12, 114);
            this.box_input.Name = "box_input";
            this.box_input.Size = new System.Drawing.Size(205, 220);
            this.box_input.TabIndex = 3;
            this.box_input.Text = "";
            this.box_input.TextChanged += new System.EventHandler(this.box_input_TextChanged);
            // 
            // box_output
            // 
            this.box_output.Location = new System.Drawing.Point(239, 114);
            this.box_output.Name = "box_output";
            this.box_output.ReadOnly = true;
            this.box_output.Size = new System.Drawing.Size(205, 220);
            this.box_output.TabIndex = 4;
            this.box_output.Text = "";
            // 
            // num_key
            // 
            this.num_key.Location = new System.Drawing.Point(202, 7);
            this.num_key.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.num_key.Name = "num_key";
            this.num_key.Size = new System.Drawing.Size(120, 20);
            this.num_key.TabIndex = 5;
            this.num_key.ValueChanged += new System.EventHandler(this.num_key_ValueChanged);
            // 
            // lbl_key
            // 
            this.lbl_key.AutoSize = true;
            this.lbl_key.Location = new System.Drawing.Point(9, 9);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.Size = new System.Drawing.Size(187, 13);
            this.lbl_key.TabIndex = 6;
            this.lbl_key.Text = "Schlüssel (Verschiebung im Alphabet):";
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(12, 98);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(73, 13);
            this.lbl_input.TabIndex = 7;
            this.lbl_input.Text = "Text Eingabe:";
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(236, 98);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(76, 13);
            this.lbl_output.TabIndex = 8;
            this.lbl_output.Text = "Text Ausgabe:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 346);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.lbl_input);
            this.Controls.Add(this.lbl_key);
            this.Controls.Add(this.num_key);
            this.Controls.Add(this.box_output);
            this.Controls.Add(this.box_input);
            this.Controls.Add(this.rad_decrypt);
            this.Controls.Add(this.rad_encrypt);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(472, 385);
            this.MinimumSize = new System.Drawing.Size(472, 385);
            this.Name = "Form1";
            this.Text = "Caesar";
            ((System.ComponentModel.ISupportInitialize)(this.num_key)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rad_encrypt;
        private System.Windows.Forms.RadioButton rad_decrypt;
        private System.Windows.Forms.RichTextBox box_input;
        private System.Windows.Forms.RichTextBox box_output;
        private System.Windows.Forms.NumericUpDown num_key;
        private System.Windows.Forms.Label lbl_key;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.Label lbl_output;
    }
}

