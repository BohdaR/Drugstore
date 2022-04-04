
namespace Drugstore
{
    partial class CategoriesForm
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.dataSet1 = new Drugstore.DataSet1();
            this.use_categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.use_categoriesTableAdapter = new Drugstore.DataSet1TableAdapters.use_categoriesTableAdapter();
            this.tableAdapterManager = new Drugstore.DataSet1TableAdapters.TableAdapterManager();
            this.use_categoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addFieldbutton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchCanselButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.FilterInput = new System.Windows.Forms.TextBox();
            this.drug_formTableAdapter = new Drugstore.DataSet1TableAdapters.drug_formTableAdapter();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.use_categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.use_categoriesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // use_categoriesBindingSource
            // 
            this.use_categoriesBindingSource.DataMember = "use_categories";
            this.use_categoriesBindingSource.DataSource = this.dataSet1;
            // 
            // use_categoriesTableAdapter
            // 
            this.use_categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.brendTableAdapter = null;
            this.tableAdapterManager.drug_formTableAdapter = null;
            this.tableAdapterManager.drugsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Drugstore.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.use_categoriesTableAdapter = this.use_categoriesTableAdapter;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // use_categoriesDataGridView
            // 
            this.use_categoriesDataGridView.AutoGenerateColumns = false;
            this.use_categoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.use_categoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.use_categoriesDataGridView.DataSource = this.use_categoriesBindingSource;
            this.use_categoriesDataGridView.Location = new System.Drawing.Point(12, 79);
            this.use_categoriesDataGridView.Name = "use_categoriesDataGridView";
            this.use_categoriesDataGridView.Size = new System.Drawing.Size(636, 220);
            this.use_categoriesDataGridView.TabIndex = 28;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn3.HeaderText = "description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.countLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.countLabel.Location = new System.Drawing.Point(503, 311);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(145, 38);
            this.countLabel.TabIndex = 33;
            this.countLabel.Text = "Усього: ?";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Location = new System.Drawing.Point(137, 305);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(113, 44);
            this.deleteButton.TabIndex = 35;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // addFieldbutton
            // 
            this.addFieldbutton.BackColor = System.Drawing.Color.DarkMagenta;
            this.addFieldbutton.FlatAppearance.BorderSize = 0;
            this.addFieldbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFieldbutton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFieldbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.addFieldbutton.Location = new System.Drawing.Point(20, 305);
            this.addFieldbutton.Name = "addFieldbutton";
            this.addFieldbutton.Size = new System.Drawing.Size(97, 44);
            this.addFieldbutton.TabIndex = 34;
            this.addFieldbutton.Text = "Add";
            this.addFieldbutton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Green;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(680, 309);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(299, 36);
            this.saveButton.TabIndex = 36;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(673, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 38);
            this.label1.TabIndex = 49;
            this.label1.Text = "EDITOR";
            // 
            // searchCanselButton
            // 
            this.searchCanselButton.AutoSize = true;
            this.searchCanselButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.searchCanselButton.FlatAppearance.BorderSize = 0;
            this.searchCanselButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCanselButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.searchCanselButton.ForeColor = System.Drawing.SystemColors.Control;
            this.searchCanselButton.Location = new System.Drawing.Point(535, 23);
            this.searchCanselButton.Name = "searchCanselButton";
            this.searchCanselButton.Size = new System.Drawing.Size(113, 37);
            this.searchCanselButton.TabIndex = 48;
            this.searchCanselButton.Text = "Cancel";
            this.searchCanselButton.UseVisualStyleBackColor = false;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.searchButton.Location = new System.Drawing.Point(382, 23);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 37);
            this.searchButton.TabIndex = 47;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // FilterInput
            // 
            this.FilterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FilterInput.Location = new System.Drawing.Point(12, 27);
            this.FilterInput.Name = "FilterInput";
            this.FilterInput.Size = new System.Drawing.Size(347, 30);
            this.FilterInput.TabIndex = 46;
            // 
            // drug_formTableAdapter
            // 
            this.drug_formTableAdapter.ClearBeforeFill = true;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            idLabel.ForeColor = System.Drawing.SystemColors.Control;
            idLabel.Location = new System.Drawing.Point(683, 82);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(36, 27);
            idLabel.TabIndex = 49;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.use_categoriesBindingSource, "id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.idTextBox.Location = new System.Drawing.Point(820, 89);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(159, 30);
            this.idTextBox.TabIndex = 50;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            nameLabel.Location = new System.Drawing.Point(683, 158);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(67, 27);
            nameLabel.TabIndex = 51;
            nameLabel.Text = "name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.use_categoriesBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nameTextBox.Location = new System.Drawing.Point(820, 165);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(159, 30);
            this.nameTextBox.TabIndex = 52;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            descriptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            descriptionLabel.Location = new System.Drawing.Point(683, 237);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(119, 27);
            descriptionLabel.TabIndex = 53;
            descriptionLabel.Text = "description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.use_categoriesBindingSource, "description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.descriptionTextBox.Location = new System.Drawing.Point(820, 237);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(159, 30);
            this.descriptionTextBox.TabIndex = 54;
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(999, 373);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchCanselButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.FilterInput);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addFieldbutton);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.use_categoriesDataGridView);
            this.Name = "CategoriesForm";
            this.Text = "CategoriesForm";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.use_categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.use_categoriesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource use_categoriesBindingSource;
        private DataSet1TableAdapters.use_categoriesTableAdapter use_categoriesTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView use_categoriesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addFieldbutton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchCanselButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox FilterInput;
        private DataSet1TableAdapters.drug_formTableAdapter drug_formTableAdapter;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}