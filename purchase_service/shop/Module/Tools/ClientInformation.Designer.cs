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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInscriptionDate = new System.Windows.Forms.Label();
            this.lblSold = new System.Windows.Forms.Label();
            this.lblLoginInfo = new System.Windows.Forms.Label();
            this.lblFirstNameInfo = new System.Windows.Forms.Label();
            this.lblNameInfo = new System.Windows.Forms.Label();
            this.lblDateInscriptionInfo = new System.Windows.Forms.Label();
            this.lblSoldInfo = new System.Windows.Forms.Label();
            this.lblDevise = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(134, 266);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(109, 34);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(0, 13);
            this.lblLogin.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(109, 75);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(0, 13);
            this.lblFirstName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(109, 112);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 3;
            // 
            // lblInscriptionDate
            // 
            this.lblInscriptionDate.AutoSize = true;
            this.lblInscriptionDate.Location = new System.Drawing.Point(109, 157);
            this.lblInscriptionDate.Name = "lblInscriptionDate";
            this.lblInscriptionDate.Size = new System.Drawing.Size(0, 13);
            this.lblInscriptionDate.TabIndex = 4;
            // 
            // lblSold
            // 
            this.lblSold.AutoSize = true;
            this.lblSold.Location = new System.Drawing.Point(109, 202);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(0, 13);
            this.lblSold.TabIndex = 5;
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.AutoSize = true;
            this.lblLoginInfo.Location = new System.Drawing.Point(64, 34);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(39, 13);
            this.lblLoginInfo.TabIndex = 6;
            this.lblLoginInfo.Text = "Login :";
            // 
            // lblFirstNameInfo
            // 
            this.lblFirstNameInfo.AutoSize = true;
            this.lblFirstNameInfo.Location = new System.Drawing.Point(54, 75);
            this.lblFirstNameInfo.Name = "lblFirstNameInfo";
            this.lblFirstNameInfo.Size = new System.Drawing.Size(49, 13);
            this.lblFirstNameInfo.TabIndex = 7;
            this.lblFirstNameInfo.Text = "Prénom :";
            // 
            // lblNameInfo
            // 
            this.lblNameInfo.AutoSize = true;
            this.lblNameInfo.Location = new System.Drawing.Point(68, 112);
            this.lblNameInfo.Name = "lblNameInfo";
            this.lblNameInfo.Size = new System.Drawing.Size(35, 13);
            this.lblNameInfo.TabIndex = 8;
            this.lblNameInfo.Text = "Nom :";
            // 
            // lblDateInscriptionInfo
            // 
            this.lblDateInscriptionInfo.AutoSize = true;
            this.lblDateInscriptionInfo.Location = new System.Drawing.Point(9, 157);
            this.lblDateInscriptionInfo.Name = "lblDateInscriptionInfo";
            this.lblDateInscriptionInfo.Size = new System.Drawing.Size(94, 13);
            this.lblDateInscriptionInfo.TabIndex = 9;
            this.lblDateInscriptionInfo.Text = "Date d\'inscription :";
            // 
            // lblSoldInfo
            // 
            this.lblSoldInfo.AutoSize = true;
            this.lblSoldInfo.Location = new System.Drawing.Point(10, 202);
            this.lblSoldInfo.Name = "lblSoldInfo";
            this.lblSoldInfo.Size = new System.Drawing.Size(93, 13);
            this.lblSoldInfo.TabIndex = 10;
            this.lblSoldInfo.Text = "Solde du compte :";
            // 
            // lblDevise
            // 
            this.lblDevise.AutoSize = true;
            this.lblDevise.Location = new System.Drawing.Point(274, 202);
            this.lblDevise.Name = "lblDevise";
            this.lblDevise.Size = new System.Drawing.Size(13, 13);
            this.lblDevise.TabIndex = 11;
            this.lblDevise.Text = "€";
            // 
            // ClientInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 301);
            this.Controls.Add(this.lblDevise);
            this.Controls.Add(this.lblSoldInfo);
            this.Controls.Add(this.lblDateInscriptionInfo);
            this.Controls.Add(this.lblNameInfo);
            this.Controls.Add(this.lblFirstNameInfo);
            this.Controls.Add(this.lblLoginInfo);
            this.Controls.Add(this.lblSold);
            this.Controls.Add(this.lblInscriptionDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnOK);
            this.Name = "ClientInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClientInformation";
            this.Load += new System.EventHandler(this.ClientInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInscriptionDate;
        private System.Windows.Forms.Label lblSold;
        private System.Windows.Forms.Label lblLoginInfo;
        private System.Windows.Forms.Label lblFirstNameInfo;
        private System.Windows.Forms.Label lblNameInfo;
        private System.Windows.Forms.Label lblDateInscriptionInfo;
        private System.Windows.Forms.Label lblSoldInfo;
        private System.Windows.Forms.Label lblDevise;
    }
}