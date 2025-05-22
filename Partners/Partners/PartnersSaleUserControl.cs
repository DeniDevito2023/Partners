using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Partners.Model;

namespace Partners
{
    public partial class PartnersSaleUserControl : UserControl
    {
        public PartnersSaleUserControl(Partner partnes)
        {
            InitializeComponent();
            TypeLbl.Text = $"{partnes.TypePartners} | {partnes.NamePartners}";
            DirectorLbl.Text = partnes.Director;
            PhoneLbl.Text = partnes.Phone.ToString();
           
            RatingLbl.Text = $"Рейтинг: { partnes.Rating.ToString()}";
            //var count = partnes.SalePartnersProducts.Count;
            var sumSale = 0;
            //foreach (var product in partnes.SalePartnersProducts) {

            //    sumSale += product.SaleAmount;
            //}

            sumSale = partnes.SalePartnersProducts.Sum(product => product.SaleAmount);

            var skidka = 0;

            if (sumSale < 10000) { 
            
            skidka = 0;
            
            } else if (sumSale <50000)
            {
                skidka = 5;

            } else if (sumSale < 300000) {

                skidka = 10;

            } else if (sumSale >= 300000) {
                skidka = 15;
            };

                DiscountLbl.Text = skidka.ToString() + " %";

        }
    }
}
