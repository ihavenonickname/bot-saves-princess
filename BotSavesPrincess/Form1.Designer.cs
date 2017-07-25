namespace BotSavesPrincess
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBoard = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radClean = new System.Windows.Forms.RadioButton();
            this.radWall = new System.Windows.Forms.RadioButton();
            this.radPrincess = new System.Windows.Forms.RadioButton();
            this.radHero = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.wrkFinder = new System.ComponentModel.BackgroundWorker();
            this.btnClearAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoard)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBoard
            // 
            this.dgvBoard.AllowUserToAddRows = false;
            this.dgvBoard.AllowUserToDeleteRows = false;
            this.dgvBoard.AllowUserToResizeColumns = false;
            this.dgvBoard.AllowUserToResizeRows = false;
            this.dgvBoard.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBoard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoard.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBoard.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBoard.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBoard.EnableHeadersVisualStyles = false;
            this.dgvBoard.Location = new System.Drawing.Point(15, 65);
            this.dgvBoard.MultiSelect = false;
            this.dgvBoard.Name = "dgvBoard";
            this.dgvBoard.ReadOnly = true;
            this.dgvBoard.RowHeadersVisible = false;
            this.dgvBoard.Size = new System.Drawing.Size(493, 394);
            this.dgvBoard.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.radClean);
            this.groupBox1.Controls.Add(this.radWall);
            this.groupBox1.Controls.Add(this.radPrincess);
            this.groupBox1.Controls.Add(this.radHero);
            this.groupBox1.Location = new System.Drawing.Point(61, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 47);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection";
            // 
            // radClean
            // 
            this.radClean.AutoSize = true;
            this.radClean.Location = new System.Drawing.Point(183, 19);
            this.radClean.Name = "radClean";
            this.radClean.Size = new System.Drawing.Size(52, 17);
            this.radClean.TabIndex = 3;
            this.radClean.TabStop = true;
            this.radClean.Text = "Clean";
            this.radClean.UseVisualStyleBackColor = true;
            // 
            // radWall
            // 
            this.radWall.AutoSize = true;
            this.radWall.Checked = true;
            this.radWall.Location = new System.Drawing.Point(131, 19);
            this.radWall.Name = "radWall";
            this.radWall.Size = new System.Drawing.Size(46, 17);
            this.radWall.TabIndex = 2;
            this.radWall.TabStop = true;
            this.radWall.Text = "Wall";
            this.radWall.UseVisualStyleBackColor = true;
            // 
            // radPrincess
            // 
            this.radPrincess.AutoSize = true;
            this.radPrincess.Location = new System.Drawing.Point(60, 19);
            this.radPrincess.Name = "radPrincess";
            this.radPrincess.Size = new System.Drawing.Size(65, 17);
            this.radPrincess.TabIndex = 1;
            this.radPrincess.Text = "Princess";
            this.radPrincess.UseVisualStyleBackColor = true;
            // 
            // radHero
            // 
            this.radHero.AutoSize = true;
            this.radHero.Location = new System.Drawing.Point(6, 19);
            this.radHero.Name = "radHero";
            this.radHero.Size = new System.Drawing.Size(48, 17);
            this.radHero.TabIndex = 0;
            this.radHero.Text = "Hero";
            this.radHero.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFind.Location = new System.Drawing.Point(310, 24);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(70, 23);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // wrkFinder
            // 
            this.wrkFinder.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wrkFinder_DoWork);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClearAll.Location = new System.Drawing.Point(386, 24);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 8;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 471);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bot Saves Princess";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoard)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBoard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radWall;
        private System.Windows.Forms.RadioButton radPrincess;
        private System.Windows.Forms.RadioButton radHero;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.RadioButton radClean;
        private System.ComponentModel.BackgroundWorker wrkFinder;
        private System.Windows.Forms.Button btnClearAll;
    }
}

