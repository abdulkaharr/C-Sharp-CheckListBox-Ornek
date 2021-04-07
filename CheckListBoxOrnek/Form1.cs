using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBoxOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int secilenicerik = e.Index; //seçilen indexi secileniceriğe atık
            string isaretlenenmetin = checkedListBox1.Items[secilenicerik].ToString();// Burada seçilen indexin karşılığı olan kelimeyi isaretlenenmetine atıyoruz 

            if (listBox1.Items.IndexOf(isaretlenenmetin) > -1)//kullanan kişi check box yerine beşka bir yere bastığı zaman 0 dan küçük olacağı için buraya düşüyor
            {
                MessageBox.Show("bastığınız yerde hiç bir seçenek bulunmamaktadır!");
                return;
            }

           if ( checkedListBox1.GetItemChecked(secilenicerik) == false) //GetItemChecked getir alamında kullanılıyor false eşitlememizin sebebi GetItemChecked kendine has özeliğidir
            {
                listBox1.Items.Add(isaretlenenmetin);
            }


        }
    }
}
