using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartGame();
        }
        public Hero myHero;
        private void StartGame()
        {
            MainScreen.Text += "The tower of horrors!!!"+Environment.NewLine;
            myHero = new Hero();
            if(string.IsNullOrEmpty(myHero.Name))
                MainScreen.Text += "What's your character's name" + Environment.NewLine;
            
        }

        public  void CreateCharacter(Hero hero)
        {
            

            hero.Strength = RollDice(20);
           MainScreen.Text+="Your character's strength is:" + hero.Strength+Environment.NewLine;

            hero.Charisma = RollDice(20);
            MainScreen.Text += "Your  character's charisma is:" + hero.Charisma+Environment.NewLine;

            hero.Intelligence = RollDice(20);
            MainScreen.Text += "Your  character's intelligence is:" + hero.Intelligence + Environment.NewLine;
            hero.Wisdom = RollDice(20);
            MainScreen.Text += "Your  character's wisdom is:" + hero.Wisdom+Environment.NewLine;


        }

       
        public static Random diceRoll = new Random();
        public static int RollDice(int number)
        {

            return diceRoll.Next(number);

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(myHero.Name) && !string.IsNullOrEmpty(UserInput.Text))
            {
                myHero.Name = UserInput.Text;
                CreateCharacter(myHero);
            }

        }
    }
}
