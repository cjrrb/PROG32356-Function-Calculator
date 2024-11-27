namespace Assignment2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lowValueTextBox = new System.Windows.Forms.TextBox();
            this.highValueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.intervalsTextBox = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxSin = new System.Windows.Forms.CheckBox();
            this.checkBoxCos = new System.Windows.Forms.CheckBox();
            this.checkBoxTan = new System.Windows.Forms.CheckBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.checkBoxLog = new System.Windows.Forms.CheckBox();
            this.checkBoxExp = new System.Windows.Forms.CheckBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter low value";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(22, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter high value";
            // 
            // lowValueTextBox
            // 
            this.lowValueTextBox.ForeColor = System.Drawing.Color.Black;
            this.lowValueTextBox.Location = new System.Drawing.Point(139, 134);
            this.lowValueTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lowValueTextBox.Name = "lowValueTextBox";
            this.lowValueTextBox.Size = new System.Drawing.Size(132, 27);
            this.lowValueTextBox.TabIndex = 2;
            // 
            // highValueTextBox
            // 
            this.highValueTextBox.ForeColor = System.Drawing.Color.Black;
            this.highValueTextBox.Location = new System.Drawing.Point(139, 194);
            this.highValueTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.highValueTextBox.Name = "highValueTextBox";
            this.highValueTextBox.Size = new System.Drawing.Size(132, 27);
            this.highValueTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(42, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Range and intervals:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(4, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter # of intervals";
            // 
            // intervalsTextBox
            // 
            this.intervalsTextBox.ForeColor = System.Drawing.Color.Black;
            this.intervalsTextBox.Location = new System.Drawing.Point(139, 251);
            this.intervalsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.intervalsTextBox.Name = "intervalsTextBox";
            this.intervalsTextBox.Size = new System.Drawing.Size(132, 27);
            this.intervalsTextBox.TabIndex = 6;
            // 
            // calcBtn
            // 
            this.calcBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn.ForeColor = System.Drawing.Color.LightPink;
            this.calcBtn.Location = new System.Drawing.Point(76, 306);
            this.calcBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(133, 35);
            this.calcBtn.TabIndex = 7;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(290, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select Functions";
            // 
            // checkBoxSin
            // 
            this.checkBoxSin.AutoSize = true;
            this.checkBoxSin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxSin.Location = new System.Drawing.Point(325, 125);
            this.checkBoxSin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSin.Name = "checkBoxSin";
            this.checkBoxSin.Size = new System.Drawing.Size(75, 24);
            this.checkBoxSin.TabIndex = 9;
            this.checkBoxSin.Text = "Sin(2θ)";
            this.checkBoxSin.UseVisualStyleBackColor = true;
            // 
            // checkBoxCos
            // 
            this.checkBoxCos.AutoSize = true;
            this.checkBoxCos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxCos.Location = new System.Drawing.Point(325, 160);
            this.checkBoxCos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxCos.Name = "checkBoxCos";
            this.checkBoxCos.Size = new System.Drawing.Size(79, 24);
            this.checkBoxCos.TabIndex = 10;
            this.checkBoxCos.Text = "Cos(3θ)";
            this.checkBoxCos.UseVisualStyleBackColor = true;
            // 
            // checkBoxTan
            // 
            this.checkBoxTan.AutoSize = true;
            this.checkBoxTan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxTan.Location = new System.Drawing.Point(325, 196);
            this.checkBoxTan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxTan.Name = "checkBoxTan";
            this.checkBoxTan.Size = new System.Drawing.Size(69, 24);
            this.checkBoxTan.TabIndex = 11;
            this.checkBoxTan.Text = "Tan(θ)";
            this.checkBoxTan.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.LightPink;
            this.clearBtn.Location = new System.Drawing.Point(261, 306);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(133, 35);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // checkBoxLog
            // 
            this.checkBoxLog.AutoSize = true;
            this.checkBoxLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxLog.Location = new System.Drawing.Point(325, 231);
            this.checkBoxLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxLog.Name = "checkBoxLog";
            this.checkBoxLog.Size = new System.Drawing.Size(72, 24);
            this.checkBoxLog.TabIndex = 13;
            this.checkBoxLog.Text = "Log(θ)";
            this.checkBoxLog.UseVisualStyleBackColor = true;
            // 
            // checkBoxExp
            // 
            this.checkBoxExp.AutoSize = true;
            this.checkBoxExp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxExp.Location = new System.Drawing.Point(325, 266);
            this.checkBoxExp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxExp.Name = "checkBoxExp";
            this.checkBoxExp.Size = new System.Drawing.Size(71, 24);
            this.checkBoxExp.TabIndex = 14;
            this.checkBoxExp.Text = "Exp(θ)";
            this.checkBoxExp.UseVisualStyleBackColor = true;
            // 
            // dgvResults
            // 
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResults.BackgroundColor = System.Drawing.Color.LightPink;
            this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.Location = new System.Drawing.Point(0, 360);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.Size = new System.Drawing.Size(483, 266);
            this.dgvResults.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(53, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(371, 40);
            this.label6.TabIndex = 16;
            this.label6.Text = "FUNCTION CALCULATOR";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(483, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(483, 624);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.checkBoxExp);
            this.Controls.Add(this.checkBoxLog);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.checkBoxTan);
            this.Controls.Add(this.checkBoxCos);
            this.Controls.Add(this.checkBoxSin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.intervalsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.highValueTextBox);
            this.Controls.Add(this.lowValueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Function Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lowValueTextBox;
        private System.Windows.Forms.TextBox highValueTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox intervalsTextBox;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxSin;
        private System.Windows.Forms.CheckBox checkBoxCos;
        private System.Windows.Forms.CheckBox checkBoxTan;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.CheckBox checkBoxLog;
        private System.Windows.Forms.CheckBox checkBoxExp;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

