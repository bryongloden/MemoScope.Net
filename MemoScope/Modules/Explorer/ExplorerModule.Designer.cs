﻿namespace MemoScope.Modules.Explorer
{
    partial class ExplorerModule
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblRootDir = new System.Windows.Forms.Label();
            this.tbRootDir = new System.Windows.Forms.TextBox();
            this.dtlvExplorer = new WinFwk.UITools.DefaultTreeListView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRootDir = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtlvExplorer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRootDir
            // 
            this.lblRootDir.AutoSize = true;
            this.lblRootDir.Location = new System.Drawing.Point(12, 16);
            this.lblRootDir.Name = "lblRootDir";
            this.lblRootDir.Size = new System.Drawing.Size(68, 17);
            this.lblRootDir.TabIndex = 0;
            this.lblRootDir.Text = "Root Dir :";
            // 
            // tbRootDir
            // 
            this.tbRootDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRootDir.Location = new System.Drawing.Point(88, 13);
            this.tbRootDir.Name = "tbRootDir";
            this.tbRootDir.Size = new System.Drawing.Size(300, 22);
            this.tbRootDir.TabIndex = 2;
            this.tbRootDir.TextChanged += new System.EventHandler(this.tbRootDir_TextChanged);
            // 
            // dtlvExplorer
            // 
            this.dtlvExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtlvExplorer.CheckBoxes = true;
            this.dtlvExplorer.DataSource = null;
            this.dtlvExplorer.FullRowSelect = true;
            this.dtlvExplorer.HideSelection = false;
            this.dtlvExplorer.HierarchicalCheckboxes = true;
            this.dtlvExplorer.Location = new System.Drawing.Point(3, 46);
            this.dtlvExplorer.Name = "dtlvExplorer";
            this.dtlvExplorer.OwnerDraw = true;
            this.dtlvExplorer.RootKeyValueString = "";
            this.dtlvExplorer.ShowGroups = false;
            this.dtlvExplorer.ShowImagesOnSubItems = true;
            this.dtlvExplorer.Size = new System.Drawing.Size(461, 583);
            this.dtlvExplorer.TabIndex = 3;
            this.dtlvExplorer.UseCompatibleStateImageBehavior = false;
            this.dtlvExplorer.View = System.Windows.Forms.View.Details;
            this.dtlvExplorer.VirtualMode = true;
            this.dtlvExplorer.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.dtlvExplorer_CellClick);
            // 
            // btnRootDir
            // 
            this.btnRootDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRootDir.Image = global::MemoScope.Properties.Resources.folder_explore;
            this.btnRootDir.Location = new System.Drawing.Point(394, 8);
            this.btnRootDir.Name = "btnRootDir";
            this.btnRootDir.Size = new System.Drawing.Size(32, 32);
            this.btnRootDir.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnRootDir, "Select Root Directory...");
            this.btnRootDir.UseVisualStyleBackColor = true;
            this.btnRootDir.Click += new System.EventHandler(this.btnRootDir_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Image = global::MemoScope.Properties.Resources.database_go;
            this.btnLoad.Location = new System.Drawing.Point(432, 8);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(32, 32);
            this.btnLoad.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnLoad, "Load checked files...");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // ExplorerModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtlvExplorer);
            this.Controls.Add(this.tbRootDir);
            this.Controls.Add(this.btnRootDir);
            this.Controls.Add(this.lblRootDir);
            this.Name = "ExplorerModule";
            this.Size = new System.Drawing.Size(467, 632);
            this.Load += new System.EventHandler(this.ExplorerModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtlvExplorer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRootDir;
        private System.Windows.Forms.Button btnRootDir;
        private System.Windows.Forms.TextBox tbRootDir;
        private WinFwk.UITools.DefaultTreeListView dtlvExplorer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnLoad;
    }
}
