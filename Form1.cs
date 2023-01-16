namespace BellarmineFinancials
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTotalCurrentAssets_TextChanged(object sender, EventArgs e)
        {
            //double total = txtCash + txt
        }

        private void btnCalculateCA_Click(object sender, EventArgs e)
        {


            double total = double.Parse(txtCash.Text) + double.Parse(txtInventory.Text) + 
                            double.Parse(txtSupplies.Text) + double.Parse(txtTemporaryInvestments.Text);
            txtTotalCurrentAssets.Text = total.ToString("C");

        
        }

        private void btnCalculateCL_Click(object sender, EventArgs e)
        {
            txtTotalCurrentLiabilities.Text = "";
            double total = double.Parse(txtAccountsPayable.Text) + double.Parse(txtNotesPayable.Text) +
                            double.Parse(txtInterestPayable.Text) + double.Parse(txtAccruedExpenses.Text);
            txtTotalCurrentLiabilities.Text = total.ToString("C");
        }

        private void btnTotalIPE_Click(object sender, EventArgs e)
        {
            txtTotalInvestmentPropertyandEquip.Text = "";
            double total = double.Parse(txtLand.Text) + double.Parse(txtBuildingandImprovements.Text) +
                            double.Parse(txtEquipment.Text) + double.Parse(txtTemporaryInvestments1.Text);
            txtTotalInvestmentPropertyandEquip.Text = total.ToString("C");
        }

        private void btnCalculateLTL_Click(object sender, EventArgs e)
        {
            txtTotalLTL.Text = "";
            double total = double.Parse(txtNotes.Text) + double.Parse(txtBonds.Text);
            txtTotalLTL.Text = total.ToString("C");
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            txtTotalIntangibles.Text = "";
            double total = double.Parse(txtTradeName.Text) + double.Parse(txtGoodwill.Text);
            txtTotalIntangibles.Text = total.ToString("C");
        }

        private void btnTotalPosition_Click(object sender, EventArgs e)
        {
            txtTotalAssets.Text = "";
            double totalAssets = double.Parse(txtCash.Text) + double.Parse(txtInventory.Text) +
                                double.Parse(txtSupplies.Text) + double.Parse(txtTemporaryInvestments.Text) + 
                                double.Parse(txtLand.Text) + double.Parse(txtBuildingandImprovements.Text) + 
                                double.Parse(txtEquipment.Text) + double.Parse(txtTemporaryInvestments1.Text) +
                                double.Parse(txtTradeName.Text) + double.Parse(txtGoodwill.Text);
            txtTotalAssets.Text = totalAssets.ToString("C");

            txtTotalLiabilities.Text = "";
            double totalLiabilities = double.Parse(txtAccountsPayable.Text) +
                                        double.Parse(txtNotesPayable.Text) + 
                                        double.Parse(txtInterestPayable.Text) +
                                        double.Parse(txtAccruedExpenses.Text) +
                                        double.Parse(txtNotes.Text) + double.Parse(txtBonds.Text);
           txtTotalLiabilities.Text = totalLiabilities.ToString("C");

           double position = totalAssets - totalLiabilities;
           txtPosition.Text = position.ToString("C");
        }
    }
}