
namespace Drugstore
{
    partial class BrendForm
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
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label countryLabel1;
            System.Windows.Forms.Label company_profitLabel1;
            System.Windows.Forms.Label manufacturers_productsLabel1;
            System.Windows.Forms.Label ratingLabel1;
            this.searchCanselButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addFieldbutton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.FilterInput = new System.Windows.Forms.TextBox();
            this.dataSet1 = new Drugstore.DataSet1();
            this.brendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brendTableAdapter = new Drugstore.DataSet1TableAdapters.brendTableAdapter();
            this.tableAdapterManager = new Drugstore.DataSet1TableAdapters.TableAdapterManager();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.countryTextBox1 = new System.Windows.Forms.TextBox();
            this.company_profitTextBox1 = new System.Windows.Forms.TextBox();
            this.manufacturers_productsTextBox1 = new System.Windows.Forms.TextBox();
            this.ratingTextBox1 = new System.Windows.Forms.TextBox();
            this.brendDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            countryLabel1 = new System.Windows.Forms.Label();
            company_profitLabel1 = new System.Windows.Forms.Label();
            manufacturers_productsLabel1 = new System.Windows.Forms.Label();
            ratingLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brendBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brendDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            idLabel1.ForeColor = System.Drawing.SystemColors.Control;
            idLabel1.Location = new System.Drawing.Point(675, 70);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(36, 27);
            idLabel1.TabIndex = 33;
            idLabel1.Text = "id:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            nameLabel1.ForeColor = System.Drawing.SystemColors.Control;
            nameLabel1.Location = new System.Drawing.Point(675, 110);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(67, 27);
            nameLabel1.TabIndex = 35;
            nameLabel1.Text = "name:";
            // 
            // countryLabel1
            // 
            countryLabel1.AutoSize = true;
            countryLabel1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            countryLabel1.ForeColor = System.Drawing.SystemColors.Control;
            countryLabel1.Location = new System.Drawing.Point(675, 150);
            countryLabel1.Name = "countryLabel1";
            countryLabel1.Size = new System.Drawing.Size(89, 27);
            countryLabel1.TabIndex = 37;
            countryLabel1.Text = "country:";
            // 
            // company_profitLabel1
            // 
            company_profitLabel1.AutoSize = true;
            company_profitLabel1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            company_profitLabel1.ForeColor = System.Drawing.SystemColors.Control;
            company_profitLabel1.Location = new System.Drawing.Point(675, 190);
            company_profitLabel1.Name = "company_profitLabel1";
            company_profitLabel1.Size = new System.Drawing.Size(158, 27);
            company_profitLabel1.TabIndex = 39;
            company_profitLabel1.Text = "company profit:";
            company_profitLabel1.Click += new System.EventHandler(this.company_profitLabel1_Click);
            // 
            // manufacturers_productsLabel1
            // 
            manufacturers_productsLabel1.AutoSize = true;
            manufacturers_productsLabel1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            manufacturers_productsLabel1.ForeColor = System.Drawing.SystemColors.Control;
            manufacturers_productsLabel1.Location = new System.Drawing.Point(675, 230);
            manufacturers_productsLabel1.Name = "manufacturers_productsLabel1";
            manufacturers_productsLabel1.Size = new System.Drawing.Size(98, 27);
            manufacturers_productsLabel1.TabIndex = 41;
            manufacturers_productsLabel1.Text = "products:";
            // 
            // ratingLabel1
            // 
            ratingLabel1.AutoSize = true;
            ratingLabel1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            ratingLabel1.ForeColor = System.Drawing.SystemColors.Control;
            ratingLabel1.Location = new System.Drawing.Point(675, 270);
            ratingLabel1.Name = "ratingLabel1";
            ratingLabel1.Size = new System.Drawing.Size(74, 27);
            ratingLabel1.TabIndex = 43;
            ratingLabel1.Text = "rating:";
            // 
            // searchCanselButton
            // 
            this.searchCanselButton.AutoSize = true;
            this.searchCanselButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.searchCanselButton.FlatAppearance.BorderSize = 0;
            this.searchCanselButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCanselButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.searchCanselButton.ForeColor = System.Drawing.SystemColors.Control;
            this.searchCanselButton.Location = new System.Drawing.Point(535, 27);
            this.searchCanselButton.Name = "searchCanselButton";
            this.searchCanselButton.Size = new System.Drawing.Size(113, 37);
            this.searchCanselButton.TabIndex = 18;
            this.searchCanselButton.Text = "Cancel";
            this.searchCanselButton.UseVisualStyleBackColor = false;
            this.searchCanselButton.Click += new System.EventHandler(this.searchCanselButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.searchButton.Location = new System.Drawing.Point(382, 27);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 37);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Location = new System.Drawing.Point(131, 313);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(113, 44);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addFieldbutton
            // 
            this.addFieldbutton.BackColor = System.Drawing.Color.DarkMagenta;
            this.addFieldbutton.FlatAppearance.BorderSize = 0;
            this.addFieldbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFieldbutton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFieldbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.addFieldbutton.Location = new System.Drawing.Point(12, 313);
            this.addFieldbutton.Name = "addFieldbutton";
            this.addFieldbutton.Size = new System.Drawing.Size(97, 44);
            this.addFieldbutton.TabIndex = 11;
            this.addFieldbutton.Text = "Add";
            this.addFieldbutton.UseVisualStyleBackColor = false;
            this.addFieldbutton.Click += new System.EventHandler(this.addFieldbutton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Green;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(680, 317);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(299, 36);
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.countLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.countLabel.Location = new System.Drawing.Point(503, 317);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(145, 38);
            this.countLabel.TabIndex = 32;
            this.countLabel.Text = "Усього: ?";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(125, 175);
            // 
            // FilterInput
            // 
            this.FilterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FilterInput.Location = new System.Drawing.Point(12, 31);
            this.FilterInput.Name = "FilterInput";
            this.FilterInput.Size = new System.Drawing.Size(347, 30);
            this.FilterInput.TabIndex = 16;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brendBindingSource
            // 
            this.brendBindingSource.DataMember = "brend";
            this.brendBindingSource.DataSource = this.dataSet1;
            // 
            // brendTableAdapter
            // 
            this.brendTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.brendTableAdapter = this.brendTableAdapter;
            this.tableAdapterManager.drug_formTableAdapter = null;
            this.tableAdapterManager.drugsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Drugstore.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.use_categoriesTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brendBindingSource, "id", true));
            this.idTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.idTextBox1.Location = new System.Drawing.Point(834, 68);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(145, 30);
            this.idTextBox1.TabIndex = 34;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brendBindingSource, "name", true));
            this.nameTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nameTextBox1.Location = new System.Drawing.Point(834, 108);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(145, 30);
            this.nameTextBox1.TabIndex = 36;
            // 
            // countryTextBox1
            // 
            this.countryTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brendBindingSource, "country", true));
            this.countryTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.countryTextBox1.Location = new System.Drawing.Point(834, 148);
            this.countryTextBox1.Name = "countryTextBox1";
            this.countryTextBox1.Size = new System.Drawing.Size(145, 30);
            this.countryTextBox1.TabIndex = 38;
            // 
            // company_profitTextBox1
            // 
            this.company_profitTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brendBindingSource, "company_profit", true));
            this.company_profitTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.company_profitTextBox1.Location = new System.Drawing.Point(834, 188);
            this.company_profitTextBox1.Name = "company_profitTextBox1";
            this.company_profitTextBox1.Size = new System.Drawing.Size(145, 30);
            this.company_profitTextBox1.TabIndex = 40;
            // 
            // manufacturers_productsTextBox1
            // 
            this.manufacturers_productsTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brendBindingSource, "manufacturers_products", true));
            this.manufacturers_productsTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.manufacturers_productsTextBox1.Location = new System.Drawing.Point(834, 228);
            this.manufacturers_productsTextBox1.Name = "manufacturers_productsTextBox1";
            this.manufacturers_productsTextBox1.Size = new System.Drawing.Size(145, 30);
            this.manufacturers_productsTextBox1.TabIndex = 42;
            // 
            // ratingTextBox1
            // 
            this.ratingTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.brendBindingSource, "rating", true));
            this.ratingTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ratingTextBox1.Location = new System.Drawing.Point(834, 268);
            this.ratingTextBox1.Name = "ratingTextBox1";
            this.ratingTextBox1.Size = new System.Drawing.Size(145, 30);
            this.ratingTextBox1.TabIndex = 44;
            // 
            // brendDataGridView
            // 
            this.brendDataGridView.AutoGenerateColumns = false;
            this.brendDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.brendDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.brendDataGridView.DataSource = this.brendBindingSource;
            this.brendDataGridView.Location = new System.Drawing.Point(12, 73);
            this.brendDataGridView.Name = "brendDataGridView";
            this.brendDataGridView.Size = new System.Drawing.Size(636, 220);
            this.brendDataGridView.TabIndex = 44;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "country";
            this.dataGridViewTextBoxColumn3.HeaderText = "country";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "company_profit";
            this.dataGridViewTextBoxColumn4.HeaderText = "company_profit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "manufacturers_products";
            this.dataGridViewTextBoxColumn5.HeaderText = "manufacturers_products";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "rating";
            this.dataGridViewTextBoxColumn6.HeaderText = "rating";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(673, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 38);
            this.label1.TabIndex = 45;
            this.label1.Text = "EDITOR";
            // 
            // BrendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1031, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brendDataGridView);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(countryLabel1);
            this.Controls.Add(this.countryTextBox1);
            this.Controls.Add(company_profitLabel1);
            this.Controls.Add(this.company_profitTextBox1);
            this.Controls.Add(manufacturers_productsLabel1);
            this.Controls.Add(this.manufacturers_productsTextBox1);
            this.Controls.Add(ratingLabel1);
            this.Controls.Add(this.ratingTextBox1);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.searchCanselButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.FilterInput);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addFieldbutton);
            this.Name = "BrendForm";
            this.Text = "BrendForm";
            this.Load += new System.EventHandler(this.BrendForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brendBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brendDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchCanselButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addFieldbutton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.TextBox FilterInput;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource brendBindingSource;
        private DataSet1TableAdapters.brendTableAdapter brendTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.TextBox countryTextBox1;
        private System.Windows.Forms.TextBox company_profitTextBox1;
        private System.Windows.Forms.TextBox manufacturers_productsTextBox1;
        private System.Windows.Forms.TextBox ratingTextBox1;
        private System.Windows.Forms.DataGridView brendDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
    }
}