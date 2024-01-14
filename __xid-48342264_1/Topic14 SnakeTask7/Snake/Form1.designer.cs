namespace Snake
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
            this.leftBTN = new System.Windows.Forms.Button();
            this.downBTN = new System.Windows.Forms.Button();
            this.upBTN = new System.Windows.Forms.Button();
            this.rightBTN = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.modeLBL = new System.Windows.Forms.Label();
            this.boardPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.timerLBL = new System.Windows.Forms.Label();
            this.startBTN = new System.Windows.Forms.Button();
            this.pauseBTN = new System.Windows.Forms.Button();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftBTN
            // 
            this.leftBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftBTN.Location = new System.Drawing.Point(261, 31);
            this.leftBTN.Margin = new System.Windows.Forms.Padding(2);
            this.leftBTN.Name = "leftBTN";
            this.leftBTN.Size = new System.Drawing.Size(26, 26);
            this.leftBTN.TabIndex = 1;
            this.leftBTN.Text = "◀";
            this.leftBTN.UseVisualStyleBackColor = true;
            this.leftBTN.Click += new System.EventHandler(this.leftBTN_Click);
            // 
            // downBTN
            // 
            this.downBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downBTN.Location = new System.Drawing.Point(307, 62);
            this.downBTN.Margin = new System.Windows.Forms.Padding(2);
            this.downBTN.Name = "downBTN";
            this.downBTN.Size = new System.Drawing.Size(26, 26);
            this.downBTN.TabIndex = 3;
            this.downBTN.Text = "▼";
            this.downBTN.UseVisualStyleBackColor = true;
            this.downBTN.Click += new System.EventHandler(this.downBTN_Click);
            // 
            // upBTN
            // 
            this.upBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upBTN.Location = new System.Drawing.Point(307, 2);
            this.upBTN.Margin = new System.Windows.Forms.Padding(2);
            this.upBTN.Name = "upBTN";
            this.upBTN.Size = new System.Drawing.Size(26, 25);
            this.upBTN.TabIndex = 4;
            this.upBTN.Text = "▲";
            this.upBTN.UseVisualStyleBackColor = true;
            this.upBTN.Click += new System.EventHandler(this.upBTN_Click);
            // 
            // rightBTN
            // 
            this.rightBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightBTN.Location = new System.Drawing.Point(356, 31);
            this.rightBTN.Margin = new System.Windows.Forms.Padding(2);
            this.rightBTN.Name = "rightBTN";
            this.rightBTN.Size = new System.Drawing.Size(26, 26);
            this.rightBTN.TabIndex = 5;
            this.rightBTN.Text = "▶";
            this.rightBTN.UseVisualStyleBackColor = true;
            this.rightBTN.Click += new System.EventHandler(this.rightBTN_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.pauseBTN);
            this.controlPanel.Controls.Add(this.startBTN);
            this.controlPanel.Controls.Add(this.label3);
            this.controlPanel.Controls.Add(this.modeLBL);
            this.controlPanel.Controls.Add(this.timerLBL);
            this.controlPanel.Controls.Add(this.upBTN);
            this.controlPanel.Controls.Add(this.leftBTN);
            this.controlPanel.Controls.Add(this.downBTN);
            this.controlPanel.Controls.Add(this.rightBTN);
            this.controlPanel.Location = new System.Drawing.Point(0, 106);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(574, 95);
            this.controlPanel.TabIndex = 18;
            // 
            // modeLBL
            // 
            this.modeLBL.AutoSize = true;
            this.modeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeLBL.Location = new System.Drawing.Point(292, 39);
            this.modeLBL.Name = "modeLBL";
            this.modeLBL.Size = new System.Drawing.Size(59, 13);
            this.modeLBL.TabIndex = 6;
            this.modeLBL.Text = "modeLBL";
            // 
            // boardPanel
            // 
            this.boardPanel.Location = new System.Drawing.Point(0, 1);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(200, 100);
            this.boardPanel.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Timer";
            // 
            // timerLBL
            // 
            this.timerLBL.AutoSize = true;
            this.timerLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timerLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLBL.Location = new System.Drawing.Point(72, 62);
            this.timerLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timerLBL.Name = "timerLBL";
            this.timerLBL.Size = new System.Drawing.Size(58, 15);
            this.timerLBL.TabIndex = 20;
            this.timerLBL.Text = "timerLBL";
            // 
            // startBTN
            // 
            this.startBTN.Location = new System.Drawing.Point(459, 16);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(75, 23);
            this.startBTN.TabIndex = 22;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = true;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // pauseBTN
            // 
            this.pauseBTN.Location = new System.Drawing.Point(459, 45);
            this.pauseBTN.Name = "pauseBTN";
            this.pauseBTN.Size = new System.Drawing.Size(75, 23);
            this.pauseBTN.TabIndex = 23;
            this.pauseBTN.Text = "Pause";
            this.pauseBTN.UseVisualStyleBackColor = true;
            this.pauseBTN.Click += new System.EventHandler(this.pauseBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 205);
            this.Controls.Add(this.boardPanel);
            this.Controls.Add(this.controlPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button leftBTN;
        private System.Windows.Forms.Button downBTN;
        private System.Windows.Forms.Button upBTN;
        private System.Windows.Forms.Button rightBTN;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.Label modeLBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timerLBL;
        private System.Windows.Forms.Button pauseBTN;
        private System.Windows.Forms.Button startBTN;
    }
}

