namespace AdvntrGameSum
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.blueImage = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.redImage = new System.Windows.Forms.Label();
            this.greenImage = new System.Windows.Forms.Label();
            this.yellowImage = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.sceneTester = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.Control;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Location = new System.Drawing.Point(12, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(260, 168);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = resources.GetString("outputLabel.Text");
            // 
            // blueImage
            // 
            this.blueImage.Image = global::AdvntrGameSum.Properties.Resources.blue_50x501;
            this.blueImage.Location = new System.Drawing.Point(9, 194);
            this.blueImage.Name = "blueImage";
            this.blueImage.Size = new System.Drawing.Size(50, 47);
            this.blueImage.TabIndex = 1;
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(65, 215);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(54, 26);
            this.blueLabel.TabIndex = 2;
            this.blueLabel.Text = "Go to the \r\nleft room";
            // 
            // redImage
            // 
            this.redImage.Image = global::AdvntrGameSum.Properties.Resources.red_50x501;
            this.redImage.Location = new System.Drawing.Point(9, 266);
            this.redImage.Name = "redImage";
            this.redImage.Size = new System.Drawing.Size(50, 47);
            this.redImage.TabIndex = 3;
            // 
            // greenImage
            // 
            this.greenImage.Image = global::AdvntrGameSum.Properties.Resources.green_50x501;
            this.greenImage.Location = new System.Drawing.Point(147, 194);
            this.greenImage.Name = "greenImage";
            this.greenImage.Size = new System.Drawing.Size(50, 47);
            this.greenImage.TabIndex = 4;
            // 
            // yellowImage
            // 
            this.yellowImage.Image = global::AdvntrGameSum.Properties.Resources.yellow_50x501;
            this.yellowImage.Location = new System.Drawing.Point(147, 266);
            this.yellowImage.Name = "yellowImage";
            this.yellowImage.Size = new System.Drawing.Size(50, 47);
            this.yellowImage.TabIndex = 5;
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(65, 283);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(56, 26);
            this.redLabel.TabIndex = 6;
            this.redLabel.Text = "Go to the \r\nright room ";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(203, 215);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(0, 13);
            this.greenLabel.TabIndex = 7;
            // 
            // yellowLabel
            // 
            this.yellowLabel.AutoSize = true;
            this.yellowLabel.Location = new System.Drawing.Point(203, 283);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(0, 13);
            this.yellowLabel.TabIndex = 8;
            // 
            // sceneTester
            // 
            this.sceneTester.Location = new System.Drawing.Point(193, 338);
            this.sceneTester.Name = "sceneTester";
            this.sceneTester.Size = new System.Drawing.Size(78, 16);
            this.sceneTester.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.sceneTester);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.yellowImage);
            this.Controls.Add(this.greenImage);
            this.Controls.Add(this.redImage);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.blueImage);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Space Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label blueImage;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label redImage;
        private System.Windows.Forms.Label greenImage;
        private System.Windows.Forms.Label yellowImage;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label sceneTester;
    }
}

