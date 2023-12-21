using StokTakip2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StokTakip2.Views
{
    /// <summary>
    /// Interaction logic for KategoriKaydıWindow.xaml
    /// </summary>
    public partial class KategoriKaydıWindow : Window
    {
        public KategoriKaydıWindow()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            var kategoriler = Db.Context.Kategoriler.ToList();
            DgKategoriler.ItemsSource = kategoriler;
        }

        private void BtnEkle_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbKategoriAdı.Text)) //Eğer kullanıcı kategori adını yazmamışsa ya da sadece boşluk yazmışsa
            {
                MessageBox.Show("Lütfen kategori adını girin.", "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Kategori kategori = new Kategori()
            {
                KategoriAdı = TbKategoriAdı.Text
            };

            try
            {
                Db.Context.Kategoriler.Add(kategori);
                Db.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                Db.Context.Kategoriler.Remove(kategori);
                MessageBox.Show("Kayıt yapılırken bir hata oluştu.", "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            TbKategoriAdı.Clear();
            Listele();
            TbKategoriAdı.Focus();
        }

        private void BtnSil_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnGüncelle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnYeniKayıt_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
