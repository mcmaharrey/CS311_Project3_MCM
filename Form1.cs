namespace CS311_Project3_MCM
{
    public partial class Form1 : Form
    {
        private decimal Small = 2.00m;
        private decimal Medium = 5.00m;
        private decimal Large = 10.00m;
        private decimal XLarge = 15.00m;
        private decimal Ginormous = 20.00m;
        private decimal Pepperoni = 2.00m;
        private decimal Sausage = 2.00m;
        private decimal CanadianBacon = 2.00m;
        private decimal Spicyitalian = 2.00m;
        private decimal Onion = 1.00m;
        private decimal GreenPepper = 1.00m;
        private decimal BlackOlive = 1.00m;
        private decimal GreenOlive = 1.00m;
        private decimal BananaPep = 1.00m;
        private decimal Jalapeno = 1.00m;
        private decimal ExtraCheese = 1.00m;
        private decimal Mushroom = 1.00m;



        public Form1()
        {
            InitializeComponent();
        }

        private decimal CalculateSubtotal()
        {
            decimal sizePrice = 0;
            decimal toppingPrice = 0;

            switch (cboSize.SelectedItem.ToString())
            {
                case "Small":
                    sizePrice = Small;
                    break;
                case "Medium":
                    sizePrice = Medium;
                    break;
                case "Large":
                    sizePrice = Large;
                    break;
                case "X-Large":
                    sizePrice = XLarge;
                    break;
                case "Ginormous":
                    sizePrice = Ginormous;
                    break;
            }

            foreach (Control control in grpPizza.Controls)
            {
                if (control is CheckBox && ((CheckBox)control).Checked)
                {
                    String toppingName = ((CheckBox)control).Text;

                    switch (toppingName)
                    {
                        case "Pepperoni":
                            toppingPrice += Pepperoni;
                            break;
                        case "Sausage":
                            toppingPrice += Sausage;
                            break;
                        case "Canadian Bacon":
                            toppingPrice += CanadianBacon;
                            break;
                        case "Spicy Italian Sausage":
                            toppingPrice += Spicyitalian;
                            break;
                        case "Onion":
                            toppingPrice += Onion;
                            break;
                        case "Green Pepper":
                            toppingPrice += GreenPepper;
                            break;
                        case "Black Olives":
                            toppingPrice += BlackOlive;
                            break;
                        case "Green Olives":
                            toppingPrice += GreenOlive;
                            break;
                        case "Banana Peppers":
                            toppingPrice += BananaPep;
                            break;
                        case "Jalapeno":
                            toppingPrice += Jalapeno;
                            break;
                        case "Extra Cheese":
                            toppingPrice += ExtraCheese;
                            break;
                        case "Mushroom":
                            toppingPrice += Mushroom;
                            break;
                    }
                }
            }
            return sizePrice + toppingPrice;
        }


        void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subTotal = CalculateSubtotal();
            decimal tax = subTotal * 0.06m;
            decimal total = subTotal + tax;

            rtfSub.Text = subTotal.ToString("C");
            rtfTax.Text = tax.ToString("C");
            rtfTotal.Text = total.ToString("C");

            rtfSummary.Clear();
            rtfSummary.AppendText("You ordered a " + cboSize.SelectedItem + " pizza with and the following:\n");

            foreach (Control control in grpPizza.Controls)
            {
                if (control is RadioButton && ((RadioButton)control).Checked)
                {
                    rtfSummary.AppendText(((RadioButton)control).Text + " Crust \n");
                    break;
                }
            }

            rtfSummary.AppendText("Toppings:\n");

            foreach (Control control in grpPizza.Controls)
            {
                if (control is CheckBox && ((CheckBox)control).Checked)
                {
                    string toppingName = ((CheckBox)control).Text;
                    decimal toppingPrice;

                    switch (toppingName)
                    {
                        case "Pepperoni":
                            toppingPrice = Pepperoni;
                            break;
                        case "Sausage":
                            toppingPrice = Sausage;
                            break;
                        case "Canadian Bacon":
                            toppingPrice = CanadianBacon;
                            break;
                        case "Spicy Italian Sausage":
                            toppingPrice = Spicyitalian;
                            break;
                        case "Onion":
                            toppingPrice = Onion;
                            break;
                        case "Green Pepper":
                            toppingPrice = GreenPepper;
                            break;
                        case "Black Olives":
                            toppingPrice = BlackOlive;
                            break;
                        case "Green Olives":
                            toppingPrice = GreenOlive;
                            break;
                        case "Banana Peppers":
                            toppingPrice = BananaPep;
                            break;
                        case "Jalapeno":
                            toppingPrice = Jalapeno;
                            break;
                        case "Extra Cheese":
                            toppingPrice = ExtraCheese;
                            break;
                        case "Mushroom":
                            toppingPrice = Mushroom;
                            break;
                    }

                    rtfSummary.AppendText($"- {toppingName}\n");
                }
            }
        }
    }//end class 
}//end namespace