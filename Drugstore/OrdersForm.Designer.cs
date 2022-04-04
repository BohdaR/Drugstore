
namespace Drugstore
{
    partial class OrdersForm
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
            System.Windows.Forms.Label customers_full_nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phone_numberLabel;
            System.Windows.Forms.Label delivery_methodLabel;
            System.Windows.Forms.Label pay_methodLabel;
            System.Windows.Forms.Label createdLabel;
            System.Windows.Forms.Label updatedLabel;
            System.Windows.Forms.Label order_itemLabel;
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchCanselButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.FilterInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addFieldbutton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.customers_full_nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.delivery_methodTextBox = new System.Windows.Forms.TextBox();
            this.pay_methodTextBox = new System.Windows.Forms.TextBox();
            this.createdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.order_itemTextBox = new System.Windows.Forms.TextBox();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Drugstore.DataSet1();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersTableAdapter = new Drugstore.DataSet1TableAdapters.ordersTableAdapter();
            this.tableAdapterManager = new Drugstore.DataSet1TableAdapters.TableAdapterManager();
            idLabel = new System.Windows.Forms.Label();
            customers_full_nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phone_numberLabel = new System.Windows.Forms.Label();
            delivery_methodLabel = new System.Windows.Forms.Label();
            pay_methodLabel = new System.Windows.Forms.Label();
            createdLabel = new System.Windows.Forms.Label();
            updatedLabel = new System.Windows.Forms.Label();
            order_itemLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            idLabel.ForeColor = System.Drawing.SystemColors.Control;
            idLabel.Location = new System.Drawing.Point(683, 95);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(36, 27);
            idLabel.TabIndex = 57;
            idLabel.Text = "id:";
            // 
            // customers_full_nameLabel
            // 
            customers_full_nameLabel.AutoSize = true;
            customers_full_nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            customers_full_nameLabel.ForeColor = System.Drawing.SystemColors.Control;
            customers_full_nameLabel.Location = new System.Drawing.Point(683, 135);
            customers_full_nameLabel.Name = "customers_full_nameLabel";
            customers_full_nameLabel.Size = new System.Drawing.Size(205, 27);
            customers_full_nameLabel.TabIndex = 59;
            customers_full_nameLabel.Text = "customers full name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            addressLabel.ForeColor = System.Drawing.SystemColors.Control;
            addressLabel.Location = new System.Drawing.Point(683, 175);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(91, 27);
            addressLabel.TabIndex = 61;
            addressLabel.Text = "address:";
            // 
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            phone_numberLabel.ForeColor = System.Drawing.SystemColors.Control;
            phone_numberLabel.Location = new System.Drawing.Point(683, 215);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(146, 27);
            phone_numberLabel.TabIndex = 63;
            phone_numberLabel.Text = "phone number:";
            // 
            // delivery_methodLabel
            // 
            delivery_methodLabel.AutoSize = true;
            delivery_methodLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            delivery_methodLabel.ForeColor = System.Drawing.SystemColors.Control;
            delivery_methodLabel.Location = new System.Drawing.Point(683, 255);
            delivery_methodLabel.Name = "delivery_methodLabel";
            delivery_methodLabel.Size = new System.Drawing.Size(167, 27);
            delivery_methodLabel.TabIndex = 65;
            delivery_methodLabel.Text = "delivery method:";
            // 
            // pay_methodLabel
            // 
            pay_methodLabel.AutoSize = true;
            pay_methodLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            pay_methodLabel.ForeColor = System.Drawing.SystemColors.Control;
            pay_methodLabel.Location = new System.Drawing.Point(683, 295);
            pay_methodLabel.Name = "pay_methodLabel";
            pay_methodLabel.Size = new System.Drawing.Size(127, 27);
            pay_methodLabel.TabIndex = 67;
            pay_methodLabel.Text = "pay method:";
            // 
            // createdLabel
            // 
            createdLabel.AutoSize = true;
            createdLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            createdLabel.ForeColor = System.Drawing.SystemColors.Control;
            createdLabel.Location = new System.Drawing.Point(684, 335);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new System.Drawing.Size(92, 27);
            createdLabel.TabIndex = 69;
            createdLabel.Text = "created:";
            createdLabel.Click += new System.EventHandler(this.createdLabel_Click);
            // 
            // updatedLabel
            // 
            updatedLabel.AutoSize = true;
            updatedLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            updatedLabel.ForeColor = System.Drawing.SystemColors.Control;
            updatedLabel.Location = new System.Drawing.Point(683, 375);
            updatedLabel.Name = "updatedLabel";
            updatedLabel.Size = new System.Drawing.Size(93, 27);
            updatedLabel.TabIndex = 71;
            updatedLabel.Text = "updated:";
            // 
            // order_itemLabel
            // 
            order_itemLabel.AutoSize = true;
            order_itemLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            order_itemLabel.ForeColor = System.Drawing.SystemColors.Control;
            order_itemLabel.Location = new System.Drawing.Point(683, 415);
            order_itemLabel.Name = "order_itemLabel";
            order_itemLabel.Size = new System.Drawing.Size(118, 27);
            order_itemLabel.TabIndex = 73;
            order_itemLabel.Text = "order item:";
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.ordersDataGridView.DataSource = this.ordersBindingSource;
            this.ordersDataGridView.Location = new System.Drawing.Point(12, 87);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.Size = new System.Drawing.Size(636, 355);
            this.ordersDataGridView.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(673, 15);
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
            this.searchCanselButton.Location = new System.Drawing.Point(535, 19);
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
            this.searchButton.Location = new System.Drawing.Point(382, 19);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(113, 37);
            this.searchButton.TabIndex = 55;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // FilterInput
            // 
            this.FilterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FilterInput.Location = new System.Drawing.Point(12, 23);
            this.FilterInput.Name = "FilterInput";
            this.FilterInput.Size = new System.Drawing.Size(347, 30);
            this.FilterInput.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(680, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(469, 36);
            this.button1.TabIndex = 53;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Location = new System.Drawing.Point(137, 462);
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
            this.addFieldbutton.Location = new System.Drawing.Point(20, 462);
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
            this.countLabel.Location = new System.Drawing.Point(503, 468);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(145, 38);
            this.countLabel.TabIndex = 50;
            this.countLabel.Text = "Усього: ?";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "id", true));
            this.idTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold);
            this.idTextBox.Location = new System.Drawing.Point(894, 90);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(255, 35);
            this.idTextBox.TabIndex = 58;
            // 
            // customers_full_nameTextBox
            // 
            this.customers_full_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "customers_full_name", true));
            this.customers_full_nameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold);
            this.customers_full_nameTextBox.Location = new System.Drawing.Point(894, 130);
            this.customers_full_nameTextBox.Name = "customers_full_nameTextBox";
            this.customers_full_nameTextBox.Size = new System.Drawing.Size(255, 35);
            this.customers_full_nameTextBox.TabIndex = 60;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold);
            this.addressTextBox.Location = new System.Drawing.Point(894, 170);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(255, 35);
            this.addressTextBox.TabIndex = 62;
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "phone_number", true));
            this.phone_numberTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold);
            this.phone_numberTextBox.Location = new System.Drawing.Point(894, 210);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(255, 35);
            this.phone_numberTextBox.TabIndex = 64;
            // 
            // delivery_methodTextBox
            // 
            this.delivery_methodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "delivery_method", true));
            this.delivery_methodTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold);
            this.delivery_methodTextBox.Location = new System.Drawing.Point(894, 250);
            this.delivery_methodTextBox.Name = "delivery_methodTextBox";
            this.delivery_methodTextBox.Size = new System.Drawing.Size(255, 35);
            this.delivery_methodTextBox.TabIndex = 66;
            // 
            // pay_methodTextBox
            // 
            this.pay_methodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "pay_method", true));
            this.pay_methodTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold);
            this.pay_methodTextBox.Location = new System.Drawing.Point(894, 290);
            this.pay_methodTextBox.Name = "pay_methodTextBox";
            this.pay_methodTextBox.Size = new System.Drawing.Size(255, 35);
            this.pay_methodTextBox.TabIndex = 68;
            // 
            // createdDateTimePicker
            // 
            this.createdDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "created", true));
            this.createdDateTimePicker.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold);
            this.createdDateTimePicker.Location = new System.Drawing.Point(894, 330);
            this.createdDateTimePicker.Name = "createdDateTimePicker";
            this.createdDateTimePicker.Size = new System.Drawing.Size(255, 35);
            this.createdDateTimePicker.TabIndex = 72;
            // 
            // updatedDateTimePicker
            // 
            this.updatedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "updated", true));
            this.updatedDateTimePicker.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold);
            this.updatedDateTimePicker.Location = new System.Drawing.Point(894, 370);
            this.updatedDateTimePicker.Name = "updatedDateTimePicker";
            this.updatedDateTimePicker.Size = new System.Drawing.Size(255, 35);
            this.updatedDateTimePicker.TabIndex = 72;
            // 
            // order_itemTextBox
            // 
            this.order_itemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_item", true));
            this.order_itemTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold);
            this.order_itemTextBox.Location = new System.Drawing.Point(894, 410);
            this.order_itemTextBox.Name = "order_itemTextBox";
            this.order_itemTextBox.Size = new System.Drawing.Size(255, 35);
            this.order_itemTextBox.TabIndex = 74;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "customers_full_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "customers_full_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn3.HeaderText = "address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "phone_number";
            this.dataGridViewTextBoxColumn4.HeaderText = "phone_number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "delivery_method";
            this.dataGridViewTextBoxColumn5.HeaderText = "delivery_method";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "pay_method";
            this.dataGridViewTextBoxColumn6.HeaderText = "pay_method";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "created";
            this.dataGridViewTextBoxColumn7.HeaderText = "created";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "updated";
            this.dataGridViewTextBoxColumn8.HeaderText = "updated";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "order_item";
            this.dataGridViewTextBoxColumn9.HeaderText = "order_item";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.brendTableAdapter = null;
            this.tableAdapterManager.drug_formTableAdapter = null;
            this.tableAdapterManager.drugsTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Drugstore.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.use_categoriesTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1300, 535);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(customers_full_nameLabel);
            this.Controls.Add(this.customers_full_nameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(phone_numberLabel);
            this.Controls.Add(this.phone_numberTextBox);
            this.Controls.Add(delivery_methodLabel);
            this.Controls.Add(this.delivery_methodTextBox);
            this.Controls.Add(pay_methodLabel);
            this.Controls.Add(this.pay_methodTextBox);
            this.Controls.Add(createdLabel);
            this.Controls.Add(this.createdDateTimePicker);
            this.Controls.Add(updatedLabel);
            this.Controls.Add(this.updatedDateTimePicker);
            this.Controls.Add(order_itemLabel);
            this.Controls.Add(this.order_itemTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchCanselButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.FilterInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addFieldbutton);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.ordersDataGridView);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DataSet1TableAdapters.ordersTableAdapter ordersTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchCanselButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox FilterInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addFieldbutton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox customers_full_nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.TextBox delivery_methodTextBox;
        private System.Windows.Forms.TextBox pay_methodTextBox;
        private System.Windows.Forms.DateTimePicker createdDateTimePicker;
        private System.Windows.Forms.DateTimePicker updatedDateTimePicker;
        private System.Windows.Forms.TextBox order_itemTextBox;
    }
}