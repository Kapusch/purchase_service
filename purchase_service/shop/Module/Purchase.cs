using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magasin.VenteProduit;
using System.IO;
using Magasin.Module.Tools;

namespace Magasin.Module
{
    public partial class Purchase : Form
    {
        private List<produit> currentListProduct;
        private produit currentProduct;
        public Dictionary<produit, int> Basket = new Dictionary<produit, int> { };

        public Purchase()
        {
            // permet de charger les produits donnés par le web service
            InitializeComponent();
            this.currentListProduct = Service.GetVenteProduitService.ListeDeProduits().ToList();
            currentProduct = currentListProduct.FirstOrDefault();
            DisplayProduct(currentProduct);
        }

        private void DisplayProduct(produit currentProduct)
        {
            // permet d'afficher les informations d'un produit
            if (currentProduct == null)
                return;
            if (currentProduct.photo != null)
            {
                MemoryStream ms = new MemoryStream(currentProduct.photo);
                Image returnImage = Image.FromStream(ms);
                productImage.Image = returnImage;
            }
            tbProductName.Text = currentProduct.designation;
            tbPrice.Text = currentProduct.prix.ToString();
            rtbDesc.Text = currentProduct.description;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // permet de passer à l'objet suivant, s'il en existe pas : on revient au 1er
            if (!(currentListProduct.Count > currentListProduct.IndexOf(currentProduct) + 1))
            {
                currentProduct = currentListProduct.FirstOrDefault();
                DisplayProduct(currentProduct);
            }
            else
            {
                currentProduct = currentListProduct[currentListProduct.IndexOf(currentProduct) + 1];
                DisplayProduct(currentProduct);
            }                
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // permet de passe à l'objet précédent, si'il existe pas : on passe au dernier objet
            if (currentListProduct.IndexOf(currentProduct) - 1 < 0)
            {
                currentProduct = currentListProduct.LastOrDefault();
                DisplayProduct(currentProduct);
            }
            else
            {
                currentProduct = currentListProduct[currentListProduct.IndexOf(currentProduct) - 1];
                DisplayProduct(currentProduct);
            }
        }

        private void btnAddBasket_Click(object sender, EventArgs e)
        {
            // ajoute le produit courant au panier avec la quantité indiquée. Il met à jour le tableau
            int currentQty;
            if (!Int32.TryParse(tbQty.Text,out currentQty))
                using (var info = new InformationBox("Veuillez entrer une quantité numérique"))
                {
                    info.ShowDialog();
                    tbQty.Text = string.Empty;
                    return;
                }

            if (Basket.Select(p => p.Key.designation).ToList().Contains(currentProduct.designation))
                Basket[currentProduct] = Basket[currentProduct] + currentQty;
            else
                Basket.Add(currentProduct, currentQty);
            dgvBasket.Rows.Clear();
            foreach (var prod in Basket)
                dgvBasket.Rows.Add(prod.Key.designation,prod.Value.ToString());
            tbQty.Text = string.Empty;
        }
    }
}
