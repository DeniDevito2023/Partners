using Microsoft.EntityFrameworkCore;
using Partners.Model;

namespace Partners
{
    public partial class PartnersForm : Form
    {
        public PartnersForm()
        {
            InitializeComponent();
        }

        private void PartnersForm_Load(object sender, EventArgs e)
        {

            LayoutPanelPartners.Controls.Clear();   
            PartnersSaleContext partnersSaleContext = new PartnersSaleContext();

            var anyPartners = partnersSaleContext.Partners
                .Include(f => f.SalePartnersProducts);
                //.ThenInclude(g => g.SaleNameProductsFkNavigation)
                //.ThenInclude(r => r.TypeProductsNavigation)
                //.ToList();

            foreach (var partners in anyPartners) { 
            
            PartnersSaleUserControl partnersSaleUserControl = new PartnersSaleUserControl(partners);

                LayoutPanelPartners.Controls.Add(partnersSaleUserControl);

            }
        }
    }
}
