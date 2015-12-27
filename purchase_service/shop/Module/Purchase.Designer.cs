namespace Magasin.Module
{
    partial class Purchase
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblDevise = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.productImage = new System.Windows.Forms.PictureBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.btnAddBasket = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.lblBasket = new System.Windows.Forms.Label();
            this.dgvBasket = new System.Windows.Forms.DataGridView();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.Location = new System.Drawing.Point(369, 157);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Suivant";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrevious.Location = new System.Drawing.Point(70, 157);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Précédent";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblDevise
            // 
            this.lblDevise.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDevise.AutoSize = true;
            this.lblDevise.Location = new System.Drawing.Point(253, 309);
            this.lblDevise.Name = "lblDevise";
            this.lblDevise.Size = new System.Drawing.Size(13, 13);
            this.lblDevise.TabIndex = 12;
            this.lblDevise.Text = "€";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(171, 309);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(30, 13);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Prix :";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(166, 283);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Nom :";
            // 
            // tbPrice
            // 
            this.tbPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrice.Location = new System.Drawing.Point(207, 306);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(40, 20);
            this.tbPrice.TabIndex = 9;
            // 
            // tbProductName
            // 
            this.tbProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProductName.Location = new System.Drawing.Point(207, 280);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(121, 20);
            this.tbProductName.TabIndex = 8;
            // 
            // productImage
            // 
            this.productImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productImage.Location = new System.Drawing.Point(186, 76);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(142, 180);
            this.productImage.TabIndex = 7;
            this.productImage.TabStop = false;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(135, 335);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(66, 13);
            this.lblDesc.TabIndex = 14;
            this.lblDesc.Text = "Description :";
            // 
            // rtbDesc
            // 
            this.rtbDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbDesc.Location = new System.Drawing.Point(200, 332);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(128, 54);
            this.rtbDesc.TabIndex = 15;
            this.rtbDesc.Text = "";
            // 
            // btnAddBasket
            // 
            this.btnAddBasket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddBasket.Location = new System.Drawing.Point(394, 351);
            this.btnAddBasket.Name = "btnAddBasket";
            this.btnAddBasket.Size = new System.Drawing.Size(101, 23);
            this.btnAddBasket.TabIndex = 16;
            this.btnAddBasket.Text = "Ajouter au panier";
            this.btnAddBasket.UseVisualStyleBackColor = true;
            this.btnAddBasket.Click += new System.EventHandler(this.btnAddBasket_Click);
            // 
            // lblQty
            // 
            this.lblQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(394, 283);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(53, 13);
            this.lblQty.TabIndex = 17;
            this.lblQty.Text = "Quantité :";
            // 
            // tbQty
            // 
            this.tbQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbQty.Location = new System.Drawing.Point(394, 302);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(100, 20);
            this.tbQty.TabIndex = 18;
            // 
            // lblBasket
            // 
            this.lblBasket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBasket.AutoSize = true;
            this.lblBasket.Location = new System.Drawing.Point(546, 76);
            this.lblBasket.Name = "lblBasket";
            this.lblBasket.Size = new System.Drawing.Size(43, 13);
            this.lblBasket.TabIndex = 19;
            this.lblBasket.Text = "Panier :";
            // 
            // dgvBasket
            // 
            this.dgvBasket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBasket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clName,
            this.clQty});
            this.dgvBasket.Location = new System.Drawing.Point(549, 104);
            this.dgvBasket.Name = "dgvBasket";
            this.dgvBasket.RowHeadersVisible = false;
            this.dgvBasket.Size = new System.Drawing.Size(196, 282);
            this.dgvBasket.TabIndex = 20;
            // 
            // clName
            // 
            this.clName.HeaderText = "Produit";
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            this.clName.Width = 143;
            // 
            // clQty
            // 
            this.clQty.HeaderText = "Quantité";
            this.clQty.Name = "clQty";
            this.clQty.ReadOnly = true;
            this.clQty.Width = 50;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(343, 413);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 463);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvBasket);
            this.Controls.Add(this.lblBasket);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.btnAddBasket);
            this.Controls.Add(this.rtbDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblDevise);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.productImage);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Achat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblDevise;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.Button btnAddBasket;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label lblBasket;
        private System.Windows.Forms.DataGridView dgvBasket;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQty;
        private System.Windows.Forms.Button btnOK;
    }
}