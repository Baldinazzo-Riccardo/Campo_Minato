namespace Campo_Minato
{
    partial class Form2
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
            this.btn_gioca = new System.Windows.Forms.Button();
            this.btn_howto = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_gioca
            // 
            this.btn_gioca.Location = new System.Drawing.Point(256, 308);
            this.btn_gioca.Name = "btn_gioca";
            this.btn_gioca.Size = new System.Drawing.Size(75, 23);
            this.btn_gioca.TabIndex = 0;
            this.btn_gioca.Text = "GIOCA";
            this.btn_gioca.UseVisualStyleBackColor = true;
            // 
            // btn_howto
            // 
            this.btn_howto.Location = new System.Drawing.Point(455, 308);
            this.btn_howto.Name = "btn_howto";
            this.btn_howto.Size = new System.Drawing.Size(114, 23);
            this.btn_howto.TabIndex = 1;
            this.btn_howto.Text = "HOW TO PLAY";
            this.btn_howto.UseVisualStyleBackColor = true;
            this.btn_howto.Click += new System.EventHandler(this.btn_howto_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(105, 50);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(639, 46);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "WELCOME TO CAMPO MINATO";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Campo_Minato.Properties.Resources.erba;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_howto);
            this.Controls.Add(this.btn_gioca);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gioca;
        private System.Windows.Forms.Button btn_howto;
        private System.Windows.Forms.Label lbl_title;
    }
}