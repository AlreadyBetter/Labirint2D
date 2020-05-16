namespace Labirint2D
{
    partial class Form_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_menu));
            this.label_start = new System.Windows.Forms.Label();
            this.label_abort = new System.Windows.Forms.Label();
            this.ch_sound = new System.Windows.Forms.CheckBox();
            this.label_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_start
            // 
            this.label_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_start.AutoSize = true;
            this.label_start.BackColor = System.Drawing.Color.Transparent;
            this.label_start.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_start.ForeColor = System.Drawing.Color.White;
            this.label_start.Location = new System.Drawing.Point(61, 265);
            this.label_start.Margin = new System.Windows.Forms.Padding(0);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(264, 62);
            this.label_start.TabIndex = 0;
            this.label_start.Text = "Начать игру";
            this.label_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_start.Click += new System.EventHandler(this.label_start_Click);
            // 
            // label_abort
            // 
            this.label_abort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_abort.AutoSize = true;
            this.label_abort.BackColor = System.Drawing.Color.Transparent;
            this.label_abort.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_abort.ForeColor = System.Drawing.Color.White;
            this.label_abort.Location = new System.Drawing.Point(61, 425);
            this.label_abort.Margin = new System.Windows.Forms.Padding(0);
            this.label_abort.Name = "label_abort";
            this.label_abort.Size = new System.Drawing.Size(309, 62);
            this.label_abort.TabIndex = 1;
            this.label_abort.Text = "Выйти из игры";
            this.label_abort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_abort.Click += new System.EventHandler(this.label1_Click);
            // 
            // ch_sound
            // 
            this.ch_sound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ch_sound.AutoSize = true;
            this.ch_sound.BackColor = System.Drawing.Color.Transparent;
            this.ch_sound.Checked = true;
            this.ch_sound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_sound.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ch_sound.ForeColor = System.Drawing.Color.White;
            this.ch_sound.Location = new System.Drawing.Point(72, 347);
            this.ch_sound.Name = "ch_sound";
            this.ch_sound.Size = new System.Drawing.Size(292, 66);
            this.ch_sound.TabIndex = 2;
            this.ch_sound.Text = "Звук включен";
            this.ch_sound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ch_sound.UseVisualStyleBackColor = false;
            this.ch_sound.CheckedChanged += new System.EventHandler(this.ch_sound_CheckedChanged);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(53, 48);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(516, 112);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "Лабиринт 2D";
            // 
            // Form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Labirint2D.Properties.Resources.walleper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 660);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.ch_sound);
            this.Controls.Add(this.label_abort);
            this.Controls.Add(this.label_start);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labirynt 2D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label_abort;
        private System.Windows.Forms.CheckBox ch_sound;
        private System.Windows.Forms.Label label_name;
    }
}

