namespace Campo_Minato
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lbl_rules = new System.Windows.Forms.Label();
            this.btn_chiudi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_rules
            // 
            this.lbl_rules.AutoSize = true;
            this.lbl_rules.BackColor = System.Drawing.Color.White;
            this.lbl_rules.Location = new System.Drawing.Point(107, 58);
            this.lbl_rules.Name = "lbl_rules";
            this.lbl_rules.Size = new System.Drawing.Size(619, 320);
            this.lbl_rules.TabIndex = 1;
            this.lbl_rules.Text = resources.GetString("lbl_rules.Text");
            // 
            // btn_chiudi
            // 
            this.btn_chiudi.Location = new System.Drawing.Point(377, 402);
            this.btn_chiudi.Name = "btn_chiudi";
            this.btn_chiudi.Size = new System.Drawing.Size(75, 23);
            this.btn_chiudi.TabIndex = 2;
            this.btn_chiudi.Text = "CHIUDI";
            this.btn_chiudi.UseVisualStyleBackColor = true;
            this.btn_chiudi.Click += new System.EventHandler(this.btn_chiudi_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_chiudi);
            this.Controls.Add(this.lbl_rules);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rules;
        private System.Windows.Forms.Button btn_chiudi;
    }
}