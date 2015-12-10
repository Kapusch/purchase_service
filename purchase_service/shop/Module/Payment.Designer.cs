namespace Magasin.Module
{
    partial class Payment
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
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblReload = new System.Windows.Forms.Label();
            this.lblDevise3 = new System.Windows.Forms.Label();
            this.tbReload = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblDevise2 = new System.Windows.Forms.Label();
            this.lblClientSold = new System.Windows.Forms.Label();
            this.lblCurrentSold = new System.Windows.Forms.Label();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblDevise = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbOrder = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbCards = new System.Windows.Forms.ComboBox();
            this.lblCurrentCard = new System.Windows.Forms.Label();
            this.gbInfo.SuspendLayout();
            this.gbOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblCurrentCard);
            this.gbInfo.Controls.Add(this.cbCards);
            this.gbInfo.Controls.Add(this.lblReload);
            this.gbInfo.Controls.Add(this.lblDevise3);
            this.gbInfo.Controls.Add(this.tbReload);
            this.gbInfo.Controls.Add(this.btnReload);
            this.gbInfo.Controls.Add(this.lblDevise2);
            this.gbInfo.Controls.Add(this.lblClientSold);
            this.gbInfo.Controls.Add(this.lblCurrentSold);
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(239, 335);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Informations";
            // 
            // lblReload
            // 
            this.lblReload.AutoSize = true;
            this.lblReload.Location = new System.Drawing.Point(35, 269);
            this.lblReload.Name = "lblReload";
            this.lblReload.Size = new System.Drawing.Size(63, 13);
            this.lblReload.TabIndex = 6;
            this.lblReload.Text = "Recharger :";
            // 
            // lblDevise3
            // 
            this.lblDevise3.AutoSize = true;
            this.lblDevise3.Location = new System.Drawing.Point(213, 269);
            this.lblDevise3.Name = "lblDevise3";
            this.lblDevise3.Size = new System.Drawing.Size(13, 13);
            this.lblDevise3.TabIndex = 5;
            this.lblDevise3.Text = "€";
            // 
            // tbReload
            // 
            this.tbReload.Location = new System.Drawing.Point(107, 266);
            this.tbReload.Name = "tbReload";
            this.tbReload.Size = new System.Drawing.Size(100, 20);
            this.tbReload.TabIndex = 4;
            this.tbReload.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbReload_KeyDown);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(79, 306);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Recharger";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lblDevise2
            // 
            this.lblDevise2.AutoSize = true;
            this.lblDevise2.Location = new System.Drawing.Point(126, 159);
            this.lblDevise2.Name = "lblDevise2";
            this.lblDevise2.Size = new System.Drawing.Size(13, 13);
            this.lblDevise2.TabIndex = 2;
            this.lblDevise2.Text = "€";
            // 
            // lblClientSold
            // 
            this.lblClientSold.AutoSize = true;
            this.lblClientSold.Location = new System.Drawing.Point(63, 159);
            this.lblClientSold.Name = "lblClientSold";
            this.lblClientSold.Size = new System.Drawing.Size(0, 13);
            this.lblClientSold.TabIndex = 1;
            // 
            // lblCurrentSold
            // 
            this.lblCurrentSold.AutoSize = true;
            this.lblCurrentSold.Location = new System.Drawing.Point(18, 108);
            this.lblCurrentSold.Name = "lblCurrentSold";
            this.lblCurrentSold.Size = new System.Drawing.Size(80, 13);
            this.lblCurrentSold.TabIndex = 0;
            this.lblCurrentSold.Text = "Solde actuelle :";
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.btnPay);
            this.gbOrder.Controls.Add(this.lblDevise);
            this.gbOrder.Controls.Add(this.lblPrice);
            this.gbOrder.Controls.Add(this.lblTotal);
            this.gbOrder.Controls.Add(this.lbOrder);
            this.gbOrder.Location = new System.Drawing.Point(257, 12);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(252, 335);
            this.gbOrder.TabIndex = 1;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Commande";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(171, 297);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "Payer";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // lblDevise
            // 
            this.lblDevise.AutoSize = true;
            this.lblDevise.Location = new System.Drawing.Point(88, 302);
            this.lblDevise.Name = "lblDevise";
            this.lblDevise.Size = new System.Drawing.Size(13, 13);
            this.lblDevise.TabIndex = 3;
            this.lblDevise.Text = "€";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(59, 302);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 13);
            this.lblPrice.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(16, 302);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total :";
            // 
            // lbOrder
            // 
            this.lbOrder.FormattingEnabled = true;
            this.lbOrder.Location = new System.Drawing.Point(6, 19);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbOrder.Size = new System.Drawing.Size(240, 264);
            this.lbOrder.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(276, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(163, 362);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // cbCards
            // 
            this.cbCards.FormattingEnabled = true;
            this.cbCards.Location = new System.Drawing.Point(18, 216);
            this.cbCards.Name = "cbCards";
            this.cbCards.Size = new System.Drawing.Size(121, 21);
            this.cbCards.TabIndex = 7;
            // 
            // lblCurrentCard
            // 
            this.lblCurrentCard.AutoSize = true;
            this.lblCurrentCard.Location = new System.Drawing.Point(18, 190);
            this.lblCurrentCard.Name = "lblCurrentCard";
            this.lblCurrentCard.Size = new System.Drawing.Size(76, 13);
            this.lblCurrentCard.TabIndex = 8;
            this.lblCurrentCard.Text = "Carte débitée :";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 397);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.gbInfo);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paiement";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox lbOrder;
        private System.Windows.Forms.Label lblDevise;
        private System.Windows.Forms.Label lblDevise2;
        private System.Windows.Forms.Label lblClientSold;
        private System.Windows.Forms.Label lblCurrentSold;
        private System.Windows.Forms.Label lblReload;
        private System.Windows.Forms.Label lblDevise3;
        private System.Windows.Forms.TextBox tbReload;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblCurrentCard;
        private System.Windows.Forms.ComboBox cbCards;
    }
}