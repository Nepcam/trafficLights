namespace trafficLights
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonDrawTrafficLights = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxArea
            // 
            this.pictureBoxArea.Location = new System.Drawing.Point(265, 2);
            this.pictureBoxArea.Name = "pictureBoxArea";
            this.pictureBoxArea.Size = new System.Drawing.Size(535, 448);
            this.pictureBoxArea.TabIndex = 0;
            this.pictureBoxArea.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonDrawTrafficLights
            // 
            this.buttonDrawTrafficLights.Location = new System.Drawing.Point(42, 112);
            this.buttonDrawTrafficLights.Name = "buttonDrawTrafficLights";
            this.buttonDrawTrafficLights.Size = new System.Drawing.Size(142, 23);
            this.buttonDrawTrafficLights.TabIndex = 2;
            this.buttonDrawTrafficLights.Text = "Draw Traffic Lights";
            this.buttonDrawTrafficLights.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(42, 198);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(42, 301);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDrawTrafficLights);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBoxArea);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxArea;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonDrawTrafficLights;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
    }
}

