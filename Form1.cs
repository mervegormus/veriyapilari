using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("KURALLAR S İLE BAŞLAMAK ZORUNDA","LÜTFEN ONAYLAYIN");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String kural1,kural2,kural3,kural4,kural5,state1,state2,state3,state4,state5;
            state1 = textBox7.Text;
            state2 = textBox8.Text;
            state3 = textBox9.Text;
            state4 = textBox10.Text;
            state5 = textBox11.Text;
            kural1 = textBox2.Text;
            kural2 = textBox3.Text;
            kural3 = textBox4.Text;
            kural4 = textBox5.Text;
            kural5 = textBox6.Text;
            Random rastgele = new Random();
            String[] diziKural = { kural1, kural2, kural3, kural4, kural5 };
            String[] diziState = { state1, state2, state3, state4, state5 };
            ArrayList liste = new ArrayList();
            Regex r = new Regex("[ABCDEFGHS]");
            for(int i = 0; i < diziKural.Length; i++)
            {
                diziKural[i] = r.Replace(diziKural[i], "");
            }
            Regex rx = new Regex("[|$]");
            for(int j = 0; j < diziKural.Length; j++)
            {
                diziKural[j] = rx.Replace(diziKural[j], "");
            }
           
            kural1 = diziKural[0];
            kural2 = diziKural[1];
            kural3 = diziKural[2];
            kural4 = diziKural[3];
            kural5 = diziKural[4];

            char[] charArray1 = kural1.ToCharArray();
            char[] charArray2 = kural2.ToCharArray();
            char[] charArray3 = kural3.ToCharArray();
            char[] charArray4 = kural4.ToCharArray();
            char[] charArray5 = kural5.ToCharArray();
            liste.AddRange(charArray1);
            liste.AddRange(charArray2);
            liste.AddRange(charArray3);
            liste.AddRange(charArray4);
            liste.AddRange(charArray5);

            object [] sonuc = liste.ToArray();
          
            for (int a = 0; a < 50; a++)
            {
                String random = "";
                int harfNum = rastgele.Next(0, sonuc.Length - 1);
                random += sonuc[harfNum];

               textBox12.Text = textBox12.Text + random;
                listBox.Items.Add(textBox12.Text);
           
            }
            textBox12.Clear();
        }
   
      

        private void button2_Click(object sender, EventArgs e)
        {
            char[] harf = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'S' };
            for (int i = 0; i < harf.Length; i++)
            {
                textBox1.Text = textBox1.Text + harf[i] + ",";
                
            }
            

        }
    }
}
