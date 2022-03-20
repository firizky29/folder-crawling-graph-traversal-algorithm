
namespace Folder_Crawling
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbx_input = new System.Windows.Forms.GroupBox();
            this.rdb_dfs = new System.Windows.Forms.RadioButton();
            this.rdb_bfs = new System.Windows.Forms.RadioButton();
            this.txb_file_name = new System.Windows.Forms.TextBox();
            this.lbl_file_name = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.lbl_folder = new System.Windows.Forms.Label();
            this.gbx_output = new System.Windows.Forms.GroupBox();
            this.gbx_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gbx_input
            // 
            this.gbx_input.Controls.Add(this.rdb_dfs);
            this.gbx_input.Controls.Add(this.rdb_bfs);
            this.gbx_input.Controls.Add(this.txb_file_name);
            this.gbx_input.Controls.Add(this.lbl_file_name);
            this.gbx_input.Controls.Add(this.btn_browse);
            this.gbx_input.Controls.Add(this.lbl_folder);
            this.gbx_input.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbx_input.Location = new System.Drawing.Point(0, 0);
            this.gbx_input.Name = "gbx_input";
            this.gbx_input.Size = new System.Drawing.Size(200, 450);
            this.gbx_input.TabIndex = 2;
            this.gbx_input.TabStop = false;
            this.gbx_input.Text = "Input";
            // 
            // rdb_dfs
            // 
            this.rdb_dfs.AutoSize = true;
            this.rdb_dfs.Location = new System.Drawing.Point(12, 218);
            this.rdb_dfs.Name = "rdb_dfs";
            this.rdb_dfs.Size = new System.Drawing.Size(55, 20);
            this.rdb_dfs.TabIndex = 5;
            this.rdb_dfs.TabStop = true;
            this.rdb_dfs.Text = "DFS";
            this.rdb_dfs.UseVisualStyleBackColor = true;
            // 
            // rdb_bfs
            // 
            this.rdb_bfs.AutoSize = true;
            this.rdb_bfs.Location = new System.Drawing.Point(12, 191);
            this.rdb_bfs.Name = "rdb_bfs";
            this.rdb_bfs.Size = new System.Drawing.Size(54, 20);
            this.rdb_bfs.TabIndex = 4;
            this.rdb_bfs.TabStop = true;
            this.rdb_bfs.Text = "BFS";
            this.rdb_bfs.UseVisualStyleBackColor = true;
            // 
            // txb_file_name
            // 
            this.txb_file_name.Location = new System.Drawing.Point(6, 123);
            this.txb_file_name.Name = "txb_file_name";
            this.txb_file_name.Size = new System.Drawing.Size(185, 22);
            this.txb_file_name.TabIndex = 3;
            // 
            // lbl_file_name
            // 
            this.lbl_file_name.AutoSize = true;
            this.lbl_file_name.Location = new System.Drawing.Point(6, 103);
            this.lbl_file_name.Name = "lbl_file_name";
            this.lbl_file_name.Size = new System.Drawing.Size(66, 16);
            this.lbl_file_name.TabIndex = 2;
            this.lbl_file_name.Text = "File name";
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(12, 64);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 1;
            this.btn_browse.Text = "Browse...";
            this.btn_browse.UseVisualStyleBackColor = true;
            // 
            // lbl_folder
            // 
            this.lbl_folder.AutoSize = true;
            this.lbl_folder.Location = new System.Drawing.Point(6, 44);
            this.lbl_folder.Name = "lbl_folder";
            this.lbl_folder.Size = new System.Drawing.Size(46, 16);
            this.lbl_folder.TabIndex = 0;
            this.lbl_folder.Text = "Folder";
            // 
            // gbx_output
            // 
            this.gbx_output.Location = new System.Drawing.Point(206, 0);
            this.gbx_output.Name = "gbx_output";
            this.gbx_output.Size = new System.Drawing.Size(582, 438);
            this.gbx_output.TabIndex = 3;
            this.gbx_output.TabStop = false;
            this.gbx_output.Text = "Output";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbx_output);
            this.Controls.Add(this.gbx_input);
            this.Name = "Form1";
            this.Text = "Folder Crawling";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbx_input.ResumeLayout(false);
            this.gbx_input.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox gbx_input;
        private System.Windows.Forms.GroupBox gbx_output;
        private System.Windows.Forms.Label lbl_folder;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.RadioButton rdb_dfs;
        private System.Windows.Forms.RadioButton rdb_bfs;
        private System.Windows.Forms.TextBox txb_file_name;
        private System.Windows.Forms.Label lbl_file_name;
    }
}

