namespace Project04._2
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblSideA = new System.Windows.Forms.Label();
            this.lblSideB = new System.Windows.Forms.Label();
            this.lblAngleC = new System.Windows.Forms.Label();
            this.lblCalc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAngleB = new System.Windows.Forms.Label();
            this.lblAngleA = new System.Windows.Forms.Label();
            this.lblSideC = new System.Windows.Forms.Label();
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.txtAngleC = new System.Windows.Forms.TextBox();
            this.txtSideC = new System.Windows.Forms.TextBox();
            this.txtAngleB = new System.Windows.Forms.TextBox();
            this.txtAngleA = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.pictureTriangle = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTriangle)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Location = new System.Drawing.Point(65, 77);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(237, 17);
            this.lblIntro.TabIndex = 1;
            this.lblIntro.Text = "Give me the two sides and the angle";
            // 
            // lblSideA
            // 
            this.lblSideA.AutoSize = true;
            this.lblSideA.Location = new System.Drawing.Point(66, 110);
            this.lblSideA.Name = "lblSideA";
            this.lblSideA.Size = new System.Drawing.Size(52, 17);
            this.lblSideA.TabIndex = 2;
            this.lblSideA.Text = "Side a:";
            // 
            // lblSideB
            // 
            this.lblSideB.AutoSize = true;
            this.lblSideB.Location = new System.Drawing.Point(66, 140);
            this.lblSideB.Name = "lblSideB";
            this.lblSideB.Size = new System.Drawing.Size(52, 17);
            this.lblSideB.TabIndex = 3;
            this.lblSideB.Text = "Side b:";
            // 
            // lblAngleC
            // 
            this.lblAngleC.AutoSize = true;
            this.lblAngleC.Location = new System.Drawing.Point(65, 170);
            this.lblAngleC.Name = "lblAngleC";
            this.lblAngleC.Size = new System.Drawing.Size(61, 17);
            this.lblAngleC.TabIndex = 4;
            this.lblAngleC.Text = "Angle C:";
            // 
            // lblCalc
            // 
            this.lblCalc.AutoSize = true;
            this.lblCalc.Location = new System.Drawing.Point(65, 204);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(153, 51);
            this.lblCalc.TabIndex = 5;
            this.lblCalc.Text = "Calculate the length of \r\nthe missing side and\r\nmissing angles";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 6;
            // 
            // lblAngleB
            // 
            this.lblAngleB.AutoSize = true;
            this.lblAngleB.Location = new System.Drawing.Point(66, 347);
            this.lblAngleB.Name = "lblAngleB";
            this.lblAngleB.Size = new System.Drawing.Size(61, 17);
            this.lblAngleB.TabIndex = 7;
            this.lblAngleB.Text = "Angle B:";
            // 
            // lblAngleA
            // 
            this.lblAngleA.AutoSize = true;
            this.lblAngleA.Location = new System.Drawing.Point(66, 317);
            this.lblAngleA.Name = "lblAngleA";
            this.lblAngleA.Size = new System.Drawing.Size(61, 17);
            this.lblAngleA.TabIndex = 8;
            this.lblAngleA.Text = "Angle A:";
            // 
            // lblSideC
            // 
            this.lblSideC.AutoSize = true;
            this.lblSideC.Location = new System.Drawing.Point(66, 289);
            this.lblSideC.Name = "lblSideC";
            this.lblSideC.Size = new System.Drawing.Size(51, 17);
            this.lblSideC.TabIndex = 9;
            this.lblSideC.Text = "Side c:";
            // 
            // txtSideA
            // 
            this.txtSideA.Location = new System.Drawing.Point(176, 112);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(100, 22);
            this.txtSideA.TabIndex = 10;
            // 
            // txtSideB
            // 
            this.txtSideB.Location = new System.Drawing.Point(176, 140);
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(100, 22);
            this.txtSideB.TabIndex = 11;
            // 
            // txtAngleC
            // 
            this.txtAngleC.Location = new System.Drawing.Point(176, 167);
            this.txtAngleC.Name = "txtAngleC";
            this.txtAngleC.Size = new System.Drawing.Size(100, 22);
            this.txtAngleC.TabIndex = 12;
            // 
            // txtSideC
            // 
            this.txtSideC.Location = new System.Drawing.Point(176, 286);
            this.txtSideC.Name = "txtSideC";
            this.txtSideC.Size = new System.Drawing.Size(100, 22);
            this.txtSideC.TabIndex = 13;
            // 
            // txtAngleB
            // 
            this.txtAngleB.Location = new System.Drawing.Point(176, 344);
            this.txtAngleB.Name = "txtAngleB";
            this.txtAngleB.Size = new System.Drawing.Size(100, 22);
            this.txtAngleB.TabIndex = 14;
            // 
            // txtAngleA
            // 
            this.txtAngleA.Location = new System.Drawing.Point(176, 314);
            this.txtAngleA.Name = "txtAngleA";
            this.txtAngleA.Size = new System.Drawing.Size(100, 22);
            this.txtAngleA.TabIndex = 15;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(236, 204);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(116, 51);
            this.btnCalc.TabIndex = 16;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // pictureTriangle
            // 
            this.pictureTriangle.Image = ((System.Drawing.Image)(resources.GetObject("pictureTriangle.Image")));
            this.pictureTriangle.Location = new System.Drawing.Point(390, 80);
            this.pictureTriangle.Name = "pictureTriangle";
            this.pictureTriangle.Size = new System.Drawing.Size(426, 279);
            this.pictureTriangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTriangle.TabIndex = 17;
            this.pictureTriangle.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(236, 390);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 45);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 496);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureTriangle);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtAngleA);
            this.Controls.Add(this.txtAngleB);
            this.Controls.Add(this.txtSideC);
            this.Controls.Add(this.txtAngleC);
            this.Controls.Add(this.txtSideB);
            this.Controls.Add(this.txtSideA);
            this.Controls.Add(this.lblSideC);
            this.Controls.Add(this.lblAngleA);
            this.Controls.Add(this.lblAngleB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCalc);
            this.Controls.Add(this.lblAngleC);
            this.Controls.Add(this.lblSideB);
            this.Controls.Add(this.lblSideA);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Triangle Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTriangle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lblSideA;
        private System.Windows.Forms.Label lblSideB;
        private System.Windows.Forms.Label lblAngleC;
        private System.Windows.Forms.Label lblCalc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAngleB;
        private System.Windows.Forms.Label lblAngleA;
        private System.Windows.Forms.Label lblSideC;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.TextBox txtAngleC;
        private System.Windows.Forms.TextBox txtSideC;
        private System.Windows.Forms.TextBox txtAngleB;
        private System.Windows.Forms.TextBox txtAngleA;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.PictureBox pictureTriangle;
        private System.Windows.Forms.Button btnClear;
    }
}

