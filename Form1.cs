using System;
using System.Windows.Forms;

namespace zrayla_game_5
{
    
    //
    public partial class Form1 : Form
    {
        string careterName;

        int page = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        { //page 4

        }

        private void Sorcerer_Click(object sender, EventArgs e)
        { //page 10

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {

            if (page == 1)
            {
                page = 2;
            }


            switch (page)
            {
                case 1:
                    button15.Text = "start";
                    break;

                case 2:
                    button15.Visible = false;
                    Button16.Visible = true;
                    label1.Visible = true;
                    textBox1.Visible = true;
                    break;

            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {

            careterName = textBox1.Text;

            if (page == 2)
            {
                page = 3;
            }


            switch (page)
            {
                case 1:
                    button15.Text = "start";
                    break;

                case 2:
                    button15.Visible = false;
                    Button16.Visible = true;
                    label1.Visible = true;
                    textBox1.Visible = true;
                    Button16.Text = "enter";
                    break;

                case 3:
                    Dard.Visible = true;
                    Fighter.Visible = true;
                    Barbarian.Visible = true;
                    Wizard.Visible = true;
                    Druid.Visible = true;
                    Sorcerer.Visible = true;
                    Rogue.Visible = true;
                    Ranger.Visible = true;
                    cleric.Visible = true;
                    Warlock.Visible = true;
                    Monk.Visible = true;
                    pictureBox1.Visible = true;
                    label1.Visible = false;
                    textBox1.Visible = false;
                    Button16.Visible = false;
                    Paladin.Visible = true;
                    break;
            }
        }

        private void Paladin_Click(object sender, EventArgs e)
        { //page 7

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
        }

        private void Fighter_Click(object sender, EventArgs e)
        { //page 5

        }

        private void Barbarian_Click(object sender, EventArgs e)
        { //page 6

        }

        private void Wizard_Click(object sender, EventArgs e)
        { //page 8

        }

        private void Druid_Click(object sender, EventArgs e)
        { //page 9

        }

        private void Rogue_Click(object sender, EventArgs e)
        { //page 11

        }

        private void Ranger_Click(object sender, EventArgs e)
        { //page 12

        }

        private void cleric_Click(object sender, EventArgs e)
        { //page 13

        }

        private void Warlock_Click(object sender, EventArgs e)
        { //page 14

        }

        private void Monk_Click(object sender, EventArgs e)
        { //page 15

        }
    }
}
