﻿namespace NetworkRenameTool {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.NetworksGrid = new System.Windows.Forms.DataGridView();
            this.KeyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NetworksGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NetworksGrid
            // 
            this.NetworksGrid.AllowUserToAddRows = false;
            this.NetworksGrid.AllowUserToResizeColumns = false;
            this.NetworksGrid.AllowUserToResizeRows = false;
            this.NetworksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NetworksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KeyColumn,
            this.NameColumn,
            this.DescriptionColumn,
            this.Category});
            this.NetworksGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NetworksGrid.Location = new System.Drawing.Point(0, 0);
            this.NetworksGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NetworksGrid.Name = "NetworksGrid";
            this.NetworksGrid.RowHeadersWidth = 51;
            this.NetworksGrid.Size = new System.Drawing.Size(1072, 301);
            this.NetworksGrid.TabIndex = 0;
            this.NetworksGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.NetworksGrid_CellValueChanged);
            this.NetworksGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.NetworksGrid_UserDeletingRow);
            this.NetworksGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NetworksGrid_KeyDown);
            // 
            // KeyColumn
            // 
            this.KeyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.KeyColumn.HeaderText = "Registry Key";
            this.KeyColumn.MinimumWidth = 6;
            this.KeyColumn.Name = "KeyColumn";
            this.KeyColumn.ReadOnly = true;
            this.KeyColumn.Width = 6;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Profile Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ToolTipText = "The name is displayed on connection list.";
            this.NameColumn.Width = 250;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.MinimumWidth = 6;
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ToolTipText = "This description is not actually displayed anywhere.";
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category.HeaderText = "Category (0pub/1priv/2dom)";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ToolTipText = "Category indicates whether this network is public or private, so different securi" +
    "ty policies can apply.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 301);
            this.Controls.Add(this.NetworksGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Network Rename Tool";
            ((System.ComponentModel.ISupportInitialize)(this.NetworksGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView NetworksGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
    }
}

