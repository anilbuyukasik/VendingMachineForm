using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineForm
{
    public partial class MainForm : Form
    {
        //Verilen veri setlerini veri tabanında tutmayı tercih ettim. İlişkisel veritabanı mantığıyla Products ve Campaigns adlarında iki tablo oluşturdum.
        public MainForm()
        {
            InitializeComponent();
        }
        VendingMachineEntities db = new VendingMachineEntities();
        double money;
        double balance;
        double total;
        int campaignsCount;
        private void MainForm_Load(object sender, EventArgs e)
        {
            FillButtons();
            productPanel.Enabled=false;//Para girişi olmadan ürün seçimini engellemek için böyle bir önlem aldım.
            campaignsCount = db.Campaigns.GroupBy(c => c.CampaignId).ToList().Count;//Veritabanındaki kampanyaları id'ye göre gruplandırarak toplam kampanya sayısını aldım.
            
        }
        private void AddToCart(Products product, double newPrice)
        {
            int rowCount = cartGridView.Rows.Count -1;
            cartGridView.Rows.Add();
            cartGridView.Rows[rowCount].Cells["id"].Value = product.Id;
            cartGridView.Rows[rowCount].Cells["ProductName"].Value = product.ProductName;
            cartGridView.Rows[rowCount].Cells["Price"].Value = product.Price;
            cartGridView.Rows[rowCount].Cells["CampaignedPrice"].Value = newPrice;
        }
        private void Calculate()//Listedeki ürünlere göre toplam tutar ve bakiye hesaplayan metod.
        {
            total = 0;
            for (int i = 0; i < cartGridView.Rows.Count; i++)
            {
                total += Convert.ToDouble(cartGridView.Rows[i].Cells["CampaignedPrice"].Value);
            }
            balance = money - total;
            txtTotal.Text = "Toplam Tutar: " + Math.Round(total, 2) + " ₺";
            txtBalance.Text = "Bakiye: " + Math.Round(balance, 2) + " ₺";
        }
        private void CheckCampaign()//Listedeki ürünlere hangi kampanyaların uygulanabileceğini kontrol eden metod.
        {
            var campaigns = db.Campaigns.ToList();
            for (int i = 1; i <= campaignsCount; i++)
            {
                int counter = 0;
                foreach (var item in campaigns)
                {
                    if (i == item.CampaignId)//Burada, veritabanından gelen her kampanya id verisini kontrol edilecek kampanya id ile karşılaştırmaktadır.
                    {
                        for (int j = 0; j < cartGridView.Rows.Count; j++)
                        {
                            if (item.ProductId == Convert.ToInt16(cartGridView.Rows[j].Cells["id"].Value))//Kampanyadaki ürün id'leri, listedeki ürün id'leri ile karşılaştırıyor.
                            {
                                counter++;
                                if (counter == campaigns.Where(c=>c.CampaignId==item.CampaignId).Count())//Listeden kontrol edilen ürün sayısı ile kampanyadaki ürün sayısını karşılaştırıyor.
                                {
                                    if (item.Price < Convert.ToDouble(cartGridView.Rows[j].Cells["CampaignedPrice"].Value))//Ürün ve kampanya fiyatları karşılaştırılıyor.
                                    {
                                        var applyCampaign = db.Campaigns.Where(c => c.CampaignId == item.CampaignId).ToList();//Önceki şartlardan geçen kampanyaları bir değişkene aktarıyor.
                                        for (int k = 0; k < cartGridView.Rows.Count; k++)
                                        {
                                            foreach (var effected in applyCampaign)
                                            {
                                                if (Convert.ToInt16(cartGridView.Rows[k].Cells["id"].Value) ==effected.ProductId.Value)
                                                {
                                                    cartGridView.Rows[k].Cells["CampaignedPrice"].Value = effected.Price;//Burada listede kampanyaya uygun olan ürünlerin fiyatlarını güncelliyor.
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void ButtonsClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int buttonId = Convert.ToInt16(b.Name.ToString().Substring(3, b.Name.Length - 3));
            var product = db.Products.Where(p => p.Id == buttonId).FirstOrDefault();
            if (balance > 0 && balance >= product.Price)
            {
                AddToCart(product, Convert.ToDouble(product.Price));
                CheckCampaign();
                Calculate();
            }
            else
            {
                MessageBox.Show("Bakiye yetersiz!");
            }

            moneyPanel.Enabled = false;

        }
        private void InsertMoney(object sender, EventArgs e)
        {
            productPanel.Enabled = true;
            Button b = (Button)sender;
            money += Convert.ToDouble(b.Name.ToString().Substring(5, b.Name.Length - 5));
            txtBalance.Text = "Bakiye: " + money + " ₺";
            Calculate();
        }
        private void FillButtons()
        {
            var products = db.Products.ToList();
            foreach (var item in products)
            {
                Button btn = this.Controls.Find("btn" + item.Id, true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    btn.Text = item.ProductName + "\n" + item.Price + "₺";
                }
            }
        }

        private void moneyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Alışverişi tamamlamak istediğinize emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Alışveriş Tamamlandı!\n\nToplam Tutar: "+total.ToString()+" ₺\nPara Üstü: "+balance.ToString()+" ₺\n\nTeşekkürler!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cartGridView.Rows.Clear();
                productPanel.Enabled = false;
                moneyPanel.Enabled = true;
                txtBalance.Text = "Bakiye: 0 ₺";
                txtTotal.Text = "Toplam Tutar: 0 ₺";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Alışverişi iptal etmek istediğinize emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Para iade edilmiştir.\n\nTeşekkürler!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cartGridView.Rows.Clear();
                productPanel.Enabled = false;
                moneyPanel.Enabled = true;
                txtBalance.Text = "Bakiye: 0 ₺";
                txtTotal.Text = "Toplam Tutar: 0 ₺";
            }
        }
    }
}
