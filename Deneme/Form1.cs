using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class Form1 : Form
    {
        Player Gameturn;
        List<Button> buttons;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();         
            Buttondefine();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public enum Player
        {
            X, O
        }

        void Buttondefine()
        {
            buttons = new List<Button> { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
        }
 
        private void HumanPlayer(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Gameturn = Player.X;
            button.Text = Gameturn.ToString();
            button.Enabled = false;
            buttons.Remove(button);
            GameControl();
            AIaction.Start();
        }

        private void AI(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = rnd.Next(buttons.Count);
                buttons[index].Enabled = false;
                Gameturn = Player.O;
                buttons[index].Text = Gameturn.ToString();
                buttons.RemoveAt(index);
                GameControl();
                AIaction.Stop();
            }
        }

        void GameControl()
        {

            if (b1.Text == "X" && b2.Text == "X" && b3.Text == "X"
               || b4.Text == "X" && b5.Text == "X" && b6.Text == "X"
               || b7.Text == "X" && b9.Text == "X" && b8.Text == "X"
               || b1.Text == "X" && b4.Text == "X" && b7.Text == "X"
               || b2.Text == "X" && b5.Text == "X" && b8.Text == "X"
               || b3.Text == "X" && b6.Text == "X" && b9.Text == "X"
               || b1.Text == "X" && b5.Text == "X" && b9.Text == "X"
               || b3.Text == "X" && b5.Text == "X" && b7.Text == "X")
            {
                AIaction.Stop();
                MessageBox.Show("KAZANDINIZ.");
            }

            else if (b1.Text == "O" && b2.Text == "O" && b3.Text == "O"
            || b4.Text == "O" && b5.Text == "O" && b6.Text == "O"
            || b7.Text == "O" && b9.Text == "O" && b8.Text == "O"
            || b1.Text == "O" && b4.Text == "O" && b7.Text == "O"
            || b2.Text == "O" && b5.Text == "O" && b8.Text == "O"
            || b3.Text == "O" && b6.Text == "O" && b9.Text == "O"
            || b1.Text == "O" && b5.Text == "O" && b9.Text == "O"
            || b3.Text == "O" && b5.Text == "O" && b7.Text == "O")
            {
                AIaction.Stop();
                MessageBox.Show("KAYBETTİNİZ."); 
            }
        }
    }
}
