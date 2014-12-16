namespace Miljöboven
{
    partial class Inloggningsform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inloggningsform));
            this.btnLoggaIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAnvändarnamn = new System.Windows.Forms.TextBox();
            this.tbxLösenord = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoggaIn
            // 
            this.btnLoggaIn.Location = new System.Drawing.Point(398, 347);
            this.btnLoggaIn.Name = "btnLoggaIn";
            this.btnLoggaIn.Size = new System.Drawing.Size(128, 33);
            this.btnLoggaIn.TabIndex = 3;
            this.btnLoggaIn.Text = "Logga in";
            this.btnLoggaIn.UseVisualStyleBackColor = true;
            this.btnLoggaIn.Click += new System.EventHandler(this.btnLoggaIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Användarnamn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lösenord:";
            // 
            // tbxAnvändarnamn
            // 
            this.tbxAnvändarnamn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAnvändarnamn.Location = new System.Drawing.Point(398, 295);
            this.tbxAnvändarnamn.Name = "tbxAnvändarnamn";
            this.tbxAnvändarnamn.Size = new System.Drawing.Size(128, 20);
            this.tbxAnvändarnamn.TabIndex = 1;
            // 
            // tbxLösenord
            // 
            this.tbxLösenord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxLösenord.Location = new System.Drawing.Point(398, 321);
            this.tbxLösenord.Name = "tbxLösenord";
            this.tbxLösenord.Size = new System.Drawing.Size(128, 20);
            this.tbxLösenord.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Miljöboven.Properties.Resources.tjuv;
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Inloggningsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 392);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxLösenord);
            this.Controls.Add(this.tbxAnvändarnamn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoggaIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(554, 430);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(554, 430);
            this.Name = "Inloggningsform";
            this.Text = "Miljöboven";
            this.Load += new System.EventHandler(this.Inloggningsform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoggaIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAnvändarnamn;
        private System.Windows.Forms.TextBox tbxLösenord;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

