using Magasin.BO;
using Magasin.Module;
using Magasin.Module.Tools;
using Magasin.VenteProduit;
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
        private List<CartesBancaire> cartes;
        public  static Dictionary<produit, int> Basket;

        private LoginBox identification;
        private SignIn inscription;
        private ClientInformation infoClient;
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
                pagePayment = new Payment(CurrentClient);
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

        private ClientInformation InfoClient
        {
            get
            {
                if (infoClient == null)
                {
                    infoClient = new ClientInformation(CurrentClient, null);
                    infoClient.FormClosing += this.CloseClientInformation;
                }
                return infoClient;
            }
        }

        private SignIn Inscription
        {
            get
            {
                if (inscription == null)
                {
                    inscription = new SignIn();
                    inscription.FormClosing += this.CloseInscription;
                }
                return inscription;
            }
        }

        

        #endregion
        
        public MainMenu()
        {
            InitializeComponent();
        }


        #region events

        private void pbPurchase_MouseEnter(object sender, EventArgs e)
        {
            // permet d'effet de grossissement de l'icône
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
            // instancie la page purchase et de la mettre au 1er plan
            PagePurchase.ShowDialog();
            PagePurchase.Focus();
        }

        private void pbPayment_Click(object sender, EventArgs e)
        {
            // on vérifie qu'un utilisateur est connecté puis on instancie la page demandée
            if (CurrentClient == null)
                using (var info = new InformationBox("Veuillez tout d'abord vous connecter s'il vous plaît"))
                {
                    info.ShowDialog();
                    return;
                }

            PagePayment.ShowDialog();
            PagePayment.Focus();
        }

        private void pbDelivery_Click(object sender, EventArgs e)
        {
            PageDelivery.ShowDialog();
            PageDelivery.Focus();
        }

        private void llblConnected_Click(object sender, EventArgs e)
        {
            // on instancie la fenêtre d'identification et si elle nous a retourné un client, on rend accessible son profil
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
            // on charge les icônes lorsque l'on charge le menu
            pbDelivery.Image = SR.icone_livraison;
            pbPayment.Image = SR.icone_payment;
            pbPurchase.Image = SR.icone_achat;
        }

        private void MainMenu_MouseEnter(object sender, EventArgs e)
        {
            //on modifie la zone des icônes pour qu'elles puissent grossir
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
            //si un client est connecté, on peut instancier la fenêtre profil
            if (CurrentClient == null)
                return;

            using (InfoClient)
            {
                InfoClient.ShowDialog();
            }
        }

        private void llblSignIn_Click(object sender, EventArgs e)
        {
            // permet la création d'un profil
            using (Inscription)
            {
                if (Inscription.ShowDialog()==DialogResult.OK)
                {
                    InformationBox info = new InformationBox("Le profil a été créé avec succès");
                    using (info)
                    {
                        info.ShowDialog();
                    }
                }
            }
        }

        #endregion

        private void BiggerEffect (PictureBox picture, Bitmap newImage)
        {
            // augmente la taille des zones d'image 
            if (picture.Width != size)
            {
                picture.Width = size;
                picture.Height = size;
                picture.Image = newImage;
            }
        }

        private void ClosePageDelivery(object sender, FormClosingEventArgs e)
        {
            // on libère les ressources
            pageDelivery.Dispose();
            pageDelivery = null;
        }

        private void ClosePagePurchase(object sender, FormClosingEventArgs e)
        {
            Basket = pagePurchase.Basket;
            pagePurchase.Dispose();
            pagePurchase = null;
        }

        private void ClosePagePayment(object sender, FormClosingEventArgs e)
        {
            // on libère les ressources et on vide le panier
            pagePayment.Dispose();
            pagePayment = null;
            Basket = null;
        }

        private void CloseLoginBox(object sender, FormClosingEventArgs e)
        {
            if (Identification.CurrentClient != null)
                CurrentClient = Identification.CurrentClient;
            identification.Dispose();
            identification = null;
        }

        private void CloseInscription(object sender, FormClosingEventArgs e)
        {
            inscription.Dispose();
            inscription = null;
        }

        private void CloseClientInformation(object sender, FormClosingEventArgs e)
        {
            infoClient.Dispose();
            infoClient = null;
        }
    }
}
