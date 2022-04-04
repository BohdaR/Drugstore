
namespace Drugstore
{
    partial class DrugsForm
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
            System.Windows.Forms.Label leave_without_a_prescriptionLabel;
            System.Windows.Forms.Label indicationLabel;
            System.Windows.Forms.Label contraindicationLabel;
            System.Windows.Forms.Label taking_rulesLabel;
            System.Windows.Forms.Label principle_of_operationLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label dosageLabel;
            System.Windows.Forms.Label packagingLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label use_category_idLabel;
            System.Windows.Forms.Label brend_idLabel;
            System.Windows.Forms.Label form_of_drug_idLabel;
            System.Windows.Forms.Label imageLabel;
            this.dataSet1 = new Drugstore.DataSet1();
            this.drugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugsTableAdapter = new Drugstore.DataSet1TableAdapters.drugsTableAdapter();
            this.tableAdapterManager = new Drugstore.DataSet1TableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.searchCanselButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.FilterInput = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addFieldbutton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.leave_without_a_prescriptionCheckBox = new System.Windows.Forms.CheckBox();
            this.indicationTextBox = new System.Windows.Forms.TextBox();
            this.contraindicationTextBox = new System.Windows.Forms.TextBox();
            this.taking_rulesTextBox = new System.Windows.Forms.TextBox();
            this.principle_of_operationTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.dosageTextBox = new System.Windows.Forms.TextBox();
            this.packagingTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.use_category_idTextBox = new System.Windows.Forms.TextBox();
            this.brend_idTextBox = new System.Windows.Forms.TextBox();
            this.form_of_drug_idTextBox = new System.Windows.Forms.TextBox();
            this.drugsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            leave_without_a_prescriptionLabel = new System.Windows.Forms.Label();
            indicationLabel = new System.Windows.Forms.Label();
            contraindicationLabel = new System.Windows.Forms.Label();
            taking_rulesLabel = new System.Windows.Forms.Label();
            principle_of_operationLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            dosageLabel = new System.Windows.Forms.Label();
            packagingLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            use_category_idLabel = new System.Windows.Forms.Label();
            brend_idLabel = new System.Windows.Forms.Label();
            form_of_drug_idLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            idLabel.ForeColor = System.Drawing.SystemColors.Control;
            idLabel.Location = new System.Drawing.Point(825, 87);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(41, 27);
            idLabel.TabIndex = 57;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            nameLabel.Location = new System.Drawing.Point(825, 127);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(67, 27);
            nameLabel.TabIndex = 59;
            nameLabel.Text = "name:";
            // 
            // leave_without_a_prescriptionLabel
            // 
            leave_without_a_prescriptionLabel.AutoSize = true;
            leave_without_a_prescriptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            leave_without_a_prescriptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            leave_without_a_prescriptionLabel.Location = new System.Drawing.Point(825, 167);
            leave_without_a_prescriptionLabel.Name = "leave_without_a_prescriptionLabel";
            leave_without_a_prescriptionLabel.Size = new System.Drawing.Size(276, 27);
            leave_without_a_prescriptionLabel.TabIndex = 61;
            leave_without_a_prescriptionLabel.Text = "leave without a prescription:";
            // 
            // indicationLabel
            // 
            indicationLabel.AutoSize = true;
            indicationLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            indicationLabel.ForeColor = System.Drawing.SystemColors.Control;
            indicationLabel.Location = new System.Drawing.Point(825, 247);
            indicationLabel.Name = "indicationLabel";
            indicationLabel.Size = new System.Drawing.Size(106, 27);
            indicationLabel.TabIndex = 63;
            indicationLabel.Text = "indication:";
            // 
            // contraindicationLabel
            // 
            contraindicationLabel.AutoSize = true;
            contraindicationLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            contraindicationLabel.ForeColor = System.Drawing.SystemColors.Control;
            contraindicationLabel.Location = new System.Drawing.Point(825, 287);
            contraindicationLabel.Name = "contraindicationLabel";
            contraindicationLabel.Size = new System.Drawing.Size(165, 27);
            contraindicationLabel.TabIndex = 65;
            contraindicationLabel.Text = "contraindication:";
            // 
            // taking_rulesLabel
            // 
            taking_rulesLabel.AutoSize = true;
            taking_rulesLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            taking_rulesLabel.ForeColor = System.Drawing.SystemColors.Control;
            taking_rulesLabel.Location = new System.Drawing.Point(825, 327);
            taking_rulesLabel.Name = "taking_rulesLabel";
            taking_rulesLabel.Size = new System.Drawing.Size(127, 27);
            taking_rulesLabel.TabIndex = 67;
            taking_rulesLabel.Text = "taking rules:";
            // 
            // principle_of_operationLabel
            // 
            principle_of_operationLabel.AutoSize = true;
            principle_of_operationLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            principle_of_operationLabel.ForeColor = System.Drawing.SystemColors.Control;
            principle_of_operationLabel.Location = new System.Drawing.Point(825, 367);
            principle_of_operationLabel.Name = "principle_of_operationLabel";
            principle_of_operationLabel.Size = new System.Drawing.Size(216, 27);
            principle_of_operationLabel.TabIndex = 69;
            principle_of_operationLabel.Text = "principle of operation:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            priceLabel.ForeColor = System.Drawing.SystemColors.Control;
            priceLabel.Location = new System.Drawing.Point(825, 407);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(65, 27);
            priceLabel.TabIndex = 71;
            priceLabel.Text = "price:";
            // 
            // dosageLabel
            // 
            dosageLabel.AutoSize = true;
            dosageLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            dosageLabel.ForeColor = System.Drawing.SystemColors.Control;
            dosageLabel.Location = new System.Drawing.Point(825, 447);
            dosageLabel.Name = "dosageLabel";
            dosageLabel.Size = new System.Drawing.Size(82, 27);
            dosageLabel.TabIndex = 73;
            dosageLabel.Text = "dosage:";
            // 
            // packagingLabel
            // 
            packagingLabel.AutoSize = true;
            packagingLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            packagingLabel.ForeColor = System.Drawing.SystemColors.Control;
            packagingLabel.Location = new System.Drawing.Point(825, 487);
            packagingLabel.Name = "packagingLabel";
            packagingLabel.Size = new System.Drawing.Size(107, 27);
            packagingLabel.TabIndex = 75;
            packagingLabel.Text = "packaging:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            ratingLabel.ForeColor = System.Drawing.SystemColors.Control;
            ratingLabel.Location = new System.Drawing.Point(825, 527);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(74, 27);
            ratingLabel.TabIndex = 77;
            ratingLabel.Text = "rating:";
            // 
            // use_category_idLabel
            // 
            use_category_idLabel.AutoSize = true;
            use_category_idLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            use_category_idLabel.ForeColor = System.Drawing.SystemColors.Control;
            use_category_idLabel.Location = new System.Drawing.Point(825, 567);
            use_category_idLabel.Name = "use_category_idLabel";
            use_category_idLabel.Size = new System.Drawing.Size(163, 27);
            use_category_idLabel.TabIndex = 79;
            use_category_idLabel.Text = "use category id:";
            // 
            // brend_idLabel
            // 
            brend_idLabel.AutoSize = true;
            brend_idLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            brend_idLabel.ForeColor = System.Drawing.SystemColors.Control;
            brend_idLabel.Location = new System.Drawing.Point(825, 607);
            brend_idLabel.Name = "brend_idLabel";
            brend_idLabel.Size = new System.Drawing.Size(96, 27);
            brend_idLabel.TabIndex = 81;
            brend_idLabel.Text = "brend id:";
            // 
            // form_of_drug_idLabel
            // 
            form_of_drug_idLabel.AutoSize = true;
            form_of_drug_idLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            form_of_drug_idLabel.ForeColor = System.Drawing.SystemColors.Control;
            form_of_drug_idLabel.Location = new System.Drawing.Point(825, 647);
            form_of_drug_idLabel.Name = "form_of_drug_idLabel";
            form_of_drug_idLabel.Size = new System.Drawing.Size(164, 27);
            form_of_drug_idLabel.TabIndex = 83;
            form_of_drug_idLabel.Text = "form of drug id:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drugsBindingSource
            // 
            this.drugsBindingSource.DataMember = "drugs";
            this.drugsBindingSource.DataSource = this.dataSet1;
            // 
            // drugsTableAdapter
            // 
            this.drugsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.brendTableAdapter = null;
            this.tableAdapterManager.drug_formTableAdapter = null;
            this.tableAdapterManager.drugsTableAdapter = this.drugsTableAdapter;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Drugstore.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.use_categoriesTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(821, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 38);
            this.label1.TabIndex = 57;
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
            this.searchCanselButton.Location = new System.Drawing.Point(675, 23);
            this.searchCanselButton.Name = "searchCanselButton";
            this.searchCanselButton.Size = new System.Drawing.Size(113, 37);
            this.searchCanselButton.TabIndex = 56;
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
            this.searchButton.Location = new System.Drawing.Point(492, 23);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 37);
            this.searchButton.TabIndex = 55;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // FilterInput
            // 
            this.FilterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FilterInput.Location = new System.Drawing.Point(12, 26);
            this.FilterInput.Name = "FilterInput";
            this.FilterInput.Size = new System.Drawing.Size(452, 30);
            this.FilterInput.TabIndex = 54;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Green;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(828, 693);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(449, 46);
            this.saveButton.TabIndex = 53;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Location = new System.Drawing.Point(129, 695);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(113, 44);
            this.deleteButton.TabIndex = 52;
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
            this.addFieldbutton.Location = new System.Drawing.Point(12, 695);
            this.addFieldbutton.Name = "addFieldbutton";
            this.addFieldbutton.Size = new System.Drawing.Size(97, 44);
            this.addFieldbutton.TabIndex = 51;
            this.addFieldbutton.Text = "Add";
            this.addFieldbutton.UseVisualStyleBackColor = false;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.countLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.countLabel.Location = new System.Drawing.Point(643, 701);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(145, 38);
            this.countLabel.TabIndex = 50;
            this.countLabel.Text = "Усього: ?";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.idTextBox.Location = new System.Drawing.Point(1105, 87);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(172, 30);
            this.idTextBox.TabIndex = 58;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nameTextBox.Location = new System.Drawing.Point(1105, 127);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(172, 30);
            this.nameTextBox.TabIndex = 60;
            // 
            // leave_without_a_prescriptionCheckBox
            // 
            this.leave_without_a_prescriptionCheckBox.AutoSize = true;
            this.leave_without_a_prescriptionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.drugsBindingSource, "leave_without_a_prescription", true));
            this.leave_without_a_prescriptionCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.leave_without_a_prescriptionCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.leave_without_a_prescriptionCheckBox.Location = new System.Drawing.Point(1105, 167);
            this.leave_without_a_prescriptionCheckBox.Name = "leave_without_a_prescriptionCheckBox";
            this.leave_without_a_prescriptionCheckBox.Size = new System.Drawing.Size(126, 31);
            this.leave_without_a_prescriptionCheckBox.TabIndex = 62;
            this.leave_without_a_prescriptionCheckBox.Text = "Сheck Box";
            this.leave_without_a_prescriptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // indicationTextBox
            // 
            this.indicationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "indication", true));
            this.indicationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.indicationTextBox.Location = new System.Drawing.Point(1105, 247);
            this.indicationTextBox.Name = "indicationTextBox";
            this.indicationTextBox.Size = new System.Drawing.Size(172, 30);
            this.indicationTextBox.TabIndex = 64;
            // 
            // contraindicationTextBox
            // 
            this.contraindicationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "contraindication", true));
            this.contraindicationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.contraindicationTextBox.Location = new System.Drawing.Point(1105, 287);
            this.contraindicationTextBox.Name = "contraindicationTextBox";
            this.contraindicationTextBox.Size = new System.Drawing.Size(172, 30);
            this.contraindicationTextBox.TabIndex = 66;
            // 
            // taking_rulesTextBox
            // 
            this.taking_rulesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "taking_rules", true));
            this.taking_rulesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.taking_rulesTextBox.Location = new System.Drawing.Point(1105, 327);
            this.taking_rulesTextBox.Name = "taking_rulesTextBox";
            this.taking_rulesTextBox.Size = new System.Drawing.Size(172, 30);
            this.taking_rulesTextBox.TabIndex = 68;
            // 
            // principle_of_operationTextBox
            // 
            this.principle_of_operationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "principle_of_operation", true));
            this.principle_of_operationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.principle_of_operationTextBox.Location = new System.Drawing.Point(1105, 367);
            this.principle_of_operationTextBox.Name = "principle_of_operationTextBox";
            this.principle_of_operationTextBox.Size = new System.Drawing.Size(172, 30);
            this.principle_of_operationTextBox.TabIndex = 70;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "price", true));
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.priceTextBox.Location = new System.Drawing.Point(1105, 407);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(172, 30);
            this.priceTextBox.TabIndex = 72;
            // 
            // dosageTextBox
            // 
            this.dosageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "dosage", true));
            this.dosageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dosageTextBox.Location = new System.Drawing.Point(1105, 447);
            this.dosageTextBox.Name = "dosageTextBox";
            this.dosageTextBox.Size = new System.Drawing.Size(172, 30);
            this.dosageTextBox.TabIndex = 74;
            // 
            // packagingTextBox
            // 
            this.packagingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "packaging", true));
            this.packagingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.packagingTextBox.Location = new System.Drawing.Point(1105, 487);
            this.packagingTextBox.Name = "packagingTextBox";
            this.packagingTextBox.Size = new System.Drawing.Size(172, 30);
            this.packagingTextBox.TabIndex = 76;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "rating", true));
            this.ratingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ratingTextBox.Location = new System.Drawing.Point(1105, 527);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(172, 30);
            this.ratingTextBox.TabIndex = 78;
            // 
            // use_category_idTextBox
            // 
            this.use_category_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "use_category_id", true));
            this.use_category_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.use_category_idTextBox.Location = new System.Drawing.Point(1105, 567);
            this.use_category_idTextBox.Name = "use_category_idTextBox";
            this.use_category_idTextBox.Size = new System.Drawing.Size(172, 30);
            this.use_category_idTextBox.TabIndex = 80;
            // 
            // brend_idTextBox
            // 
            this.brend_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "brend_id", true));
            this.brend_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.brend_idTextBox.Location = new System.Drawing.Point(1105, 607);
            this.brend_idTextBox.Name = "brend_idTextBox";
            this.brend_idTextBox.Size = new System.Drawing.Size(172, 30);
            this.brend_idTextBox.TabIndex = 82;
            // 
            // form_of_drug_idTextBox
            // 
            this.form_of_drug_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "form_of_drug_id", true));
            this.form_of_drug_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.form_of_drug_idTextBox.Location = new System.Drawing.Point(1105, 647);
            this.form_of_drug_idTextBox.Name = "form_of_drug_idTextBox";
            this.form_of_drug_idTextBox.Size = new System.Drawing.Size(172, 30);
            this.form_of_drug_idTextBox.TabIndex = 84;
            // 
            // drugsDataGridView
            // 
            this.drugsDataGridView.AutoGenerateColumns = false;
            this.drugsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drugsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.drugsDataGridView.DataSource = this.drugsBindingSource;
            this.drugsDataGridView.Location = new System.Drawing.Point(12, 87);
            this.drugsDataGridView.Name = "drugsDataGridView";
            this.drugsDataGridView.Size = new System.Drawing.Size(776, 587);
            this.drugsDataGridView.TabIndex = 84;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "leave_without_a_prescription";
            this.dataGridViewCheckBoxColumn1.HeaderText = "leave_without_a_prescription";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "image";
            this.dataGridViewTextBoxColumn3.HeaderText = "image";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "indication";
            this.dataGridViewTextBoxColumn4.HeaderText = "indication";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "contraindication";
            this.dataGridViewTextBoxColumn5.HeaderText = "contraindication";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "taking_rules";
            this.dataGridViewTextBoxColumn6.HeaderText = "taking_rules";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "principle_of_operation";
            this.dataGridViewTextBoxColumn7.HeaderText = "principle_of_operation";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn8.HeaderText = "price";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "dosage";
            this.dataGridViewTextBoxColumn9.HeaderText = "dosage";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "packaging";
            this.dataGridViewTextBoxColumn10.HeaderText = "packaging";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "rating";
            this.dataGridViewTextBoxColumn11.HeaderText = "rating";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "use_category_id";
            this.dataGridViewTextBoxColumn12.HeaderText = "use_category_id";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "brend_id";
            this.dataGridViewTextBoxColumn13.HeaderText = "brend_id";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "form_of_drug_id";
            this.dataGridViewTextBoxColumn14.HeaderText = "form_of_drug_id";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            imageLabel.ForeColor = System.Drawing.SystemColors.Control;
            imageLabel.Location = new System.Drawing.Point(825, 207);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(72, 27);
            imageLabel.TabIndex = 84;
            imageLabel.Text = "image:";
            // 
            // imageTextBox
            // 
            this.imageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.drugsBindingSource, "image", true));
            this.imageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.imageTextBox.Location = new System.Drawing.Point(1105, 207);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(172, 30);
            this.imageTextBox.TabIndex = 85;
            // 
            // DrugsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1405, 772);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.imageTextBox);
            this.Controls.Add(this.drugsDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(leave_without_a_prescriptionLabel);
            this.Controls.Add(this.leave_without_a_prescriptionCheckBox);
            this.Controls.Add(indicationLabel);
            this.Controls.Add(this.indicationTextBox);
            this.Controls.Add(contraindicationLabel);
            this.Controls.Add(this.contraindicationTextBox);
            this.Controls.Add(taking_rulesLabel);
            this.Controls.Add(this.taking_rulesTextBox);
            this.Controls.Add(principle_of_operationLabel);
            this.Controls.Add(this.principle_of_operationTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(dosageLabel);
            this.Controls.Add(this.dosageTextBox);
            this.Controls.Add(packagingLabel);
            this.Controls.Add(this.packagingTextBox);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(use_category_idLabel);
            this.Controls.Add(this.use_category_idTextBox);
            this.Controls.Add(brend_idLabel);
            this.Controls.Add(this.brend_idTextBox);
            this.Controls.Add(form_of_drug_idLabel);
            this.Controls.Add(this.form_of_drug_idTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchCanselButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.FilterInput);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addFieldbutton);
            this.Controls.Add(this.countLabel);
            this.Name = "DrugsForm";
            this.Text = "DrugsForm";
            this.Load += new System.EventHandler(this.DrugsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource drugsBindingSource;
        private DataSet1TableAdapters.drugsTableAdapter drugsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchCanselButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox FilterInput;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addFieldbutton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.CheckBox leave_without_a_prescriptionCheckBox;
        private System.Windows.Forms.TextBox indicationTextBox;
        private System.Windows.Forms.TextBox contraindicationTextBox;
        private System.Windows.Forms.TextBox taking_rulesTextBox;
        private System.Windows.Forms.TextBox principle_of_operationTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox dosageTextBox;
        private System.Windows.Forms.TextBox packagingTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox use_category_idTextBox;
        private System.Windows.Forms.TextBox brend_idTextBox;
        private System.Windows.Forms.TextBox form_of_drug_idTextBox;
        private System.Windows.Forms.DataGridView drugsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.TextBox imageTextBox;
    }
}