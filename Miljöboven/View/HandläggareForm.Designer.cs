namespace Miljöboven.View
{
    partial class HandläggareForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HandläggareForm));
            this.clbÄrendetitlar = new System.Windows.Forms.CheckedListBox();
            this.rtbÄrenedeinformation = new System.Windows.Forms.RichTextBox();
            this.btnSkicka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // clbÄrendetitlar
            // 
            this.clbÄrendetitlar.FormattingEnabled = true;
            this.clbÄrendetitlar.Items.AddRange(new object[] {
            "Databygge med miljöproblem",
            "Titel 2",
            "Titel 3"});
            this.clbÄrendetitlar.Location = new System.Drawing.Point(12, 12);
            this.clbÄrendetitlar.Name = "clbÄrendetitlar";
            this.clbÄrendetitlar.Size = new System.Drawing.Size(171, 274);
            this.clbÄrendetitlar.TabIndex = 0;
            // 
            // rtbÄrenedeinformation
            // 
            this.rtbÄrenedeinformation.Location = new System.Drawing.Point(189, 188);
            this.rtbÄrenedeinformation.Name = "rtbÄrenedeinformation";
            this.rtbÄrenedeinformation.Size = new System.Drawing.Size(170, 98);
            this.rtbÄrenedeinformation.TabIndex = 1;
            this.rtbÄrenedeinformation.Text = "Info om ärendet\n";
            // 
            // btnSkicka
            // 
            this.btnSkicka.Location = new System.Drawing.Point(619, 214);
            this.btnSkicka.Name = "btnSkicka";
            this.btnSkicka.Size = new System.Drawing.Size(105, 33);
            this.btnSkicka.TabIndex = 2;
            this.btnSkicka.Text = "Kommentera";
            this.btnSkicka.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kommentarer:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(369, 214);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(244, 72);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Slutför";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "21 / 1 - 2015   Besökte platsen och fixade så att man kan se ifall det är bra"});
            this.listBox1.Location = new System.Drawing.Point(189, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(535, 160);
            this.listBox1.TabIndex = 6;
            // 
            // HandläggareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 303);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSkicka);
            this.Controls.Add(this.rtbÄrenedeinformation);
            this.Controls.Add(this.clbÄrendetitlar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HandläggareForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HandläggareForm_FormClosing);
            this.Load += new System.EventHandler(this.HandläggareForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbÄrendetitlar;
        private System.Windows.Forms.RichTextBox rtbÄrenedeinformation;
        private System.Windows.Forms.Button btnSkicka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}