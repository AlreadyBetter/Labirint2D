using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint2D
{
    public partial class Form_level1 : Form
    {
        int box_left;
        public Form_level1()
        {
            InitializeComponent();
        }

        private void start_game()
        {
            Point point = label_start.Location;
            point.Offset(label_start.Width/2, label_start.Height/2);
            Cursor.Position = PointToScreen(point);

            box_left = 6;
            label_box1.Visible = true;
            label_box2.Visible = true;
            label_box3.Visible = true;
            label_box4.Visible = true;
            label_box5.Visible = true;
            label_box6.Visible = true;
        }

        private void restart_game()
        {
           
            DialogResult dr = MessageBox.Show(
                "Стенки лабиринта ядовитые, не касайтесь их.\nПопробуете еще раз?",
                "Вы проиграли",MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                start_game();
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.No;
            }
        }

        private void finish_game()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Form_level1_Shown(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Что бы пройти уровень необходимо собрать все желтые квадраты и добратся до финиша.\nБудьте осторожны, стенки лабиринта ядовиты!\n\nЧто бы продолжить нажмите Enter...",
                "Уровень 1", MessageBoxButtons.OK); 
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                start_game();
            }
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            if (box_left == 0)
                finish_game();
            else
                MessageBox.Show("Осталось: "+box_left+" шт.", "Соберите все квадраты");
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            restart_game();
        }

        private void label_box1_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).Visible = false;
            box_left--;
            if (box_left==0)
                Sound.play_keyFound();
        }
    }
}
