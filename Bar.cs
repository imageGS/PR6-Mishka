using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR6
{
    internal class Bar
    {
        public static Bar instance;
        public static Bar getInstance()
        {
            if (instance == null)
                instance = new Bar();
            return instance; 
        }
        public enum drinkTypes
        {
            Whiskey,
            RedWine,
            WhiteWine
        }
        public void AfterDrink()
        {
            Random random = new Random();
            int randomEvent = random.Next(0,3);
            switch (randomEvent) 
            {
                case 0:
                    MessageBox.Show("Вы выпиваете увеселительный напиток в спокойствии и преисполняетесь кайфом.", "Событие", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    MessageBox.Show("Выпивая увеселительный напиток, вы не расчитываете глоток и слегка давитесь.", "Событие", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("Вы бросаете мимолётный взгляд на соседние столики. Замечаете интересные личности.","Событие", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    DialogResult result = MessageBox.Show("Допивая порцию купленного вами увеселительного напитка, вы ощущаете лёгкое головокружение. Ваше тело вас не слушается, глаза медленно закрываются. Вы чувствуете, как падаете со стула.","Событие", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK) { Application.Exit(); }
                    break;
            }
            
        }
        public void Init()
        {
            FillDictionary();
        }
        void FillDictionary()
        {
            dict.Add(drinkTypes.Whiskey, new Whiskey());
            dict.Add(drinkTypes.RedWine, new RedWine());
            dict.Add(drinkTypes.WhiteWine, new WhiteWine());
        }
        public Dictionary<drinkTypes, Drink> dict { get; private set; } = new Dictionary<drinkTypes, Drink>();
    }
}
