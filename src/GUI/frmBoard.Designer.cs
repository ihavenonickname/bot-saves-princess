namespace GUI
{
    partial class frmBoard
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
            this.dgvBoard = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.wrkFinder = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboFinder = new System.Windows.Forms.ComboBox();
            this.cboNeighborhood = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.wrkPath = new System.ComponentModel.BackgroundWorker();
            this.cboSelection = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoard)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBoard.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBoard.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBoard.EnableHeadersVisualStyles = false;
            this.dgvBoard.Location = new System.Drawing.Point(15, 65);
            this.dgvBoard.MultiSelect = false;
            this.dgvBoard.Name = "dgvBoard";
            this.dgvBoard.ReadOnly = true;
            this.dgvBoard.RowHeadersVisible = false;
            this.dgvBoard.Size = new System.Drawing.Size(732, 394);
            this.dgvBoard.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cboSelection);
            this.groupBox1.Controls.Add(this.btnClearAll);
            this.groupBox1.Location = new System.Drawing.Point(74, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 47);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(133, 15);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 8;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFind.Location = new System.Drawing.Point(609, 29);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(78, 23);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // wrkFinder
            // 
            this.wrkFinder.WorkerSupportsCancellation = true;
            this.wrkFinder.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wrkFinder_DoWork);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.cboFinder);
            this.groupBox2.Location = new System.Drawing.Point(294, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 46);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Path";
            // 
            // cboFinder
            // 
            this.cboFinder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFinder.FormattingEnabled = true;
            this.cboFinder.Location = new System.Drawing.Point(6, 17);
            this.cboFinder.Name = "cboFinder";
            this.cboFinder.Size = new System.Drawing.Size(132, 21);
            this.cboFinder.TabIndex = 10;
            // 
            // cboNeighborhood
            // 
            this.cboNeighborhood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNeighborhood.FormattingEnabled = true;
            this.cboNeighborhood.Location = new System.Drawing.Point(6, 16);
            this.cboNeighborhood.Name = "cboNeighborhood";
            this.cboNeighborhood.Size = new System.Drawing.Size(138, 21);
            this.cboNeighborhood.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.cboNeighborhood);
            this.groupBox3.Location = new System.Drawing.Point(449, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 46);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Neighborhood generation";
            // 
            // wrkPath
            // 
            this.wrkPath.WorkerReportsProgress = true;
            this.wrkPath.WorkerSupportsCancellation = true;
            this.wrkPath.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wrkPath_DoWork);
            // 
            // cboSelection
            // 
            this.cboSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelection.FormattingEnabled = true;
            this.cboSelection.Location = new System.Drawing.Point(6, 17);
            this.cboSelection.Name = "cboSelection";
            this.cboSelection.Size = new System.Drawing.Size(121, 21);
            this.cboSelection.TabIndex = 12;
            // 
            // frmBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 471);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bot Saves Princess";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoard)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBoard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.ComponentModel.BackgroundWorker wrkFinder;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboFinder;
        private System.Windows.Forms.ComboBox cboNeighborhood;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker wrkPath;
        private System.Windows.Forms.ComboBox cboSelection;
    }
}

