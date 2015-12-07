﻿using Magasin.BO;
using Magasin.Module;
using Magasin.Module.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magasin
{

    public partial class MainMenu : Form
    {
        #region attributs

        private Delivery pageDelivery;
        private Payment pagePayment;
        private Purchase pagePurchase;

        private LoginBox identification;
        private const int size = 106;

        public Client CurrentClient { get; set; }

        private Delivery PageDelivery { get {
            if (pageDelivery == null)
            {
                pageDelivery = new Delivery();
                pageDelivery.FormClosing += this.ClosePageDelivery;
            }
            return pageDelivery; } }

        private Payment PagePayment { get {
            if (pagePayment == null)
            {
                pagePayment = new Payment();
                pagePayment.FormClosing += this.ClosePagePayment;
            }
            return pagePayment;}}

        private Purchase PagePurchase { get {
            if (pagePurchase == null)
            {
                pagePurchase = new Purchase();
                pagePurchase.FormClosing += this.ClosePagePurchase;
            }
            return pagePurchase;
        }}

        private LoginBox Identification
        {
            get
            {
                if (identification == null)
                {
                    identification = new LoginBox();
                    identification.FormClosing += this.CloseLoginBox;
                }
                return identification;
            }
        }

        #endregion
        
        public MainMenu()
        {
            InitializeComponent();
        }


        #region events

        private void MainMenu_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pbPurchase_MouseEnter(object sender, EventArgs e)
        {
            BiggerEffect(pbPurchase, SR.icone_achat_bigger);
        }

        private void pbPayment_MouseEnter(object sender, EventArgs e)
        {
            BiggerEffect(pbPayment, SR.icone_payment_bigger);
        }

        private void pbDelivery_MouseEnter(object sender, EventArgs e)
        {
            BiggerEffect(pbDelivery, SR.icone_livraison_bigger);
        }

        private void pbPurchase_Click(object sender, EventArgs e)
        {
            PagePurchase.Show();
            PagePurchase.Focus();
        }

        private void pbPayment_Click(object sender, EventArgs e)
        {
            PagePayment.Show();
            PagePayment.Focus();
        }

        private void pbDelivery_Click(object sender, EventArgs e)
        {
            PageDelivery.Show();
            PageDelivery.Focus();
        }

        private void llblConnected_Click(object sender, EventArgs e)
        {
            using (Identification)
            {
                if (!(Identification.ShowDialog() == DialogResult.No))
                    if (CurrentClient!=null)
                    {
                        lblClientProfil.Text = CurrentClient.firstName + " " + CurrentClient.name;
                        lblClientProfil.Visible = true;
                        llblConnected.Visible = false;
                    }
                
            }
            identification = null;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            pbDelivery.Image = SR.icone_livraison;
            pbPayment.Image = SR.icone_payment;
            pbPurchase.Image = SR.icone_achat;
        }

        private void MainMenu_MouseEnter(object sender, EventArgs e)
        {
            const int sizeInit = 100;
            if (pbPurchase.Width != 100)
            {
                pbPurchase.Width = sizeInit;
                pbPurchase.Height = sizeInit;
                pbPurchase.Image = SR.icone_achat;
            }
            if (pbPayment.Width != 100)
            {
                pbPayment.Width = sizeInit;
                pbPayment.Height = sizeInit;
                pbPayment.Image = SR.icone_payment;
            }
            if (pbDelivery.Width != 100)
            {
                pbDelivery.Width = sizeInit;
                pbDelivery.Height = sizeInit;
                pbDelivery.Image = SR.icone_livraison;
            }
        }

        private void lblClientProfil_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void BiggerEffect (PictureBox picture, Bitmap newImage)
        {
            if (picture.Width != size)
            {
                picture.Width = size;
                picture.Height = size;
                picture.Image = newImage;
            }
        }

        private void ClosePageDelivery(object sender, FormClosingEventArgs e)
        {
            pageDelivery.Dispose();
            pageDelivery = null;
        }

        private void ClosePagePurchase(object sender, FormClosingEventArgs e)
        {
            pagePurchase.Dispose();
            pagePurchase = null;
        }

        private void ClosePagePayment(object sender, FormClosingEventArgs e)
        {
            pagePayment.Dispose();
            pagePayment = null;
        }

        private void CloseLoginBox(object sender, FormClosingEventArgs e)
        {
            if (Identification.CurrentClient != null)
                CurrentClient = Identification.CurrentClient;
            identification.Dispose();
            identification = null;
        }
    }
}
