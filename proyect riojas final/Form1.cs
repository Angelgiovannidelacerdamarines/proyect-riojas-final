namespace proyect_riojas_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBoxskate.Items.Add("");
            listBoxskate.Items.Add("skateboarding");
            listBoxskate.Items.Add("lomboard");
            listBoxskate.Items.Add("penny");
            listBoxskate.SelectedIndexChanged += new EventHandler(listBoxskate_SelectedIndexChanged);


            listlenght.Items.Add("");
            listlenght.Items.Add("7.25 plg");
            listlenght.Items.Add("7.5 plg");
            listlenght.Items.Add("7.75 plg");
            listlenght.Items.Add("7.8 plg");
            listlenght.Items.Add("8 plg");
            listlenght.Items.Add("8.25 plg");
            listlenght.SelectedIndexChanged += new EventHandler(listlenght_SelectedIndexChanged);

            listbrands.Items.Add("Trasher");
            listbrands.Items.Add("santa cruz");
            listbrands.Items.Add("element");
            listbrands.Items.Add("krooked");
            
            listbrands.Items.Add("loko7");

            listbrands.SelectedIndexChanged += new EventHandler(listbrands_SelectedIndexChanged);
        }



        public void listBoxskate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typskt = listBoxskate.SelectedItem.ToString();

            switch (typskt)

            {
                case "":

                    txtstore.Text = ""; break;

                case "skateboarding":
                    txtstore.Text = "skateboarding"; break;
                case "lomboard":
                    txtstore.Text = "lomboard"; break;
                case "penny":
                    txtstore.Text = "penny"; break;





            }

        }

        public void listlenght_SelectedIndexChanged(object sender, EventArgs e)
        {

            string lnght = listlenght.SelectedItem.ToString();

            switch (lnght)

            {
                case "":

                    txtstore.Text = ""; break;

                case "7.25 plg":
                    txtlnght.Text = "7.25 plg"; break;
                case "7.5 plg":
                    txtlnght.Text = "7.5 plg"; break;
                case "7.75 plg":
                    txtlnght.Text = "7.75 plg"; break;
                case "7.8 plg":
                    txtlnght.Text = "7.8 plg"; break;

                case "8 plg":
                    txtlnght.Text = "8 plg"; break;
                case "8.25 plg":
                    txtlnght.Text = "8.25 plg"; break;


            }
        }

        private void txtstore_TextChanged(object sender, EventArgs e)
        {

        }

        private void listbrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lstbrnds = listbrands.SelectedIndex;
            int vl = 0;
            string brnds = string.Empty;

            switch (lstbrnds)

            {
                case 0:
                    vl = 0;
                    brnds = "";break; 
                case 1:
                    vl = 1699;
                    brnds = "trasher"; break;
                case 2:
                    vl =1350 ;
                    brnds = "santa cruz"; break;
                case 3:
                    vl =1450 ;
                    brnds = "element"; break;
                case 4:
                    vl =1380 ;
                    brnds = "krooked"; break;
                case 5:
                    vl =789 ;
                    brnds = "loko 7"; break;

                    txtbrnds.Text= brnds;





            }
        }
    }
}
    