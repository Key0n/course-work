namespace CPZ
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AccountView = new System.Windows.Forms.TreeView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.helperPanel = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.helperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountView
            // 
            this.AccountView.BackColor = System.Drawing.Color.White;
            this.AccountView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountView.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountView.ForeColor = System.Drawing.Color.Black;
            this.AccountView.Location = new System.Drawing.Point(0, 0);
            this.AccountView.Margin = new System.Windows.Forms.Padding(2);
            this.AccountView.Name = "AccountView";
            this.AccountView.Size = new System.Drawing.Size(574, 454);
            this.AccountView.TabIndex = 22;
            this.AccountView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.AccountView_BeforeExpand);
            this.AccountView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.AccountView_NodeMouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(8, 8);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 31);
            this.btnAdd.TabIndex = 63;
            this.btnAdd.Tag = "themeable";
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.Silver;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(8, 79);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 34);
            this.btnRemove.TabIndex = 64;
            this.btnRemove.Tag = "themeable";
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.BackColor = System.Drawing.Color.Silver;
            this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModify.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnModify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnModify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(8, 42);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(88, 34);
            this.btnModify.TabIndex = 65;
            this.btnModify.Tag = "themeable";
            this.btnModify.Text = "Изменить";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Controls.Add(this.AccountView);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(576, 456);
            this.leftPanel.TabIndex = 71;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.White;
            this.rightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightPanel.Controls.Add(this.btnAdd);
            this.rightPanel.Controls.Add(this.btnRemove);
            this.rightPanel.Controls.Add(this.btnModify);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(576, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(106, 491);
            this.rightPanel.TabIndex = 72;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.txtSearch);
            this.topPanel.Controls.Add(this.label27);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(576, 35);
            this.topPanel.TabIndex = 73;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(63, 3);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(508, 22);
            this.txtSearch.TabIndex = 74;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(2, 3);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 21);
            this.label27.TabIndex = 71;
            this.label27.Tag = "themeable";
            this.label27.Text = "Поиск:";
            // 
            // helperPanel
            // 
            this.helperPanel.Controls.Add(this.leftPanel);
            this.helperPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helperPanel.Location = new System.Drawing.Point(0, 35);
            this.helperPanel.Margin = new System.Windows.Forms.Padding(2);
            this.helperPanel.Name = "helperPanel";
            this.helperPanel.Size = new System.Drawing.Size(576, 456);
            this.helperPanel.TabIndex = 74;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(682, 491);
            this.Controls.Add(this.helperPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.rightPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPZ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.helperPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView AccountView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel helperPanel;
    }
}