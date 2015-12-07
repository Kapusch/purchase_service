namespace Magasin
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pbPurchase = new System.Windows.Forms.PictureBox();
            this.pbPayment = new System.Windows.Forms.PictureBox();
            this.pbDelivery = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPurchase
            // 
            this.pbPurchase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPurchase.BackColor = System.Drawing.Color.Transparent;
            this.pbPurchase.Location = new System.Drawing.Point(103, 143);
            this.pbPurchase.Name = "pbPurchase";
            this.pbPurchase.Size = new System.Drawing.Size(100, 100);
            this.pbPurchase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPurchase.TabIndex = 0;
            this.pbPurchase.TabStop = false;
            this.pbPurchase.Click += new System.EventHandler(this.pbPurchase_Click);
            this.pbPurchase.MouseEnter += new System.EventHandler(this.pbPurchase_MouseEnter);
            // 
            // pbPayment
            // 
            this.pbPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPayment.BackColor = System.Drawing.Color.Transparent;
            this.pbPayment.Location = new System.Drawing.Point(257, 143);
            this.pbPayment.Name = "pbPayment";
            this.pbPayment.Size = new System.Drawing.Size(100, 100);
            this.pbPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPayment.TabIndex = 1;
            this.pbPayment.TabStop = false;
            this.pbPayment.Click += new System.EventHandler(this.pbPayment_Click);
            this.pbPayment.MouseEnter += new System.EventHandler(this.pbPayment_MouseEnter);
            // 
            // pbDelivery
            // 
            this.pbDelivery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDelivery.BackColor = System.Drawing.Color.Transparent;
            this.pbDelivery.Location = new System.Drawing.Point(420, 143);
            this.pbDelivery.Name = "pbDelivery";
            this.pbDelivery.Size = new System.Drawing.Size(100, 100);
            this.pbDelivery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDelivery.TabIndex = 2;
            this.pbDelivery.TabStop = false;
            this.pbDelivery.Click += new System.EventHandler(this.pbDelivery_Click);
            this.pbDelivery.MouseEnter += new System.EventHandler(this.pbDelivery_MouseEnter);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Magasin.SR._73365c9393b442b05c9ca44b1be6d20f_large;
            this.ClientSize = new System.Drawing.Size(602, 373);
            this.Controls.Add(this.pbDelivery);
            this.Controls.Add(this.pbPayment);
            this.Controls.Add(this.pbPurchase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.MouseEnter += new System.EventHandler(this.MainMenu_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pbPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelivery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPurchase;
        private System.Windows.Forms.PictureBox pbPayment;
        private System.Windows.Forms.PictureBox pbDelivery;

    }
}

