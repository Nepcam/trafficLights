﻿namespace trafficLights
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
            this.pictureBoxArea = new System.Windows.Forms.PictureBox();
            this.textBoxUserInput = new System.Windows.Forms.TextBox();
            this.buttonDrawTrafficLights = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxArea
            // 
            this.pictureBoxArea.Location = new System.Drawing.Point(468, 1);
            this.pictureBoxArea.Name = "pictureBoxArea";
            this.pictureBoxArea.Size = new System.Drawing.Size(332, 437);
            this.pictureBoxArea.TabIndex = 0;
            this.pictureBoxArea.TabStop = false;
            // 
            // textBoxUserInput
            // 
            this.textBoxUserInput.Location = new System.Drawing.Point(243, 137);
            this.textBoxUserInput.Name = "textBoxUserInput";
            this.textBoxUserInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserInput.TabIndex = 1;
            // 
            // buttonDrawTrafficLights
            // 
            this.buttonDrawTrafficLights.Location = new System.Drawing.Point(15, 191);
            this.buttonDrawTrafficLights.Name = "buttonDrawTrafficLights";
            this.buttonDrawTrafficLights.Size = new System.Drawing.Size(328, 23);
            this.buttonDrawTrafficLights.TabIndex = 2;
            this.buttonDrawTrafficLights.Text = "Draw Traffic Lights";
            this.buttonDrawTrafficLights.UseVisualStyleBackColor = true;
            this.buttonDrawTrafficLights.Click += new System.EventHandler(this.buttonDrawTrafficLights_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(15, 239);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(150, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(195, 239);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(148, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter a Number to set the radius";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDrawTrafficLights);
            this.Controls.Add(this.textBoxUserInput);
            this.Controls.Add(this.pictureBoxArea);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxArea;
        private System.Windows.Forms.TextBox textBoxUserInput;
        private System.Windows.Forms.Button buttonDrawTrafficLights;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
    }
}

