
namespace BankAccountsProject1
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
            this.dgwAccounts = new System.Windows.Forms.DataGridView();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.tbxBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxLocationUpdate = new System.Windows.Forms.TextBox();
            this.tbxBalanceUpdate = new System.Windows.Forms.TextBox();
            this.tbxTypeUpdate = new System.Windows.Forms.TextBox();
            this.lblNumberUpdate = new System.Windows.Forms.Label();
            this.lblLocationUpdate = new System.Windows.Forms.Label();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.lblBalanceUpdate = new System.Windows.Forms.Label();
            this.tbxNumberUpdate = new System.Windows.Forms.TextBox();
            this.lblTypeUpdate = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAccounts)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwAccounts
            // 
            this.dgwAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAccounts.Location = new System.Drawing.Point(141, 69);
            this.dgwAccounts.Name = "dgwAccounts";
            this.dgwAccounts.Size = new System.Drawing.Size(579, 202);
            this.dgwAccounts.TabIndex = 0;
            this.dgwAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAccounts_CellClick);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(6, 24);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(83, 13);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name";
            this.lblCustomerName.Click += new System.EventHandler(this.lblCustomerName_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(95, 21);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(140, 21);
            this.tbxName.TabIndex = 3;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // tbxLocation
            // 
            this.tbxLocation.Location = new System.Drawing.Point(95, 46);
            this.tbxLocation.Name = "tbxLocation";
            this.tbxLocation.Size = new System.Drawing.Size(140, 21);
            this.tbxLocation.TabIndex = 6;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(19, 49);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(47, 13);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "Location";
            // 
            // tbxBalance
            // 
            this.tbxBalance.Location = new System.Drawing.Point(95, 73);
            this.tbxBalance.Name = "tbxBalance";
            this.tbxBalance.Size = new System.Drawing.Size(140, 21);
            this.tbxBalance.TabIndex = 8;
            this.tbxBalance.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(22, 73);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(44, 13);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "Balance";
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(95, 100);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(140, 21);
            this.tbxNumber.TabIndex = 10;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 103);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(77, 13);
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.Text = "Phone Number";
            this.lblPhoneNumber.Click += new System.EventHandler(this.lblPhoneNumber_Click);
            // 
            // tbxType
            // 
            this.tbxType.Location = new System.Drawing.Point(95, 128);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(140, 21);
            this.tbxType.TabIndex = 12;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(12, 128);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(73, 13);
            this.lblAccountType.TabIndex = 11;
            this.lblAccountType.Text = "Account Type";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxLocation);
            this.gbxAdd.Controls.Add(this.tbxBalance);
            this.gbxAdd.Controls.Add(this.tbxType);
            this.gbxAdd.Controls.Add(this.lblPhoneNumber);
            this.gbxAdd.Controls.Add(this.lblLocation);
            this.gbxAdd.Controls.Add(this.lblCustomerName);
            this.gbxAdd.Controls.Add(this.lblBalance);
            this.gbxAdd.Controls.Add(this.tbxNumber);
            this.gbxAdd.Controls.Add(this.lblAccountType);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Location = new System.Drawing.Point(141, 302);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(282, 186);
            this.gbxAdd.TabIndex = 13;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a Customer";
            this.gbxAdd.Enter += new System.EventHandler(this.gbxAdd_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(160, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxLocationUpdate);
            this.gbxUpdate.Controls.Add(this.tbxBalanceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxTypeUpdate);
            this.gbxUpdate.Controls.Add(this.lblNumberUpdate);
            this.gbxUpdate.Controls.Add(this.lblLocationUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblBalanceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNumberUpdate);
            this.gbxUpdate.Controls.Add(this.lblTypeUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(438, 309);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(282, 179);
            this.gbxUpdate.TabIndex = 14;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a Customer";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(160, 157);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxLocationUpdate
            // 
            this.tbxLocationUpdate.Location = new System.Drawing.Point(95, 46);
            this.tbxLocationUpdate.Name = "tbxLocationUpdate";
            this.tbxLocationUpdate.Size = new System.Drawing.Size(140, 21);
            this.tbxLocationUpdate.TabIndex = 6;
            // 
            // tbxBalanceUpdate
            // 
            this.tbxBalanceUpdate.Location = new System.Drawing.Point(95, 73);
            this.tbxBalanceUpdate.Name = "tbxBalanceUpdate";
            this.tbxBalanceUpdate.Size = new System.Drawing.Size(140, 21);
            this.tbxBalanceUpdate.TabIndex = 8;
            // 
            // tbxTypeUpdate
            // 
            this.tbxTypeUpdate.Location = new System.Drawing.Point(95, 128);
            this.tbxTypeUpdate.Name = "tbxTypeUpdate";
            this.tbxTypeUpdate.Size = new System.Drawing.Size(140, 21);
            this.tbxTypeUpdate.TabIndex = 12;
            // 
            // lblNumberUpdate
            // 
            this.lblNumberUpdate.AutoSize = true;
            this.lblNumberUpdate.Location = new System.Drawing.Point(12, 103);
            this.lblNumberUpdate.Name = "lblNumberUpdate";
            this.lblNumberUpdate.Size = new System.Drawing.Size(77, 13);
            this.lblNumberUpdate.TabIndex = 9;
            this.lblNumberUpdate.Text = "Phone Number";
            // 
            // lblLocationUpdate
            // 
            this.lblLocationUpdate.AutoSize = true;
            this.lblLocationUpdate.Location = new System.Drawing.Point(19, 49);
            this.lblLocationUpdate.Name = "lblLocationUpdate";
            this.lblLocationUpdate.Size = new System.Drawing.Size(47, 13);
            this.lblLocationUpdate.TabIndex = 5;
            this.lblLocationUpdate.Text = "Location";
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(6, 24);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(83, 13);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Customer Name";
            // 
            // lblBalanceUpdate
            // 
            this.lblBalanceUpdate.AutoSize = true;
            this.lblBalanceUpdate.Location = new System.Drawing.Point(22, 73);
            this.lblBalanceUpdate.Name = "lblBalanceUpdate";
            this.lblBalanceUpdate.Size = new System.Drawing.Size(44, 13);
            this.lblBalanceUpdate.TabIndex = 7;
            this.lblBalanceUpdate.Text = "Balance";
            // 
            // tbxNumberUpdate
            // 
            this.tbxNumberUpdate.Location = new System.Drawing.Point(95, 100);
            this.tbxNumberUpdate.Name = "tbxNumberUpdate";
            this.tbxNumberUpdate.Size = new System.Drawing.Size(140, 21);
            this.tbxNumberUpdate.TabIndex = 10;
            // 
            // lblTypeUpdate
            // 
            this.lblTypeUpdate.AutoSize = true;
            this.lblTypeUpdate.Location = new System.Drawing.Point(12, 128);
            this.lblTypeUpdate.Name = "lblTypeUpdate";
            this.lblTypeUpdate.Size = new System.Drawing.Size(73, 13);
            this.lblTypeUpdate.TabIndex = 11;
            this.lblTypeUpdate.Text = "Account Type";
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(95, 21);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(140, 21);
            this.tbxNameUpdate.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(533, 33);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(140, 23);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 555);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwAccounts);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAccounts)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAccounts;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox tbxBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox tbxType;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxLocationUpdate;
        private System.Windows.Forms.TextBox tbxBalanceUpdate;
        private System.Windows.Forms.TextBox tbxTypeUpdate;
        private System.Windows.Forms.Label lblNumberUpdate;
        private System.Windows.Forms.Label lblLocationUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Label lblBalanceUpdate;
        private System.Windows.Forms.TextBox tbxNumberUpdate;
        private System.Windows.Forms.Label lblTypeUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}

