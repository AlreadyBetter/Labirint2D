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
        public Form_level1()
        {
            InitializeComponent();
        }

        private void start_game()
        {
            Point point = label_start.Location;
            point.Offset(label_start.Width/2, label_start.Height/2);
            Cursor.Position = PointToScreen(point);
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
            Sound.play_won();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Form_level1_Shown(object sender, EventArgs e)
        {
            start_game();
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            restart_game();
        }
    }
}
