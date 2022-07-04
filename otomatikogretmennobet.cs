using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dphv1
{
    public partial class otomatikogretmennobet : Form
    {
        public otomatikogretmennobet()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            if (checkBox1.Checked == true)
            {
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(textBox1.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi1 = rnd.Next(1, 5);
            if (sayi1 == 1)
            { // rnd.next(1,4) dersen 4 dahil değil! ama 1 dahil
                pazartesiyer1.Text = listBox1.Items[3].ToString();
                pazartesiyer2.Text = listBox1.Items[6].ToString();
                pazartesiyer3.Text = listBox1.Items[10].ToString();

                saliyer1.Text = listBox1.Items[13].ToString();
                saliyer2.Text = listBox1.Items[12].ToString();
                saliyer3.Text = listBox1.Items[1].ToString();

                carsambayer1.Text = listBox1.Items[9].ToString();
                carsambayer2.Text = listBox1.Items[2].ToString();
                carsambayer3.Text = listBox1.Items[0].ToString();

                persembeyer1.Text = listBox1.Items[11].ToString();
                persembeyer2.Text = listBox1.Items[4].ToString();
                persembeyer3.Text = listBox1.Items[7].ToString();

                cumayer1.Text = listBox1.Items[14].ToString();
                cumayer2.Text = listBox1.Items[5].ToString();
                cumayer3.Text = listBox1.Items[8].ToString();
            }

            if (sayi1 == 2) {
                pazartesiyer1.Text = listBox1.Items[7].ToString();
                pazartesiyer2.Text = listBox1.Items[11].ToString();
                pazartesiyer3.Text = listBox1.Items[14].ToString();

                saliyer1.Text = listBox1.Items[6].ToString();
                saliyer2.Text = listBox1.Items[12].ToString();
                saliyer3.Text = listBox1.Items[10].ToString();

                carsambayer1.Text = listBox1.Items[3].ToString();
                carsambayer2.Text = listBox1.Items[1].ToString();
                carsambayer3.Text = listBox1.Items[13].ToString();

                persembeyer1.Text = listBox1.Items[8].ToString();
                persembeyer2.Text = listBox1.Items[2].ToString();
                persembeyer3.Text = listBox1.Items[5].ToString();

                cumayer1.Text = listBox1.Items[0].ToString();
                cumayer2.Text = listBox1.Items[9].ToString();
                cumayer3.Text = listBox1.Items[4].ToString();
            }

            if (sayi1 == 3)
            {
                pazartesiyer1.Text = listBox1.Items[10].ToString();
                pazartesiyer2.Text = listBox1.Items[12].ToString();
                pazartesiyer3.Text = listBox1.Items[9].ToString();

                saliyer1.Text = listBox1.Items[7].ToString();
                saliyer2.Text = listBox1.Items[13].ToString();
                saliyer3.Text = listBox1.Items[8].ToString();

                carsambayer1.Text = listBox1.Items[14].ToString();
                carsambayer2.Text = listBox1.Items[3].ToString();
                carsambayer3.Text = listBox1.Items[11].ToString();

                persembeyer1.Text = listBox1.Items[4].ToString();
                persembeyer2.Text = listBox1.Items[1].ToString();
                persembeyer3.Text = listBox1.Items[6].ToString();

                cumayer1.Text = listBox1.Items[0].ToString();
                cumayer2.Text = listBox1.Items[5].ToString();
                cumayer3.Text = listBox1.Items[2].ToString();
            }



            if (sayi1 == 4)
            {
                pazartesiyer1.Text = listBox1.Items[13].ToString();
                pazartesiyer2.Text = listBox1.Items[9].ToString();
                pazartesiyer3.Text = listBox1.Items[6].ToString();

                saliyer1.Text = listBox1.Items[1].ToString();
                saliyer2.Text = listBox1.Items[0].ToString();
                saliyer3.Text = listBox1.Items[14].ToString();

                carsambayer1.Text = listBox1.Items[3].ToString();
                carsambayer2.Text = listBox1.Items[3].ToString();
                carsambayer3.Text = listBox1.Items[10].ToString();

                persembeyer1.Text = listBox1.Items[5].ToString();
                persembeyer2.Text = listBox1.Items[7].ToString();
                persembeyer3.Text = listBox1.Items[11].ToString();

                cumayer1.Text = listBox1.Items[4].ToString();
                cumayer2.Text = listBox1.Items[8].ToString();
                cumayer3.Text = listBox1.Items[12].ToString();
            }







        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi1 = rnd.Next(1, 5);
            if (sayi1 == 1)
            { // rnd.next(1,4) dersen 4 dahil değil! ama 1 dahil
                pazartesiyer1.Text = listBox1.Items[7].ToString();
                pazartesiyer2.Text = listBox1.Items[17].ToString();
                pazartesiyer3.Text = listBox1.Items[0].ToString();
                pazartesiyer4.Text = listBox1.Items[12].ToString();

                saliyer1.Text = listBox1.Items[9].ToString();
                saliyer2.Text = listBox1.Items[1].ToString();
                saliyer3.Text = listBox1.Items[11].ToString();
                saliyer4.Text = listBox1.Items[15].ToString();

                carsambayer1.Text = listBox1.Items[3].ToString();
                carsambayer2.Text = listBox1.Items[14].ToString();
                carsambayer3.Text = listBox1.Items[19].ToString();
                carsambayer4.Text = listBox1.Items[8].ToString();

                persembeyer1.Text = listBox1.Items[2].ToString();
                persembeyer2.Text = listBox1.Items[10].ToString();
                persembeyer3.Text = listBox1.Items[18].ToString();
                persembeyer4.Text = listBox1.Items[5].ToString();

                cumayer1.Text = listBox1.Items[6].ToString();
                cumayer2.Text = listBox1.Items[4].ToString();
                cumayer3.Text = listBox1.Items[13].ToString();
                cumayer4.Text = listBox1.Items[16].ToString();

            }




            if (sayi1 == 2)
            { // rnd.next(1,4) dersen 4 dahil değil! ama 1 dahil
                pazartesiyer1.Text = listBox1.Items[5].ToString();
                pazartesiyer2.Text = listBox1.Items[8].ToString();
                pazartesiyer3.Text = listBox1.Items[13].ToString();
                pazartesiyer4.Text = listBox1.Items[6].ToString();

                saliyer1.Text = listBox1.Items[11].ToString();
                saliyer2.Text = listBox1.Items[14].ToString();
                saliyer3.Text = listBox1.Items[9].ToString();
                saliyer4.Text = listBox1.Items[4].ToString();

                carsambayer1.Text = listBox1.Items[16].ToString();
                carsambayer2.Text = listBox1.Items[17].ToString();
                carsambayer3.Text = listBox1.Items[2].ToString();
                carsambayer4.Text = listBox1.Items[18].ToString();

                persembeyer1.Text = listBox1.Items[19].ToString();
                persembeyer2.Text = listBox1.Items[12].ToString();
                persembeyer3.Text = listBox1.Items[0].ToString();
                persembeyer4.Text = listBox1.Items[1].ToString();

                cumayer1.Text = listBox1.Items[7].ToString();
                cumayer2.Text = listBox1.Items[3].ToString();
                cumayer3.Text = listBox1.Items[10].ToString();
                cumayer4.Text = listBox1.Items[15].ToString();

            }


            if (sayi1 == 3)
            { // rnd.next(1,4) dersen 4 dahil değil! ama 1 dahil
                pazartesiyer1.Text = listBox1.Items[13].ToString();
                pazartesiyer2.Text = listBox1.Items[19].ToString();
                pazartesiyer3.Text = listBox1.Items[5].ToString();
                pazartesiyer4.Text = listBox1.Items[10].ToString();

                saliyer1.Text = listBox1.Items[17].ToString();
                saliyer2.Text = listBox1.Items[8].ToString();
                saliyer3.Text = listBox1.Items[1].ToString();
                saliyer4.Text = listBox1.Items[14].ToString();

                carsambayer1.Text = listBox1.Items[12].ToString();
                carsambayer2.Text = listBox1.Items[16].ToString();
                carsambayer3.Text = listBox1.Items[3].ToString();
                carsambayer4.Text = listBox1.Items[18].ToString();

                persembeyer1.Text = listBox1.Items[7].ToString();
                persembeyer2.Text = listBox1.Items[0].ToString();
                persembeyer3.Text = listBox1.Items[2].ToString();
                persembeyer4.Text = listBox1.Items[11].ToString();

                cumayer1.Text = listBox1.Items[6].ToString();
                cumayer2.Text = listBox1.Items[8].ToString();
                cumayer3.Text = listBox1.Items[15].ToString();
                cumayer4.Text = listBox1.Items[4].ToString();

            }





            if (sayi1 == 4)
            { // rnd.next(1,4) dersen 4 dahil değil! ama 1 dahil
                pazartesiyer1.Text = listBox1.Items[14].ToString();
                pazartesiyer2.Text = listBox1.Items[6].ToString();
                pazartesiyer3.Text = listBox1.Items[4].ToString();
                pazartesiyer4.Text = listBox1.Items[11].ToString();

                saliyer1.Text = listBox1.Items[10].ToString();
                saliyer2.Text = listBox1.Items[8].ToString();
                saliyer3.Text = listBox1.Items[18].ToString();
                saliyer4.Text = listBox1.Items[19].ToString();

                carsambayer1.Text = listBox1.Items[0].ToString();
                carsambayer2.Text = listBox1.Items[2].ToString();
                carsambayer3.Text = listBox1.Items[15].ToString();
                carsambayer4.Text = listBox1.Items[17].ToString();

                persembeyer1.Text = listBox1.Items[16].ToString();
                persembeyer2.Text = listBox1.Items[5].ToString();
                persembeyer3.Text = listBox1.Items[1].ToString();
                persembeyer4.Text = listBox1.Items[7].ToString();

                cumayer1.Text = listBox1.Items[12].ToString();
                cumayer2.Text = listBox1.Items[9].ToString();
                cumayer3.Text = listBox1.Items[3].ToString();
                cumayer4.Text = listBox1.Items[13].ToString();

            }




        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            Random rnd = new Random();
            int sayi1 = rnd.Next(1, 5);
            if (sayi1 == 1)
            { // rnd.next(1,4) dersen 4 dahil değil! ama 1 dahil
                pazartesiyer1.Text = listBox1.Items[12].ToString();
                pazartesiyer2.Text = listBox1.Items[4].ToString();
                pazartesiyer3.Text = listBox1.Items[15].ToString();
                pazartesiyer4.Text = listBox1.Items[23].ToString();
                pazartesiyer5.Text = listBox1.Items[3].ToString();

                saliyer1.Text = listBox1.Items[6].ToString();
                saliyer2.Text = listBox1.Items[22].ToString();
                saliyer3.Text = listBox1.Items[2].ToString();
                saliyer4.Text = listBox1.Items[8].ToString();
                saliyer5.Text = listBox1.Items[1].ToString();

                carsambayer1.Text = listBox1.Items[13].ToString();
                carsambayer2.Text = listBox1.Items[5].ToString();
                carsambayer3.Text = listBox1.Items[18].ToString();
                carsambayer4.Text = listBox1.Items[14].ToString();
                carsambayer5.Text = listBox1.Items[19].ToString();

                persembeyer1.Text = listBox1.Items[7].ToString();
                persembeyer2.Text = listBox1.Items[24].ToString();
                persembeyer3.Text = listBox1.Items[11].ToString();
                persembeyer4.Text = listBox1.Items[16].ToString();
                persembeyer5.Text = listBox1.Items[20].ToString();

                cumayer1.Text = listBox1.Items[0].ToString();
                cumayer2.Text = listBox1.Items[9].ToString();
                cumayer3.Text = listBox1.Items[17].ToString();
                cumayer4.Text = listBox1.Items[21].ToString();
                cumayer5.Text = listBox1.Items[10].ToString();

            }



            if (sayi1 == 2)
            { // rnd.next(1,4) dersen 4 dahil değil! ama 1 dahil
                pazartesiyer1.Text = listBox1.Items[18].ToString();
                pazartesiyer2.Text = listBox1.Items[23].ToString();
                pazartesiyer3.Text = listBox1.Items[21].ToString();
                pazartesiyer4.Text = listBox1.Items[19].ToString();
                pazartesiyer5.Text = listBox1.Items[22].ToString();

                saliyer1.Text = listBox1.Items[14].ToString();
                saliyer2.Text = listBox1.Items[0].ToString();
                saliyer3.Text = listBox1.Items[17].ToString();
                saliyer4.Text = listBox1.Items[6].ToString();
                saliyer5.Text = listBox1.Items[16].ToString();

                carsambayer1.Text = listBox1.Items[4].ToString();
                carsambayer2.Text = listBox1.Items[7].ToString();
                carsambayer3.Text = listBox1.Items[1].ToString();
                carsambayer4.Text = listBox1.Items[20].ToString();
                carsambayer5.Text = listBox1.Items[24].ToString();

                persembeyer1.Text = listBox1.Items[5].ToString();
                persembeyer2.Text = listBox1.Items[12].ToString();
                persembeyer3.Text = listBox1.Items[3].ToString();
                persembeyer4.Text = listBox1.Items[13].ToString();
                persembeyer5.Text = listBox1.Items[11].ToString();

                cumayer1.Text = listBox1.Items[15].ToString();
                cumayer2.Text = listBox1.Items[9].ToString();
                cumayer3.Text = listBox1.Items[8].ToString();
                cumayer4.Text = listBox1.Items[10].ToString();
                cumayer5.Text = listBox1.Items[2].ToString();

            }


            if (sayi1 == 3)
            { // rnd.next(1,4) dersen 4 dahil değil! ama 1 dahil
                pazartesiyer1.Text = listBox1.Items[19].ToString();
                pazartesiyer2.Text = listBox1.Items[6].ToString(); 
                pazartesiyer3.Text = listBox1.Items[24].ToString();  
                pazartesiyer4.Text = listBox1.Items[8].ToString();
                pazartesiyer5.Text = listBox1.Items[23].ToString();

                saliyer1.Text = listBox1.Items[1].ToString();
                saliyer2.Text = listBox1.Items[11].ToString();
                saliyer3.Text = listBox1.Items[0].ToString();
                saliyer4.Text = listBox1.Items[13].ToString();
                saliyer5.Text = listBox1.Items[20].ToString();

                carsambayer1.Text = listBox1.Items[14].ToString();
                carsambayer2.Text = listBox1.Items[10].ToString();
                carsambayer3.Text = listBox1.Items[17].ToString();
                carsambayer4.Text = listBox1.Items[2].ToString();
                carsambayer5.Text = listBox1.Items[7].ToString();

                persembeyer1.Text = listBox1.Items[21].ToString();
                persembeyer2.Text = listBox1.Items[5].ToString();
                persembeyer3.Text = listBox1.Items[18].ToString();
                persembeyer4.Text = listBox1.Items[3].ToString();
                persembeyer5.Text = listBox1.Items[22].ToString();

                cumayer1.Text = listBox1.Items[16].ToString();
                cumayer2.Text = listBox1.Items[12].ToString();
                cumayer3.Text = listBox1.Items[4].ToString();
                cumayer4.Text = listBox1.Items[15].ToString();
                cumayer5.Text = listBox1.Items[9].ToString();

            }


            if (sayi1 == 4)
            { // rnd.next(1,4) dersen 4 dahil değil! ama 1 dahil
                pazartesiyer1.Text = listBox1.Items[21].ToString();
                pazartesiyer2.Text = listBox1.Items[12].ToString();
                pazartesiyer3.Text = listBox1.Items[17].ToString();
                pazartesiyer4.Text = listBox1.Items[14].ToString();
                pazartesiyer5.Text = listBox1.Items[4].ToString();

                saliyer1.Text = listBox1.Items[13].ToString();
                saliyer2.Text = listBox1.Items[15].ToString();
                saliyer3.Text = listBox1.Items[5].ToString();
                saliyer4.Text = listBox1.Items[23].ToString();
                saliyer5.Text = listBox1.Items[3].ToString();

                carsambayer1.Text = listBox1.Items[7].ToString();
                carsambayer2.Text = listBox1.Items[0].ToString();
                carsambayer3.Text = listBox1.Items[24].ToString();
                carsambayer4.Text = listBox1.Items[16].ToString();
                carsambayer5.Text = listBox1.Items[20].ToString();

                persembeyer1.Text = listBox1.Items[18].ToString();
                persembeyer2.Text = listBox1.Items[11].ToString();
                persembeyer3.Text = listBox1.Items[2].ToString();
                persembeyer4.Text = listBox1.Items[9].ToString();
                persembeyer5.Text = listBox1.Items[1].ToString();

                cumayer1.Text = listBox1.Items[22].ToString();
                cumayer2.Text = listBox1.Items[10].ToString();
                cumayer3.Text = listBox1.Items[8].ToString();
                cumayer4.Text = listBox1.Items[19].ToString();
                cumayer5.Text = listBox1.Items[6].ToString();

            }


        }

        private void otomatikogretmennobet_Load(object sender, EventArgs e)
        {
            pazartesiyer1.Text = "";
            pazartesiyer2.Text = "";
            pazartesiyer3.Text = "";
            pazartesiyer4.Text = "";
            pazartesiyer5.Text = "";
            saliyer1.Text = "";
            saliyer2.Text = "";
            saliyer3.Text = "";
            saliyer4.Text = "";
            saliyer5.Text = "";
            carsambayer1.Text = "";
            carsambayer2.Text = "";
            carsambayer3.Text = "";
            carsambayer4.Text = "";
            carsambayer5.Text = "";
            persembeyer1.Text = "";
            persembeyer2.Text = "";
            persembeyer3.Text = "";
            persembeyer4.Text = "";
            persembeyer5.Text = "";
            cumayer2.Text = "";
            cumayer3.Text = "";
            cumayer4.Text = "";
            cumayer5.Text = "";
            cumayer1.Text = "";





        
        
        }

        private void otomatikogretmennobet_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Tümünü Silmeyi Onaylıyor Musunuz?", "Tümünü Kaldırmak İçin Onay", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    listBox1.Items.Clear();
                    break;
                case DialogResult.Cancel:
                    // Retry butonuna basıldığında yapılacak işlemler
                    break;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                yer1.Text = "Bahçe";
                yer2.Text = "Zemin";
                yer3.Text = "1.Kat";
                yer4.Text = "2.Kat";
                yer5.Text = "3.Kat";
                radioButton1.Text = "1 Katlı (bahçe ve zemin dışında)";
                radioButton2.Text = "2 Katlı (bahçe ve zemin dışında)";
                radioButton3.Text = "3 Katlı (bahçe ve zemin dışında)";
            }
            if (checkBox2.Checked == false)
            {
                yer1.Text = "yer1";
                yer2.Text = "yer2";
                yer3.Text = "yer3";
                yer4.Text = "yer4";
                yer5.Text = "yer5";
                radioButton1.Text = "3 yerli (en az 15 veri girilmeli)";
                radioButton2.Text = "4 yerli (en az 20 veri girilmeli)";
                radioButton3.Text = "5 yerli (en az 25 veri girilmeli)";
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                richTextBox1.Text = "Pazartesi: " + "Görevli: " + pazartesiyer1.Text + " Alanı: Bahçe" + "   " + "Görevli: " + pazartesiyer2.Text + " Alanı: Zemin Kat" + "    " + "Görevli: " + pazartesiyer3.Text + " Alanı: 1.Kat" + "    " + "Görevli: " + pazartesiyer4.Text + " Alanı: 2.Kat" + "    " + "Görevli: " + pazartesiyer5.Text + " Alanı: 3.Kat" + "\n" + "Salı: " + "Görevli: " + saliyer1.Text + " Alanı: Bahçe" + "   " + "Görevli: " + saliyer2.Text + " Alanı: Zemin Kat" + "    " + "Görevli: " + saliyer3.Text + " Alanı: 1.Kat" + "    " + "Görevli: " + saliyer4.Text + " Alanı: 2.Kat" + "    " + "Görevli: " + saliyer5.Text + " Alanı: 3.Kat" + "\n" + "Çarşamba: " + "Görevli: " + carsambayer1.Text + " Alanı: Bahçe" + "   " + "Görevli: " + carsambayer2.Text + " Alanı: Zemin Kat" + "    " + "Görevli: " + carsambayer3.Text + " Alanı: 1.Kat" + "    " + "Görevli: " + carsambayer4.Text + " Alanı: 2.Kat" + "    " + "Görevli: " + carsambayer5.Text + " Alanı: 3.Kat" + "\n" + "Perşembe: " + "Görevli: " + persembeyer1.Text + " Alanı: Bahçe" + "   " + "Görevli: " + persembeyer2.Text + " Alanı: Zemin Kat" + "    " + "Görevli: " + persembeyer3.Text + " Alanı: 1.Kat" + "    " + "Görevli: " + persembeyer4.Text + " Alanı: 2.Kat" + "    " + "Görevli: " + persembeyer5.Text + " Alanı: 3.Kat" + "\n" + "Cuma: " + "Görevli: " + cumayer1.Text + " Alanı: Bahçe" + "   " + "Görevli: " + cumayer2.Text + " Alanı: Zemin Kat" + "    " + "Görevli: " + cumayer3.Text + " Alanı: 1.Kat" + "    " + "Görevli: " + cumayer4.Text + " Alanı: 2.Kat" + "    " + "Görevli: " + cumayer5.Text + " Alanı: 3.Kat" + "\n";
            }

            if (radioButton1.Checked == true)
            {
                richTextBox1.Text = "Pazartesi: " + "Görevli: " + pazartesiyer1.Text + " Alanı: Bahçe" + "   " + "Görevli: " + pazartesiyer2.Text + " Alanı: Zemin Kat" + "    " + "Görevli: " + pazartesiyer3.Text + " Alanı: 1.Kat" + "    " + "Görevli: " + pazartesiyer4.Text + " Alanı: 2.Kat" + "    " + "Görevli: " + pazartesiyer5.Text + " Alanı: 3.Kat" + "\n" + "Salı: " + "Görevli: " + saliyer1.Text + " Alanı: Bahçe" + "   " + "Görevli: " + saliyer2.Text + " Alanı: Zemin Kat" + "    " + "Görevli: " + saliyer3.Text + " Alanı: 1.Kat" + "    " + "Görevli: " + saliyer4.Text + " Alanı: 2.Kat" + "    " + "Görevli: " + saliyer5.Text + " Alanı: 3.Kat" + "\n" + "Çarşamba: " + "Görevli: " + carsambayer1.Text + " Alanı: Bahçe" + "   " + "Görevli: " + carsambayer2.Text + " Alanı: Zemin Kat" + "    " + "Görevli: " + carsambayer3.Text + " Alanı: 1.Kat" + "    " + "Görevli: " + carsambayer4.Text + " Alanı: 2.Kat" + "    " + "Görevli: " + carsambayer5.Text + " Alanı: 3.Kat" + "\n" + "Perşembe: " + "Görevli: " + persembeyer1.Text + " Alanı: Bahçe" + "   " + "Görevli: " + persembeyer2.Text + " Alanı: Zemin Kat" + "    " + "Görevli: " + persembeyer3.Text + " Alanı: 1.Kat" + "    " + "Görevli: " + persembeyer4.Text + " Alanı: 2.Kat" + "    " + "Görevli: " + persembeyer5.Text + " Alanı: 3.Kat" + "\n" + "Cuma: " + "Görevli: " + cumayer1.Text + " Alanı: Bahçe" + "   " + "Görevli: " + cumayer2.Text + " Alanı: Zemin Kat" + "    " + "Görevli: " + cumayer3.Text + " Alanı: 1.Kat" + "    " + "Görevli: " + cumayer4.Text + " Alanı: 2.Kat" + "    " + "Görevli: " + cumayer5.Text + " Alanı: 3.Kat" + "\n";

            }

            if (radioButton2.Checked == true)
            {
                richTextBox1.Text = "Pazartesi: " + "Görevli: " + pazartesiyer1.Text + " Alanı: Bahçe" + "   " + "Görevli: " + pazartesiyer2.Text + " Alanı: Zemin Kat" + "    " + "Görevli: " + pazartesiyer3.Text + " Alanı: 1.Kat" + "    " + "Görevli: " + pazartesiyer4.Text + " Alanı: 2.Kat" + "    " + "Görevli: " + pazartesiyer5.Text + " Alanı: 3.Kat" + "\n" + "Salı: " + "Görevli: " + saliyer1.Text + " Alanı: Bahçe" + "   " + "Görevli: " + saliyer2.Text + " Alanı: Zemin Kat" + "    " + "Görevli: " + saliyer3.Text + " Alanı: 1.Kat" + "    " + "Görevli: " + saliyer4.Text + " Alanı: 2.Kat" + "    " + "Görevli: " + saliyer5.Text + " Alanı: 3.Kat" + "\n" + "Çarşamba: " + "Görevli: " + carsambayer1.Text + " Alanı: Bahçe" + "   " + "Görevli: " + carsambayer2.Text + " Alanı: Zemin Kat" + "    " + "Görevli: " + carsambayer3.Text + " Alanı: 1.Kat" + "    " + "Görevli: " + carsambayer4.Text + " Alanı: 2.Kat" + "    " + "Görevli: " + carsambayer5.Text + " Alanı: 3.Kat" + "\n" + "Perşembe: " + "Görevli: " + persembeyer1.Text + " Alanı: Bahçe" + "   " + "Görevli: " + persembeyer2.Text + " Alanı: Zemin Kat" + "    " + "Görevli: " + persembeyer3.Text + " Alanı: 1.Kat" + "    " + "Görevli: " + persembeyer4.Text + " Alanı: 2.Kat" + "    " + "Görevli: " + persembeyer5.Text + " Alanı: 3.Kat" + "\n" + "Cuma: " + "Görevli: " + cumayer1.Text + " Alanı: Bahçe" + "   " + "Görevli: " + cumayer2.Text + " Alanı: Zemin Kat" + "    " + "Görevli: " + cumayer3.Text + " Alanı: 1.Kat" + "    " + "Görevli: " + cumayer4.Text + " Alanı: 2.Kat" + "    " + "Görevli: " + cumayer5.Text + " Alanı: 3.Kat" + "\n";

            }
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = "Tüm Dosyalar|*";
            svf.Title = "Dosya Kaydet";
            if (svf.ShowDialog() == DialogResult.OK)
            {

                System.IO.StreamWriter sw = new System.IO.StreamWriter(svf.FileName);
                sw.Write(richTextBox1.Text);

                sw.Close();
            }
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            qrcodeotonobet qrcod = new qrcodeotonobet();
            qrcod.Show();
        }



    }
}
