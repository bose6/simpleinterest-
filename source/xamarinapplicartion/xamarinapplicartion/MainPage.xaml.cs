using System;
using Xamarin.Forms;

namespace xamarinapplicartion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            
            InitializeComponent();
            txtamt.Text = String.Empty;
            txttime.Text = String.Empty;
            txtint.Text = String.Empty;
            lblamt.Text = String.Empty;
            lblint.Text = String.Empty;
            lbltime.Text = String.Empty;
            lblans.Text = String.Empty;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //calculae
            try
            {
                show.IsVisible = true;
                string txtamount = txtamt.Text;
                string txttim = txttime.Text;
                string txtinterst = txtint.Text;
                double ans;


                ans = (double.Parse(txtamount) * double.Parse(txtinterst) * double.Parse(txttim)) / 100;

                lblamt.Text = "Principal Amount:" + txtamount + " ₹";
                lblint.Text = "Interest Rate :" + txtinterst + " %";
                lbltime.Text = "Number of Year:" + txttim;
                lblans.Text ="Interest is :" + Convert.ToString(ans) + " ₹";


            }
            catch(Exception)
            {

            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            //clear
            show.IsVisible = false;
            txtamt.Text = String.Empty;
            txttime.Text = String.Empty;
            txtint.Text = String.Empty;
            lblamt.Text = String.Empty;
            lblint.Text = String.Empty;
            lbltime.Text = String.Empty;
            lblans.Text = String.Empty;
        }
    }

}
