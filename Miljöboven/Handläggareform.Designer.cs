namespace Miljöboven
{
    partial class Handläggareform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Handläggareform));
            this.clbÄrendetitlar = new System.Windows.Forms.CheckedListBox();
            this.rtbÄrenedeinformation = new System.Windows.Forms.RichTextBox();
            this.btnSkicka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // clbÄrendetitlar
            // 
            this.clbÄrendetitlar.FormattingEnabled = true;
            this.clbÄrendetitlar.Items.AddRange(new object[] {
            "Titel 1",
            "Titel 2",
            "Titel 3"});
            this.clbÄrendetitlar.Location = new System.Drawing.Point(12, 12);
            this.clbÄrendetitlar.Name = "clbÄrendetitlar";
            this.clbÄrendetitlar.Size = new System.Drawing.Size(251, 274);
            this.clbÄrendetitlar.TabIndex = 0;
            // 
            // rtbÄrenedeinformation
            // 
            this.rtbÄrenedeinformation.Location = new System.Drawing.Point(269, 12);
            this.rtbÄrenedeinformation.Name = "rtbÄrenedeinformation";
            this.rtbÄrenedeinformation.Size = new System.Drawing.Size(458, 170);
            this.rtbÄrenedeinformation.TabIndex = 1;
            this.rtbÄrenedeinformation.Text = "Här står det en massa info om ärendet, tex vart det är och vad som är fel\n\nden ti" +
    "tel du markerat i checklistboxen bestämmer vilket ärende information visas för";
            // 
            // btnSkicka
            // 
            this.btnSkicka.Location = new System.Drawing.Point(622, 253);
            this.btnSkicka.Name = "btnSkicka";
            this.btnSkicka.Size = new System.Drawing.Size(105, 33);
            this.btnSkicka.TabIndex = 2;
            this.btnSkicka.Text = "Skicka";
            this.btnSkicka.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kommentarer:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(273, 214);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(343, 72);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Handläggareform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 303);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSkicka);
            this.Controls.Add(this.rtbÄrenedeinformation);
            this.Controls.Add(this.clbÄrendetitlar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Handläggareform";
            this.Text = "-";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Handläggareform_FormClosing);
            this.Load += new System.EventHandler(this.Handläggareform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbÄrendetitlar;
        private System.Windows.Forms.RichTextBox rtbÄrenedeinformation;
        private System.Windows.Forms.Button btnSkicka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}