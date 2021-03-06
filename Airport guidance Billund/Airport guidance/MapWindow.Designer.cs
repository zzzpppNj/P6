﻿namespace Airport_guidance
{
    partial class MapWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelectDest = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.axMap1 = new AxMapWinGIS.AxMap();
            this.axMap2 = new AxMapWinGIS.AxMap();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMap2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1359, 630);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSelectDest
            // 
            this.btnSelectDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnSelectDest.Location = new System.Drawing.Point(454, 663);
            this.btnSelectDest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectDest.Name = "btnSelectDest";
            this.btnSelectDest.Size = new System.Drawing.Size(546, 137);
            this.btnSelectDest.TabIndex = 2;
            this.btnSelectDest.Text = "HOW DO I GET THERE";
            this.btnSelectDest.UseVisualStyleBackColor = true;
            this.btnSelectDest.Click += new System.EventHandler(this.btnSelectDest_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPassword.Location = new System.Drawing.Point(9, 778);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(21, 22);
            this.btnPassword.TabIndex = 3;
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // axMap1
            // 
            this.axMap1.Enabled = true;
            this.axMap1.Location = new System.Drawing.Point(12, 12);
            this.axMap1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axMap1.Name = "axMap1";
            this.axMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap1.OcxState")));
            this.axMap1.Size = new System.Drawing.Size(1505, 638);
            this.axMap1.TabIndex = 4;
            this.axMap1.MouseDownEvent += new AxMapWinGIS._DMapEvents_MouseDownEventHandler(this.axMap1_MouseDownEvent);
            // 
            // axMap2
            // 
            this.axMap2.Enabled = true;
            this.axMap2.Location = new System.Drawing.Point(966, 0);
            this.axMap2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axMap2.Name = "axMap2";
            this.axMap2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap2.OcxState")));
            this.axMap2.Size = new System.Drawing.Size(8, 8);
            this.axMap2.TabIndex = 5;
            this.axMap2.MouseDownEvent += new AxMapWinGIS._DMapEvents_MouseDownEventHandler(this.axMap2_MouseDownEvent);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MapWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 820);
            this.Controls.Add(this.axMap2);
            this.Controls.Add(this.axMap1);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnSelectDest);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MapWindow";
            this.Text = "MapWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MapWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMap2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSelectDest;
        private System.Windows.Forms.Button btnPassword;
        private AxMapWinGIS.AxMap axMap1;
        private AxMapWinGIS.AxMap axMap2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}