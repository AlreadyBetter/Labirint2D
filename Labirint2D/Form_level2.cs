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
    public partial class Form_level2 : Form
    {
        public Form_level2()
        {
            InitializeComponent();
        }

        private void start_game()
        {
            Point point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);
            label_key.Visible = true;
            label_door.Visible = true;
            label_flash1.Visible = true;
            label_flash2.Visible = false;
        }

        private void restart_game()
        {

            DialogResult dr = MessageBox.Show(
                "Стенки лабиринта ядовитые, не касайтесь их.\nПопробуете еще раз?",
                "Вы проиграли", MessageBoxButtons.YesNo);
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

        private void Form_level2_Shown(object sender, EventArgs e)
        {
            
            DialogResult dr = MessageBox.Show(
                "Что бы пройти уровень необходимо подобрать ключ, который откроет дверь к финишу.\nВ этом уровне дверь как и стены так же ядовиты, к тому же некоторые стены могут исчезать и появлятся снова.\n\nЧто бы продолжить нажмите Enter...",
                "Уровень 2", MessageBoxButtons.OK);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                start_game();
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            restart_game();
        }

        private void label_key_MouseEnter(object sender, EventArgs e)
        {
            label_key.Visible = false;
            Sound.play_keyFound();
            label_door.Visible = false;
            
        }

        private void label_finish_Click(object sender, EventArgs e)
        {

        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_flash1.Visible = !label_flash1.Visible;
            label_flash2.Visible = !label_flash2.Visible;
        }
    }
}
