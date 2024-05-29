using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PR6.Bar;

namespace PR6
{
    public partial class Form1 : Form
    {
        Client client = new Client();
        Bar bar;
        
        public Form1()
        {
            InitializeComponent();
            bar = Bar.getInstance();
            bar.Init();
            UpdateMoney();
        }

        private void pB_drink1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            $"Вы хотите купить виски?\nЦена: {bar.dict[drinkTypes.Whiskey].Price} рублей\nПрирост настроения: {bar.dict[drinkTypes.Whiskey].Intertainment}",
            "Бармен",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                if (client.HasEnoughMoney(bar.dict[drinkTypes.Whiskey].Price))
                {
                    if (client.CanDrinkMore(bar.dict[drinkTypes.Whiskey].Intertainment))
                    {
                        client.Drink(bar.dict[drinkTypes.Whiskey].Intertainment);
                        progressBar1.Value = progressBar1.Value + bar.dict[drinkTypes.Whiskey].Intertainment;
                        client.SpendMoney(bar.dict[drinkTypes.Whiskey].Price);
                        UpdateMoney();
                        bar.AfterDrink();
                    }
                    else
                    {
                        MessageBox.Show("Вы напились, дорогой кутила! Прошу вас покинуть заведение.", "Бармен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("У вас недостаточно денег, дорогой кутила! Прошу приобрести напиток дешевле или покинуть заведение.", "Бармен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void pB_drink2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            $"Вы хотите купить вино?\nЦена: {bar.dict[drinkTypes.RedWine].Price} рублей\nПрирост настроения: {bar.dict[drinkTypes.RedWine].Intertainment}",
            "Бармен",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                if (client.HasEnoughMoney(bar.dict[drinkTypes.RedWine].Price))
                {
                    if (client.CanDrinkMore(bar.dict[drinkTypes.RedWine].Intertainment))
                    {
                        client.Drink(bar.dict[drinkTypes.RedWine].Intertainment);
                        progressBar1.Value = progressBar1.Value + bar.dict[drinkTypes.RedWine].Intertainment;
                        client.SpendMoney(bar.dict[drinkTypes.RedWine].Price);
                        UpdateMoney();
                        bar.AfterDrink();
                    }
                    else
                    {
                        MessageBox.Show("Вы напились, дорогой кутила! Прошу вас покинуть заведение.", "Бармен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("У вас недостаточно денег, дорогой кутила! Прошу приобрести напиток дешевле или покинуть заведение.", "Бармен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void pB_drink3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            $"Вы хотите купить шампанское?\nЦена: {bar.dict[drinkTypes.WhiteWine].Price} рублей\nПрирост настроения: {bar.dict[drinkTypes.WhiteWine].Intertainment}",
            "Бармен",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                if (client.HasEnoughMoney(bar.dict[drinkTypes.WhiteWine].Price))
                {
                    if (client.CanDrinkMore(bar.dict[drinkTypes.WhiteWine].Intertainment))
                    {
                        client.Drink(bar.dict[drinkTypes.WhiteWine].Intertainment);
                        progressBar1.Value = progressBar1.Value + bar.dict[drinkTypes.WhiteWine].Intertainment;
                        client.SpendMoney(bar.dict[drinkTypes.WhiteWine].Price);
                        UpdateMoney();
                        bar.AfterDrink();                    }
                    else
                    {
                        MessageBox.Show("Вы напились, дорогой кутила! Прошу вас покинуть заведение.", "Бармен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("У вас недостаточно денег, дорогой кутила! Прошу приобрести напиток дешевле или покинуть заведение.", "Бармен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void UpdateMoney()
        {
            label1.Text =  $"{client.Money} рублей";
        }
    }
}
