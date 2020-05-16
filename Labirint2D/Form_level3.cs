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
    public partial class Form_level3 : Form
    {
        public Form_level3()
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
            portal_in.Visible = false;
            label_flash1.Visible = true;
            label_flash2.Visible = false;
            label_flash3.Visible = true;
            label_flash4.Visible = false;
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

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_key_MouseEnter(object sender, EventArgs e)
        {
            label_key.Visible = false;
            Sound.play_keyFound();
            label_door.Visible = false;
            portal_in.Visible = true;
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label_flash3.Visible = !label_flash3.Visible;
            label_flash4.Visible = !label_flash4.Visible;
        }

        private void portal_in_MouseEnter(object sender, EventArgs e)
        {
            Point point = portal_out.Location;
            point.Offset(portal_out.Width / 2, portal_out.Height / 2);
            Cursor.Position = PointToScreen(point);
        }

        private void Form_level3_Shown(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Что бы пройти уровень необходимо подобрать ключ, который откроет дверь к порталу входа, что переместит вас к порталу выходу, а затем добратся до финиша.\nВ этом уровне дверь как и стены так же ядовиты, к тому же некоторые стены могут исчезать и появлятся снова.\n\nЧто бы продолжить нажмите Enter...",
                "Уровень 3", MessageBoxButtons.OK);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                start_game();
            }
        }

        private void label23_MouseEnter(object sender, EventArgs e)
        {
            restart_game();
        }

        private void label23_MouseEnter_1(object sender, EventArgs e)
        {
            restart_game();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label_flash1.Visible = !label_flash1.Visible;
            label_flash2.Visible = !label_flash2.Visible;
        }
    }
}
