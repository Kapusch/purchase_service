namespace Magasin.Module.Tools
{
    partial class ClientInformation
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
            this.tcClient = new System.Windows.Forms.TabControl();
            this.tbProfil = new System.Windows.Forms.TabPage();
            this.lblDevise = new System.Windows.Forms.Label();
            this.lblSoldInfo = new System.Windows.Forms.Label();
            this.lblDateInscriptionInfo = new System.Windows.Forms.Label();
            this.lblNameInfo = new System.Windows.Forms.Label();
            this.lblFirstNameInfo = new System.Windows.Forms.Label();
            this.lblLoginInfo = new System.Windows.Forms.Label();
            this.lblSold = new System.Windows.Forms.Label();
            this.lblInscriptionDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbCards = new System.Windows.Forms.TabPage();
            this.dgvCards = new System.Windows.Forms.DataGridView();
            this.clNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clExperationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCryto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCardType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartesBancaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tpAjout = new System.Windows.Forms.TabPage();
            this.cbBank = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lbBank = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbCryto = new System.Windows.Forms.TextBox();
            this.tbExpirationDate = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.tcClient.SuspendLayout();
            this.tbProfil.SuspendLayout();
            this.tbCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartesBancaireBindingSource)).BeginInit();
            this.tpAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcClient
            // 
            this.tcClient.Controls.Add(this.tbProfil);
            this.tcClient.Controls.Add(this.tbCards);
            this.tcClient.Controls.Add(this.tpAjout);
            this.tcClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcClient.Location = new System.Drawing.Point(0, 0);
            this.tcClient.Name = "tcClient";
            this.tcClient.SelectedIndex = 0;
            this.tcClient.Size = new System.Drawing.Size(507, 368);
            this.tcClient.TabIndex = 12;
            // 
            // tbProfil
            // 
            this.tbProfil.Controls.Add(this.lblDevise);
            this.tbProfil.Controls.Add(this.lblSoldInfo);
            this.tbProfil.Controls.Add(this.lblDateInscriptionInfo);
            this.tbProfil.Controls.Add(this.lblNameInfo);
            this.tbProfil.Controls.Add(this.lblFirstNameInfo);
            this.tbProfil.Controls.Add(this.lblLoginInfo);
            this.tbProfil.Controls.Add(this.lblSold);
            this.tbProfil.Controls.Add(this.lblInscriptionDate);
            this.tbProfil.Controls.Add(this.lblName);
            this.tbProfil.Controls.Add(this.lblFirstName);
            this.tbProfil.Controls.Add(this.lblLogin);
            this.tbProfil.Location = new System.Drawing.Point(4, 22);
            this.tbProfil.Name = "tbProfil";
            this.tbProfil.Padding = new System.Windows.Forms.Padding(3);
            this.tbProfil.Size = new System.Drawing.Size(499, 342);
            this.tbProfil.TabIndex = 0;
            this.tbProfil.Text = "Profil";
            this.tbProfil.UseVisualStyleBackColor = true;
            // 
            // lblDevise
            // 
            this.lblDevise.AutoSize = true;
            this.lblDevise.Location = new System.Drawing.Point(347, 247);
            this.lblDevise.Name = "lblDevise";
            this.lblDevise.Size = new System.Drawing.Size(13, 13);
            this.lblDevise.TabIndex = 23;
            this.lblDevise.Text = "€";
            // 
            // lblSoldInfo
            // 
            this.lblSoldInfo.AutoSize = true;
            this.lblSoldInfo.Location = new System.Drawing.Point(83, 247);
            this.lblSoldInfo.Name = "lblSoldInfo";
            this.lblSoldInfo.Size = new System.Drawing.Size(93, 13);
            this.lblSoldInfo.TabIndex = 22;
            this.lblSoldInfo.Text = "Solde du compte :";
            // 
            // lblDateInscriptionInfo
            // 
            this.lblDateInscriptionInfo.AutoSize = true;
            this.lblDateInscriptionInfo.Location = new System.Drawing.Point(82, 202);
            this.lblDateInscriptionInfo.Name = "lblDateInscriptionInfo";
            this.lblDateInscriptionInfo.Size = new System.Drawing.Size(94, 13);
            this.lblDateInscriptionInfo.TabIndex = 21;
            this.lblDateInscriptionInfo.Text = "Date d\'inscription :";
            // 
            // lblNameInfo
            // 
            this.lblNameInfo.AutoSize = true;
            this.lblNameInfo.Location = new System.Drawing.Point(141, 157);
            this.lblNameInfo.Name = "lblNameInfo";
            this.lblNameInfo.Size = new System.Drawing.Size(35, 13);
            this.lblNameInfo.TabIndex = 20;
            this.lblNameInfo.Text = "Nom :";
            // 
            // lblFirstNameInfo
            // 
            this.lblFirstNameInfo.AutoSize = true;
            this.lblFirstNameInfo.Location = new System.Drawing.Point(127, 120);
            this.lblFirstNameInfo.Name = "lblFirstNameInfo";
            this.lblFirstNameInfo.Size = new System.Drawing.Size(49, 13);
            this.lblFirstNameInfo.TabIndex = 19;
            this.lblFirstNameInfo.Text = "Prénom :";
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.AutoSize = true;
            this.lblLoginInfo.Location = new System.Drawing.Point(137, 79);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(39, 13);
            this.lblLoginInfo.TabIndex = 18;
            this.lblLoginInfo.Text = "Login :";
            // 
            // lblSold
            // 
            this.lblSold.AutoSize = true;
            this.lblSold.Location = new System.Drawing.Point(182, 247);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(0, 13);
            this.lblSold.TabIndex = 17;
            // 
            // lblInscriptionDate
            // 
            this.lblInscriptionDate.AutoSize = true;
            this.lblInscriptionDate.Location = new System.Drawing.Point(182, 202);
            this.lblInscriptionDate.Name = "lblInscriptionDate";
            this.lblInscriptionDate.Size = new System.Drawing.Size(0, 13);
            this.lblInscriptionDate.TabIndex = 16;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(182, 157);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 15;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(182, 120);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(0, 13);
            this.lblFirstName.TabIndex = 14;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(182, 79);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(0, 13);
            this.lblLogin.TabIndex = 13;
            // 
            // tbCards
            // 
            this.tbCards.Controls.Add(this.dgvCards);
            this.tbCards.Controls.Add(this.label1);
            this.tbCards.Location = new System.Drawing.Point(4, 22);
            this.tbCards.Name = "tbCards";
            this.tbCards.Padding = new System.Windows.Forms.Padding(3);
            this.tbCards.Size = new System.Drawing.Size(499, 342);
            this.tbCards.TabIndex = 1;
            this.tbCards.Text = "Cartes";
            this.tbCards.UseVisualStyleBackColor = true;
            // 
            // dgvCards
            // 
            this.dgvCards.AllowUserToAddRows = false;
            this.dgvCards.AllowUserToDeleteRows = false;
            this.dgvCards.AutoGenerateColumns = false;
            this.dgvCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNumber,
            this.clExperationDate,
            this.clCryto,
            this.clCardType,
            this.clBank});
            this.dgvCards.DataSource = this.cartesBancaireBindingSource;
            this.dgvCards.Location = new System.Drawing.Point(11, 49);
            this.dgvCards.Name = "dgvCards";
            this.dgvCards.ReadOnly = true;
            this.dgvCards.RowHeadersVisible = false;
            this.dgvCards.Size = new System.Drawing.Size(480, 245);
            this.dgvCards.TabIndex = 2;
            // 
            // clNumber
            // 
            this.clNumber.DataPropertyName = "Number";
            this.clNumber.HeaderText = "Numéro";
            this.clNumber.Name = "clNumber";
            this.clNumber.ReadOnly = true;
            // 
            // clExperationDate
            // 
            this.clExperationDate.DataPropertyName = "ExperationDate";
            this.clExperationDate.HeaderText = "Date d\'expiration";
            this.clExperationDate.Name = "clExperationDate";
            this.clExperationDate.ReadOnly = true;
            // 
            // clCryto
            // 
            this.clCryto.DataPropertyName = "Crytogramme";
            this.clCryto.HeaderText = "Crytogramme";
            this.clCryto.Name = "clCryto";
            this.clCryto.ReadOnly = true;
            // 
            // clCardType
            // 
            this.clCardType.DataPropertyName = "TypeCard";
            this.clCardType.HeaderText = "Type";
            this.clCardType.Name = "clCardType";
            this.clCardType.ReadOnly = true;
            // 
            // clBank
            // 
            this.clBank.DataPropertyName = "Bank";
            this.clBank.HeaderText = "Banque";
            this.clBank.Name = "clBank";
            this.clBank.ReadOnly = true;
            // 
            // cartesBancaireBindingSource
            // 
            this.cartesBancaireBindingSource.DataSource = typeof(Magasin.BO.CartesBancaire);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carte déjà enregistrée :";
            // 
            // tpAjout
            // 
            this.tpAjout.Controls.Add(this.cbBank);
            this.tpAjout.Controls.Add(this.cbType);
            this.tpAjout.Controls.Add(this.lbBank);
            this.tpAjout.Controls.Add(this.label5);
            this.tpAjout.Controls.Add(this.label4);
            this.tpAjout.Controls.Add(this.label3);
            this.tpAjout.Controls.Add(this.lblNumber);
            this.tpAjout.Controls.Add(this.btnAdd);
            this.tpAjout.Controls.Add(this.tbCryto);
            this.tpAjout.Controls.Add(this.tbExpirationDate);
            this.tpAjout.Controls.Add(this.tbNumber);
            this.tpAjout.Location = new System.Drawing.Point(4, 22);
            this.tpAjout.Name = "tpAjout";
            this.tpAjout.Padding = new System.Windows.Forms.Padding(3);
            this.tpAjout.Size = new System.Drawing.Size(499, 342);
            this.tpAjout.TabIndex = 2;
            this.tpAjout.Text = "Ajout";
            this.tpAjout.UseVisualStyleBackColor = true;
            // 
            // cbBank
            // 
            this.cbBank.FormattingEnabled = true;
            this.cbBank.Location = new System.Drawing.Point(207, 256);
            this.cbBank.Name = "cbBank";
            this.cbBank.Size = new System.Drawing.Size(172, 21);
            this.cbBank.TabIndex = 12;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(207, 207);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(172, 21);
            this.cbType.TabIndex = 11;
            // 
            // lbBank
            // 
            this.lbBank.AutoSize = true;
            this.lbBank.Location = new System.Drawing.Point(151, 259);
            this.lbBank.Name = "lbBank";
            this.lbBank.Size = new System.Drawing.Size(50, 13);
            this.lbBank.TabIndex = 10;
            this.lbBank.Text = "Banque :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Crytogramme :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date Expiration :";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(151, 72);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(50, 13);
            this.lblNumber.TabIndex = 6;
            this.lblNumber.Text = "Numéro :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(216, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbCryto
            // 
            this.tbCryto.Location = new System.Drawing.Point(207, 162);
            this.tbCryto.Name = "tbCryto";
            this.tbCryto.Size = new System.Drawing.Size(172, 20);
            this.tbCryto.TabIndex = 2;
            // 
            // tbExpirationDate
            // 
            this.tbExpirationDate.ForeColor = System.Drawing.Color.Gray;
            this.tbExpirationDate.Location = new System.Drawing.Point(207, 114);
            this.tbExpirationDate.Name = "tbExpirationDate";
            this.tbExpirationDate.Size = new System.Drawing.Size(172, 20);
            this.tbExpirationDate.TabIndex = 1;
            this.tbExpirationDate.Text = "Format jj/mm/aaaaa";
            this.tbExpirationDate.Enter += new System.EventHandler(this.tbExpirationDate_Enter);
            this.tbExpirationDate.Leave += new System.EventHandler(this.tbExpirationDate_Leave);
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(207, 69);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(172, 20);
            this.tbNumber.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(220, 376);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // ClientInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 411);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tcClient);
            this.Name = "ClientInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ClientInformation_Load);
            this.tcClient.ResumeLayout(false);
            this.tbProfil.ResumeLayout(false);
            this.tbProfil.PerformLayout();
            this.tbCards.ResumeLayout(false);
            this.tbCards.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartesBancaireBindingSource)).EndInit();
            this.tpAjout.ResumeLayout(false);
            this.tpAjout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcClient;
        private System.Windows.Forms.TabPage tbProfil;
        private System.Windows.Forms.Label lblDevise;
        private System.Windows.Forms.Label lblSoldInfo;
        private System.Windows.Forms.Label lblDateInscriptionInfo;
        private System.Windows.Forms.Label lblNameInfo;
        private System.Windows.Forms.Label lblFirstNameInfo;
        private System.Windows.Forms.Label lblLoginInfo;
        private System.Windows.Forms.Label lblSold;
        private System.Windows.Forms.Label lblInscriptionDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TabPage tbCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCARTEBANCAIREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEEXPIRATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRYPTOGRAMMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTYPECARTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBANQUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvCards;
        private System.Windows.Forms.BindingSource cartesBancaireBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clExperationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCryto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCardType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBank;
        private System.Windows.Forms.TabPage tpAjout;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbCryto;
        private System.Windows.Forms.TextBox tbExpirationDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbBank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.ComboBox cbBank;
        private System.Windows.Forms.ComboBox cbType;

    }
}