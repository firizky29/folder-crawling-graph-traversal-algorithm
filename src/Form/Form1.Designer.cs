
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbx_input = new System.Windows.Forms.GroupBox();
            this.rdb_dfs = new System.Windows.Forms.RadioButton();
            this.rdb_bfs = new System.Windows.Forms.RadioButton();
            this.txb_file_name = new System.Windows.Forms.TextBox();
            this.lbl_file_name = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.lbl_folder = new System.Windows.Forms.Label();
            this.gbx_output = new System.Windows.Forms.GroupBox();
            this.gViewer1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.ResultBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbx_input.SuspendLayout();
            this.gbx_output.SuspendLayout();
            this.ResultBox.SuspendLayout();
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
            this.gbx_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbx_input.Controls.Add(this.rdb_dfs);
            this.gbx_input.Controls.Add(this.rdb_bfs);
            this.gbx_input.Controls.Add(this.txb_file_name);
            this.gbx_input.Controls.Add(this.lbl_file_name);
            this.gbx_input.Controls.Add(this.btn_browse);
            this.gbx_input.Controls.Add(this.lbl_folder);
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
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
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
            this.gbx_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_output.Controls.Add(this.gViewer1);
            this.gbx_output.Location = new System.Drawing.Point(206, 0);
            this.gbx_output.Name = "gbx_output";
            this.gbx_output.Size = new System.Drawing.Size(582, 355);
            this.gbx_output.TabIndex = 3;
            this.gbx_output.TabStop = false;
            this.gbx_output.Text = "Output";
            // 
            // gViewer1
            // 
            this.gViewer1.ArrowheadLength = 10D;
            this.gViewer1.AsyncLayout = false;
            this.gViewer1.AutoScroll = true;
            this.gViewer1.BackwardEnabled = false;
            this.gViewer1.BuildHitTree = true;
            this.gViewer1.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gViewer1.EdgeInsertButtonVisible = true;
            this.gViewer1.FileName = "";
            this.gViewer1.ForwardEnabled = false;
            this.gViewer1.Graph = null;
            this.gViewer1.InsertingEdge = false;
            this.gViewer1.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer1.LayoutEditingEnabled = true;
            this.gViewer1.Location = new System.Drawing.Point(3, 18);
            this.gViewer1.LooseOffsetForRouting = 0.25D;
            this.gViewer1.MouseHitDistance = 0.05D;
            this.gViewer1.Name = "gViewer1";
            this.gViewer1.NavigationVisible = true;
            this.gViewer1.NeedToCalculateLayout = true;
            this.gViewer1.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer1.PaddingForEdgeRouting = 8D;
            this.gViewer1.PanButtonPressed = false;
            this.gViewer1.SaveAsImageEnabled = true;
            this.gViewer1.SaveAsMsaglEnabled = true;
            this.gViewer1.SaveButtonVisible = true;
            this.gViewer1.SaveGraphButtonVisible = true;
            this.gViewer1.SaveInVectorFormatEnabled = true;
            this.gViewer1.Size = new System.Drawing.Size(576, 334);
            this.gViewer1.TabIndex = 0;
            this.gViewer1.TightOffsetForRouting = 0.125D;
            this.gViewer1.ToolBarIsVisible = true;
            this.gViewer1.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("gViewer1.Transform")));
            this.gViewer1.UndoRedoButtonsVisible = true;
            this.gViewer1.WindowZoomButtonPressed = false;
            this.gViewer1.ZoomF = 1D;
            this.gViewer1.ZoomWindowThreshold = 0.05D;
            // 
            // ResultBox
            // 
            this.ResultBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultBox.Controls.Add(this.label1);
            this.ResultBox.Location = new System.Drawing.Point(206, 361);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(582, 83);
            this.ResultBox.TabIndex = 4;
            this.ResultBox.TabStop = false;
            this.ResultBox.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.gbx_output);
            this.Controls.Add(this.gbx_input);
            this.Name = "Form1";
            this.Text = "Folder Crawling";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbx_input.ResumeLayout(false);
            this.gbx_input.PerformLayout();
            this.gbx_output.ResumeLayout(false);
            this.ResultBox.ResumeLayout(false);
            this.ResultBox.PerformLayout();
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
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer1;
        private System.Windows.Forms.GroupBox ResultBox;
        private System.Windows.Forms.Label label1;
    }
}

