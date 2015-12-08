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
            this.llblConnected = new System.Windows.Forms.LinkLabel();
            this.lblClientProfil = new System.Windows.Forms.LinkLabel();
            this.llblSignIn = new System.Windows.Forms.LinkLabel();
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
            // llblConnected
            // 
            this.llblConnected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llblConnected.AutoSize = true;
            this.llblConnected.BackColor = System.Drawing.Color.Transparent;
            this.llblConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblConnected.Location = new System.Drawing.Point(474, 31);
            this.llblConnected.Name = "llblConnected";
            this.llblConnected.Size = new System.Drawing.Size(96, 18);
            this.llblConnected.TabIndex = 3;
            this.llblConnected.TabStop = true;
            this.llblConnected.Text = "Se connecter";
            this.llblConnected.Click += new System.EventHandler(this.llblConnected_Click);
            // 
            // lblClientProfil
            // 
            this.lblClientProfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClientProfil.AutoSize = true;
            this.lblClientProfil.BackColor = System.Drawing.Color.Transparent;
            this.lblClientProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientProfil.Location = new System.Drawing.Point(468, 31);
            this.lblClientProfil.Name = "lblClientProfil";
            this.lblClientProfil.Size = new System.Drawing.Size(0, 18);
            this.lblClientProfil.TabIndex = 4;
            this.lblClientProfil.Visible = false;
            this.lblClientProfil.Click += new System.EventHandler(this.lblClientProfil_Click);
            // 
            // llblSignIn
            // 
            this.llblSignIn.AutoSize = true;
            this.llblSignIn.BackColor = System.Drawing.Color.Transparent;
            this.llblSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblSignIn.Location = new System.Drawing.Point(37, 31);
            this.llblSignIn.Name = "llblSignIn";
            this.llblSignIn.Size = new System.Drawing.Size(75, 18);
            this.llblSignIn.TabIndex = 5;
            this.llblSignIn.TabStop = true;
            this.llblSignIn.Text = "Inscription";
            this.llblSignIn.Click += new System.EventHandler(this.llblSignIn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Magasin.SR._73365c9393b442b05c9ca44b1be6d20f_large;
            this.ClientSize = new System.Drawing.Size(602, 373);
            this.Controls.Add(this.llblSignIn);
            this.Controls.Add(this.lblClientProfil);
            this.Controls.Add(this.llblConnected);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPurchase;
        private System.Windows.Forms.PictureBox pbPayment;
        private System.Windows.Forms.PictureBox pbDelivery;
        private System.Windows.Forms.LinkLabel llblConnected;
        private System.Windows.Forms.LinkLabel lblClientProfil;
        private System.Windows.Forms.LinkLabel llblSignIn;

    }
}

