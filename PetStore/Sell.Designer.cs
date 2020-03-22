namespace PetStore
{
    partial class rbbSell
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
            this.rbbSale = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrint = new DevExpress.XtraBars.BarButtonItem();
            this.rbbiSale = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbbpgTasks = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rbbSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbbSale
            // 
            this.rbbSale.ExpandCollapseItem.Id = 0;
            this.rbbSale.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbbSale.ExpandCollapseItem,
            this.rbbSale.SearchEditItem,
            this.bbiAdd,
            this.bbiDelete,
            this.bbiPrint});
            this.rbbSale.Location = new System.Drawing.Point(0, 0);
            this.rbbSale.MaxItemId = 4;
            this.rbbSale.Name = "rbbSale";
            this.rbbSale.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbbiSale});
            this.rbbSale.Size = new System.Drawing.Size(881, 143);
            this.rbbSale.StatusBar = this.ribbonStatusBar;
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "Add";
            this.bbiAdd.Id = 1;
            this.bbiAdd.ImageOptions.ImageUri.Uri = "Add";
            this.bbiAdd.Name = "bbiAdd";
            this.bbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAdd_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Enabled = false;
            this.bbiDelete.Id = 2;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiPrint
            // 
            this.bbiPrint.Caption = "Generate bill and Preview";
            this.bbiPrint.Id = 3;
            this.bbiPrint.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrint.Name = "bbiPrint";
            // 
            // rbbiSale
            // 
            this.rbbiSale.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbbpgTasks});
            this.rbbiSale.Name = "rbbiSale";
            this.rbbiSale.Text = "Sell";
            // 
            // rbbpgTasks
            // 
            this.rbbpgTasks.ItemLinks.Add(this.bbiAdd);
            this.rbbpgTasks.ItemLinks.Add(this.bbiDelete);
            this.rbbpgTasks.ItemLinks.Add(this.bbiPrint);
            this.rbbpgTasks.Name = "rbbpgTasks";
            this.rbbpgTasks.Text = "Tasks";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 519);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.rbbSale;
            this.ribbonStatusBar.Size = new System.Drawing.Size(881, 31);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tblLayout);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 425);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(881, 94);
            this.panelControl1.TabIndex = 2;
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 2;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout.Controls.Add(this.label1, 0, 0);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(2, 2);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 1;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout.Size = new System.Drawing.Size(877, 90);
            this.tblLayout.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(881, 282);
            this.dataGridView1.TabIndex = 6;
            // 
            // rbbSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 550);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.rbbSale);
            this.Name = "rbbSell";
            this.Ribbon = this.rbbSale;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Sell";
            ((System.ComponentModel.ISupportInitialize)(this.rbbSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rbbSale;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbbiSale;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbbpgTasks;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiPrint;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}