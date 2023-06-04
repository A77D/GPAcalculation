namespace GPAcalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TXT_ALSA3AT.Text = "0";
            TXT_fasle.Text = "0";
            TXT_TRAKME.Text = "0";
            TXT_TRAKMESABK.Text = "0";
            MSAK_1.Text = "0";
            MSAK_2.Text = "0";
            MSAK_3.Text = "0";
            MSAK_4.Text = "0";
            MSAK_5.Text = "0";
            MSAK_6.Text = "0";
            MSAK_7.Text = "0";
            MSAK_8.Text = "0";
            ADDMASAK1.Text = "0";
            ADDMASAK2.Text = "0";
            ADDMASAK3.Text = "0";
            ADDMASAK4.Text = "0";
            ADDMASAK5.Text = "0";
            ADDMASAK6.Text = "0";
            ADDMASAK7.Text = "0";
            ADDMASAK8.Text = "0";

            M3AD_1.Text = "0";
            M3AD_2.Text = "0";
            M3AD_3.Text = "0";
            M3AD_4.Text = "0";
            M3AD_5.Text = "0";
            M3AD_6.Text = "0";
            M3AD_7.Text = "0";
            M3AD_8.Text = "0";

        }

        private void M3AD_7_TextChanged(object sender, EventArgs e)
        {

        }


        private void BTM_Calculate_Click(object sender, EventArgs e)
        {
            string sub1 = MSAK_1.Text;
            double Sub1 = double.Parse(sub1);
            string sub2 = MSAK_2.Text;
            double Sub2 = double.Parse(sub2);

            string sub3 = MSAK_3.Text;
            double Sub3 = double.Parse(sub3);

            string sub4 = MSAK_4.Text;
            double Sub4 = double.Parse(sub4);

            string sub5 = MSAK_5.Text;
            double Sub5 = double.Parse(sub5);

            string sub6 = MSAK_6.Text;
            double Sub6 = double.Parse(sub6);

            string sub7 = MSAK_7.Text;
            double Sub7 = double.Parse(sub7);

            string sub8 = MSAK_8.Text;
            double Sub8 = double.Parse(sub8);

            string addsub1 = ADDMASAK1.Text;
            int Addsub1 = int.Parse(addsub1);
            string addsub2 = ADDMASAK2.Text;
            int Addsub2 = int.Parse(addsub2);
            string addsub3 = ADDMASAK3.Text;
            int Addsub3 = int.Parse(addsub3);
            string addsub4 = ADDMASAK4.Text;
            int Addsub4 = int.Parse(addsub4);
            string addsub5 = ADDMASAK5.Text;
            int Addsub5 = int.Parse(addsub5);
            string addsub6 = ADDMASAK6.Text;
            int Addsub6 = int.Parse(addsub6);
            string addsub7 = ADDMASAK7.Text;
            int Addsub7 = int.Parse(addsub7);
            string addsub8 = ADDMASAK8.Text;
            int Addsub8 = int.Parse(addsub8);

            string m3ad1 = M3AD_1.Text;
            double M3ad1 = double.Parse(m3ad1);
            string m3ad2 = M3AD_2.Text;
            double M3ad2 = double.Parse(m3ad2);
            string m3ad3 = M3AD_3.Text;
            double M3ad3 = double.Parse(m3ad3);
            string m3ad4 = M3AD_4.Text;
            double M3ad4 = double.Parse(m3ad4);
            string m3ad5 = M3AD_5.Text;
            double M3ad5 = double.Parse(m3ad5);
            string m3ad6 = M3AD_6.Text;
            double M3ad6 = double.Parse(m3ad6);
            string m3ad7 = M3AD_7.Text;
            double M3ad7 = double.Parse(m3ad7);
            string m3ad8 = M3AD_8.Text;
            double M3ad8 = double.Parse(m3ad8);

            double De = 1;
            double avg = 0;
            int count = 0;
            if (Sub1 != 0)
            {
                De = (Sub1 * Addsub1) + avg;
                count = count + Addsub1;
            }
            if (Sub2 != 0)
            {
                De = (Sub2 * Addsub2) + De;
                count = count + Addsub2;
            }
            if (Sub3 != 0)
            {
                De = (Sub3 * Addsub3) + De;
                count = count + Addsub3;
            }
            if (Sub4 != 0)
            {
                De = (Sub4 * Addsub4) + De;
                count = count + Addsub4;

            }
            if (Sub5 != 0)
            {
                De = (Sub5 * Addsub5) + De;
                count = count + Addsub5;

            }
            if (Sub6 != 0)
            {
                De = (Sub6 * Addsub6) + De;
                count = count + Addsub6;
            }
            if (Sub7 != 0)
            {
                De = (Sub7 * Addsub7) + De;
                count = count + Addsub7;
            }
            if (Sub8 != 0)
            {
                De = (Sub8 * Addsub8) + De;
                count = count + Addsub8;
            }
            string trakme = TXT_TRAKMESABK.Text;
            double Trakme = double.Parse(trakme);

            string sa3at = TXT_ALSA3AT.Text;
            int Sa3at = int.Parse(sa3at);

            double m3d = 0;
            double favrg = De / count;

            if (M3ad1 != 0)
            {
                m3d = M3ad1 * Addsub1;
                De = De - m3d;
                count = count - Addsub1;

            }
            if (M3ad2 != 0)
            {
                m3d = M3ad2 * Addsub2;
                De = De - m3d;
                count = count - Addsub2;

            }
            if (M3ad3 != 0)
            {
                m3d = M3ad3 * Addsub3;
                De = De - m3d;
                count = count - Addsub3;

            }
            if (M3ad4 != 0)
            {
                m3d = M3ad4 * Addsub4;
                De = De - m3d;
                count = count - Addsub4;

            }
            if (M3ad5 != 0)
            {
                m3d = M3ad5 * Addsub5;
                De = De - m3d;
                count = count - Addsub5;

            }
            if (M3ad6 != 0)
            {
                m3d = M3ad6 * Addsub6;
                De = De - m3d;
                count = count - Addsub6;

            }
            if (M3ad7 != 0)
            {
                m3d = M3ad7 * Addsub7;
                De = De - m3d;
                count = count - Addsub7;

            }
            if (M3ad8 != 0)
            {
                m3d = M3ad8 * Addsub8;
                De = De - m3d;
                count = count - Addsub8;

            }
            double avrg = ((Trakme * Sa3at) + De) / (count + Sa3at);

            TXT_TRAKME.Text = "0";
            TXT_fasle.Text = "0";
            TXT_TRAKME.Text = avrg.ToString();
            TXT_fasle.Text = favrg.ToString();


        }

        private void Parse(TextBox mSAK_1)
        {
            throw new NotImplementedException();
        }

        private void TXT_TRAKME_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_fasle_TextChanged(object sender, EventArgs e)
        {

        }

        private void MSAK_4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ADDMASAK1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}