﻿using System;
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
    public partial class Form_menu : Form
    {
        public Form_menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) // выход из игры
        {
            this.Close();
        }

        private void label_start_Click(object sender, EventArgs e)
        {
            Sound.play_start();
            start_level1();
        }

        private void start_level1()
        {
            Form_level1 level1 = new Form_level1();
            DialogResult dr = level1.ShowDialog();
            if (dr == DialogResult.Yes)
                start_level2();
        }

        private void start_level2()
        {
            Form_level2 level2 = new Form_level2();
            DialogResult dr = level2.ShowDialog();
            if (dr == DialogResult.Yes)
                start_level3();
        }

        private void start_level3()
        {
            Form_level1 level1 = new Form_level1();
            DialogResult dr = level1.ShowDialog();
        }

        private void ch_sound_CheckedChanged(object sender, EventArgs e)  // вкл/выкл звука
        {
            if (ch_sound.Checked)
            {
                ch_sound.Text = "Звук включен";
                Sound.sound_on();
                Sound.play_keyFound();
            }
            else
            {
                Sound.sound_off();
                ch_sound.Text = "Звук выключен";
            }
        }
    }
}
