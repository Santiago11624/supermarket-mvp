
namespace Supermarket_mvp.Views
{
    partial class CategoryView
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
            panelCategoryButtons = new Panel();
            BtnCleaning = new Button();
            BtnGrains = new Button();
            BtnFruits = new Button();
            BtnDairy = new Button();
            BtnMeat = new Button();
            panel1 = new Panel();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageCategoryList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCategory = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCategoryDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            TxtCategoryObservation = new TextBox();
            TxtCategoryName = new TextBox();
            TxtCategoryId = new TextBox();
            panelCategoryButtons.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategory).BeginInit();
            tabPageCategoryDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panelCategoryButtons
            // 
            panelCategoryButtons.Controls.Add(BtnCleaning);
            panelCategoryButtons.Controls.Add(BtnGrains);
            panelCategoryButtons.Controls.Add(BtnFruits);
            panelCategoryButtons.Controls.Add(BtnDairy);
            panelCategoryButtons.Controls.Add(BtnMeat);
            panelCategoryButtons.Dock = DockStyle.Left;
            panelCategoryButtons.Location = new Point(0, 0);
            panelCategoryButtons.Name = "panelCategoryButtons";
            panelCategoryButtons.Size = new Size(178, 586);
            panelCategoryButtons.TabIndex = 0;
            // 
            // BtnCleaning
            // 
            BtnCleaning.BackgroundImage = Properties.Resources.productos_de_higiene;
            BtnCleaning.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCleaning.Location = new Point(50, 494);
            BtnCleaning.Name = "BtnCleaning";
            BtnCleaning.Size = new Size(80, 80);
            BtnCleaning.TabIndex = 4;
            BtnCleaning.UseVisualStyleBackColor = true;
            // 
            // BtnGrains
            // 
            BtnGrains.BackgroundImage = Properties.Resources.comida;
            BtnGrains.BackgroundImageLayout = ImageLayout.Zoom;
            BtnGrains.Location = new Point(50, 377);
            BtnGrains.Name = "BtnGrains";
            BtnGrains.Size = new Size(80, 80);
            BtnGrains.TabIndex = 3;
            BtnGrains.UseVisualStyleBackColor = true;
            BtnGrains.Click += BtnGrains_Click;
            // 
            // BtnFruits
            // 
            BtnFruits.BackgroundImage = Properties.Resources.comida_sana;
            BtnFruits.BackgroundImageLayout = ImageLayout.Zoom;
            BtnFruits.Location = new Point(50, 260);
            BtnFruits.Name = "BtnFruits";
            BtnFruits.Size = new Size(80, 80);
            BtnFruits.TabIndex = 2;
            BtnFruits.UseVisualStyleBackColor = true;
            // 
            // BtnDairy
            // 
            BtnDairy.BackgroundImage = Properties.Resources.productos_lacteos;
            BtnDairy.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDairy.Location = new Point(50, 142);
            BtnDairy.Name = "BtnDairy";
            BtnDairy.Size = new Size(80, 80);
            BtnDairy.TabIndex = 1;
            BtnDairy.UseVisualStyleBackColor = true;
            // 
            // BtnMeat
            // 
            BtnMeat.BackgroundImage = Properties.Resources.carne;
            BtnMeat.BackgroundImageLayout = ImageLayout.Zoom;
            BtnMeat.Location = new Point(50, 29);
            BtnMeat.Name = "BtnMeat";
            BtnMeat.Size = new Size(80, 80);
            BtnMeat.TabIndex = 0;
            BtnMeat.UseVisualStyleBackColor = true;
            BtnMeat.Click += BtnMeat_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(178, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 125);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 39);
            label1.Name = "label1";
            label1.Size = new Size(189, 46);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoryList);
            tabControl1.Controls.Add(tabPageCategoryDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(178, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(824, 461);
            tabControl1.TabIndex = 2;
            // 
            // tabPageCategoryList
            // 
            tabPageCategoryList.Controls.Add(BtnClose);
            tabPageCategoryList.Controls.Add(BtnDelete);
            tabPageCategoryList.Controls.Add(BtnEdit);
            tabPageCategoryList.Controls.Add(BtnNew);
            tabPageCategoryList.Controls.Add(DgCategory);
            tabPageCategoryList.Controls.Add(BtnSearch);
            tabPageCategoryList.Controls.Add(TxtSearch);
            tabPageCategoryList.Controls.Add(label2);
            tabPageCategoryList.Location = new Point(4, 29);
            tabPageCategoryList.Name = "tabPageCategoryList";
            tabPageCategoryList.Padding = new Padding(3);
            tabPageCategoryList.Size = new Size(816, 428);
            tabPageCategoryList.TabIndex = 0;
            tabPageCategoryList.Text = "Category List";
            tabPageCategoryList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(626, 351);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(182, 69);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(626, 273);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(182, 59);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += button4_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(626, 188);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(182, 59);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(626, 106);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(182, 59);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgCategory
            // 
            DgCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategory.Location = new Point(25, 106);
            DgCategory.Name = "DgCategory";
            DgCategory.RowHeadersWidth = 51;
            DgCategory.Size = new Size(595, 314);
            DgCategory.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(560, 33);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(60, 60);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(25, 66);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data  To Search";
            TxtSearch.Size = new Size(529, 27);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 30);
            label2.Name = "label2";
            label2.Size = new Size(142, 23);
            label2.TabIndex = 0;
            label2.Text = "Search Category";
            // 
            // tabPageCategoryDetail
            // 
            tabPageCategoryDetail.Controls.Add(BtnCancel);
            tabPageCategoryDetail.Controls.Add(BtnSave);
            tabPageCategoryDetail.Controls.Add(label5);
            tabPageCategoryDetail.Controls.Add(label4);
            tabPageCategoryDetail.Controls.Add(label3);
            tabPageCategoryDetail.Controls.Add(TxtCategoryObservation);
            tabPageCategoryDetail.Controls.Add(TxtCategoryName);
            tabPageCategoryDetail.Controls.Add(TxtCategoryId);
            tabPageCategoryDetail.Location = new Point(4, 29);
            tabPageCategoryDetail.Name = "tabPageCategoryDetail";
            tabPageCategoryDetail.Padding = new Padding(3);
            tabPageCategoryDetail.RightToLeft = RightToLeft.Yes;
            tabPageCategoryDetail.Size = new Size(816, 428);
            tabPageCategoryDetail.TabIndex = 1;
            tabPageCategoryDetail.Text = "Category Detail";
            tabPageCategoryDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(642, 315);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 80);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(508, 315);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 80);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 195);
            label5.Name = "label5";
            label5.Size = new Size(159, 20);
            label5.TabIndex = 5;
            label5.Text = "CategoryObservation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 106);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 4;
            label4.Text = "CategoryName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 18);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 3;
            label3.Text = "CategoryId";
            // 
            // TxtCategoryObservation
            // 
            TxtCategoryObservation.Location = new Point(38, 223);
            TxtCategoryObservation.Multiline = true;
            TxtCategoryObservation.Name = "TxtCategoryObservation";
            TxtCategoryObservation.Size = new Size(376, 114);
            TxtCategoryObservation.TabIndex = 2;
            // 
            // TxtCategoryName
            // 
            TxtCategoryName.Location = new Point(38, 142);
            TxtCategoryName.Name = "TxtCategoryName";
            TxtCategoryName.Size = new Size(254, 27);
            TxtCategoryName.TabIndex = 1;
            // 
            // TxtCategoryId
            // 
            TxtCategoryId.Location = new Point(38, 53);
            TxtCategoryId.Name = "TxtCategoryId";
            TxtCategoryId.ReadOnly = true;
            TxtCategoryId.Size = new Size(125, 27);
            TxtCategoryId.TabIndex = 0;
            TxtCategoryId.Text = "0";
            // 
            // CategoryView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 586);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(panelCategoryButtons);
            Name = "CategoryView";
            Text = "CategoryView";
            panelCategoryButtons.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageCategoryList.ResumeLayout(false);
            tabPageCategoryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategory).EndInit();
            tabPageCategoryDetail.ResumeLayout(false);
            tabPageCategoryDetail.PerformLayout();
            ResumeLayout(false);
        }

        private void BtnGrains_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnMeat_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panelCategoryButtons;
        private Button BtnCleaning;
        private Button BtnGrains;
        private Button BtnFruits;
        private Button BtnDairy;
        private Button BtnMeat;
        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCategoryList;
        private TabPage tabPageCategoryDetail;
        private DataGridView DgCategory;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private TextBox TxtCategoryObservation;
        private TextBox TxtCategoryName;
        private TextBox TxtCategoryId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button BtnSave;
        private Button BtnCancel;
    }
}