﻿namespace WindowsFormsTagApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tagListControl1 = new FerretLib.WinForms.Controls.TagListControl();
            this.SuspendLayout();
            // 
            // tagListControl1
            // 
            this.tagListControl1.Location = new System.Drawing.Point(12, 12);
            this.tagListControl1.Name = "tagListControl1";
            this.tagListControl1.Size = new System.Drawing.Size(776, 426);
            this.tagListControl1.TabIndex = 0;
            this.tagListControl1.Tags = ((System.Collections.Generic.List<string>)(resources.GetObject("tagListControl1.Tags")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tagListControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FerretLib.WinForms.Controls.TagListControl tagListControl1;
    }
}

