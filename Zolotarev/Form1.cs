using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zolotarev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        String m;
        int[] nwe = new int [9];
        int[] n = new int [9];
        int p1, p2, p3, p4;
        int k1, k2, k3, k4;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelp3_Click(object sender, EventArgs e)
        {

        }

        int razryad;

        private void labelErrorPlace_Click(object sender, EventArgs e)
        {

        }

        private void labeerrorplacebin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = GetMACAddress();
        }

        public string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;

            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();

                }
            }
            return sMacAddress;
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        private void ButtonInsertn_Click(object sender, EventArgs e)
        {
            m = ReverseString(mTextBox.Text);
            labelforn3.Text = m[0].ToString();
            labelforn5.Text = m[1].ToString();
            labelforn6.Text = m[2].ToString();
            labelforn7.Text = m[3].ToString();
            labelforn9.Text = m[4].ToString();
            findK();
            labelk1.Text = k1.ToString();
            labelk2.Text = k2.ToString();
            labelk3.Text = k3.ToString();
            labelk4.Text = k4.ToString();

            n[0] = int.Parse(m[4].ToString());
            n[1] = k4;
            n[2] = int.Parse(m[3].ToString());
            n[3] = int.Parse(m[2].ToString());
            n[4] = int.Parse(m[1].ToString());
            n[5] = k3;
            n[6] = int.Parse(m[0].ToString());
            n[7] = k2;
            n[8] = k1;

            label9we.Text = m[4].ToString();
            label8we.Text = k4.ToString();
            label7we.Text = m[3].ToString();
            label6we.Text = m[2].ToString();
            label5we.Text = m[1].ToString();
            label4we.Text = k3.ToString();
            label3we.Text = m[0].ToString();
            label2we.Text = k2.ToString();
            label1we.Text = k1.ToString();

            razryad = int.Parse(textBoxmestoer.Text);
            setErrorCol(razryad);

            labelfornw9.Text = nwe[0] + "";
            labelfornw8.Text = nwe[1] + "";
            labelfornw7.Text = nwe[2] + "";
            labelfornw6.Text = nwe[3] + "";
            labelfornw5.Text = nwe[4] + "";
            labelfornw4.Text = nwe[5] + "";
            labelfornw3.Text = nwe[6] + "";
            labelfornw2.Text = nwe[7] + "";
            labelfornw1.Text = nwe[8] + "";

            for (int b = 0; b < 9; b++) Console.WriteLine(nwe[b]);
            
            labelErrorPlace.Text = razryad.ToString();
            errorSearch();
            labeerrorplacebin.Text = p4.ToString() + p3.ToString() + p2.ToString() + p1.ToString();
            labelforp1.Text = p1.ToString();
            labelforp2.Text = p2.ToString();
            labelforp3.Text = p3.ToString();
            labelforp4.Text = p4.ToString();
        }

        private void findK()
        {
            k1 = int.Parse(m[0].ToString()) ^ int.Parse(m[1].ToString()) ^ int.Parse(m[3].ToString()) ^ int.Parse(m[4].ToString());
            k2 = int.Parse(m[0].ToString()) ^ int.Parse(m[2].ToString()) ^ int.Parse(m[3].ToString());
            k3 = int.Parse(m[1].ToString()) ^ int.Parse(m[2].ToString()) ^ int.Parse(m[3].ToString());
            k4 = int.Parse(m[4].ToString());
            toDec(p1, p2, p3, p4);
        }
        private void errorSearch()
        {
            p1 = nwe[8] ^ nwe[6] ^ nwe[4] ^ nwe[2] ^ nwe[0];
            p2 = nwe[7] ^ nwe[6] ^ nwe[3] ^ nwe[2];
            p3 = nwe[5] ^ nwe[4] ^ nwe[3] ^ nwe[2];
            p4 = nwe[1] ^ nwe[0];
            toDec(p1, p2, p3, p4);
        }

        private void setErrorCol(int i)
        {
            for (int z = 0; z < 9; z++)
                nwe[z] = n[z];
            if (i == 1)
            {
                Error1.Text = "Ошибка";
                if (n[8] == 1) nwe[8] = 0;
                else nwe[8] = 1;
            }
            if (i == 2)
            {
                Error2.Text = "Ошибка";
                if (n[7] == 1) nwe[7] = 0;
                else nwe[7] = 1;
            }
            if (i == 3)
            {
                Error3.Text = "Ошибка";
                if (n[6] == 1) nwe[6] = 0;
                else nwe[6] = 1;
            }
            if (i == 4)
            {
                Error4.Text = "Ошибка";
                if (n[5] == 1) nwe[5] = 0;
                else nwe[5] = 1;
            }
            if (i == 5)
            {
                Error5.Text = "Ошибка";
                if (n[4] == 1) nwe[4] = 0;
                else nwe[4] = 1;
            }
            if (i == 6)
            {
                Error6.Text = "Ошибка";
                if (n[3] == 1) nwe[3] = 0;
                else nwe[3] = 1;
            }
            if (i == 7)
            {
                Error7.Text = "Ошибка";
                if (n[2] == 1) nwe[2] = 0;
                else nwe[2] = 1;
            }
            if (i == 8)
            {
                Error8.Text = "Ошибка";
                if (n[1] == 1) nwe[1] = 0;
                else nwe[1] = 1;
            }
            if (i == 9)
            {
                Error9.Text = "Ошибка";
                if (n[0] == 1) nwe[0] = 0;
                else nwe[0] = 1;
            }
        }

        private void toDec(int p1, int p2, int p3, int p4)
        {
            razryad = p1 * 1 + p2 * 2 + p3 * 4 + p4 * 8;
        }

    }
}
