﻿namespace GridDesktop.Examples.WorkingWithWorksheet
{
    partial class ValidationInWorksheets
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
            this.gridDesktop1 = new Aspose.Cells.GridDesktop.GridDesktop();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gridDesktop1
            // 
            this.gridDesktop1.ActiveSheetIndex = 0;
            this.gridDesktop1.ActiveSheetNameFont = null;
            this.gridDesktop1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDesktop1.CommentDisplayingFont = new System.Drawing.Font("Arial", 9F);
            this.gridDesktop1.IsHorizontalScrollBarVisible = true;
            this.gridDesktop1.IsVerticalScrollBarVisible = true;
            this.gridDesktop1.Location = new System.Drawing.Point(12, 12);
            this.gridDesktop1.Name = "gridDesktop1";
            this.gridDesktop1.SheetNameFont = new System.Drawing.Font("Verdana", 8F);
            this.gridDesktop1.SheetTabWidth = 400;
            this.gridDesktop1.Size = new System.Drawing.Size(720, 410);
            this.gridDesktop1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(155, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Validation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(302, 434);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Access Validation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.Location = new System.Drawing.Point(449, 434);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Remove Validation";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ValidationInWorksheets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 469);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridDesktop1);
            this.Name = "ValidationInWorksheets";
            this.Text = "Working with Validation In Worksheets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Aspose.Cells.GridDesktop.GridDesktop gridDesktop1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}