namespace ngvs
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hay = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gravedad = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.shu = new System.Windows.Forms.PictureBox();
            this.weapon = new System.Windows.Forms.Timer(this.components);
            this.menu = new System.Windows.Forms.Timer(this.components);
            this.main = new System.Windows.Forms.PictureBox();
            this.introhay = new System.Windows.Forms.PictureBox();
            this.hayintro = new System.Windows.Forms.Timer(this.components);
            this.flame1 = new System.Windows.Forms.PictureBox();
            this.flameattack = new System.Windows.Forms.Timer(this.components);
            this.ending = new System.Windows.Forms.PictureBox();
            this.end = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.exxit = new System.Windows.Forms.Timer(this.components);
            this.exi = new System.Windows.Forms.PictureBox();
            this.greetings = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.eneidle = new System.Windows.Forms.Timer(this.components);
            this.enidle = new System.Windows.Forms.Timer(this.components);
            this.flame2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gameov = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.introhay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flame2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameov)).BeginInit();
            this.SuspendLayout();
            // 
            // hay
            // 
            this.hay.BackColor = System.Drawing.Color.Transparent;
            this.hay.Image = global::ngvs.Properties.Resources.hayidle1;
            this.hay.Location = new System.Drawing.Point(75, 300);
            this.hay.Name = "hay";
            this.hay.Size = new System.Drawing.Size(61, 103);
            this.hay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hay.TabIndex = 0;
            this.hay.TabStop = false;
            // 
            // enemy
            // 
            this.enemy.BackColor = System.Drawing.Color.Transparent;
            this.enemy.Image = global::ngvs.Properties.Resources.ninjidle1;
            this.enemy.Location = new System.Drawing.Point(525, 300);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(61, 103);
            this.enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy.TabIndex = 1;
            this.enemy.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gravedad
            // 
            this.gravedad.Interval = 60;
            this.gravedad.Tick += new System.EventHandler(this.gravedad_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "NINJA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(477, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "ENEMY";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Location = new System.Drawing.Point(116, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 18);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel2.Location = new System.Drawing.Point(132, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 18);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel3.Location = new System.Drawing.Point(148, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 18);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel4.Location = new System.Drawing.Point(164, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 18);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel5.Location = new System.Drawing.Point(481, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 18);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel6.Location = new System.Drawing.Point(497, 31);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 18);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel7.Location = new System.Drawing.Point(513, 31);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 18);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel8.Location = new System.Drawing.Point(529, 31);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 18);
            this.panel8.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(296, -6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 55);
            this.label3.TabIndex = 6;
            this.label3.Text = "∞";
            // 
            // shu
            // 
            this.shu.BackColor = System.Drawing.Color.Transparent;
            this.shu.Image = global::ngvs.Properties.Resources.shuriken1;
            this.shu.Location = new System.Drawing.Point(549, 341);
            this.shu.Name = "shu";
            this.shu.Size = new System.Drawing.Size(26, 22);
            this.shu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shu.TabIndex = 7;
            this.shu.TabStop = false;
            this.shu.Visible = false;
            // 
            // weapon
            // 
            this.weapon.Interval = 1;
            this.weapon.Tick += new System.EventHandler(this.weapon_Tick);
            // 
            // menu
            // 
            this.menu.Tick += new System.EventHandler(this.menu_Tick);
            // 
            // main
            // 
            this.main.Image = global::ngvs.Properties.Resources.menuu;
            this.main.Location = new System.Drawing.Point(-1, -6);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(655, 419);
            this.main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.main.TabIndex = 8;
            this.main.TabStop = false;
            // 
            // introhay
            // 
            this.introhay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.introhay.Image = global::ngvs.Properties.Resources.ryuhayabusa;
            this.introhay.Location = new System.Drawing.Point(-60, 151);
            this.introhay.Name = "introhay";
            this.introhay.Size = new System.Drawing.Size(255, 262);
            this.introhay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.introhay.TabIndex = 9;
            this.introhay.TabStop = false;
            // 
            // hayintro
            // 
            this.hayintro.Interval = 25;
            this.hayintro.Tick += new System.EventHandler(this.hayintro_Tick);
            // 
            // flame1
            // 
            this.flame1.BackColor = System.Drawing.Color.Transparent;
            this.flame1.Image = global::ngvs.Properties.Resources.flame;
            this.flame1.Location = new System.Drawing.Point(322, 249);
            this.flame1.Name = "flame1";
            this.flame1.Size = new System.Drawing.Size(20, 25);
            this.flame1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flame1.TabIndex = 10;
            this.flame1.TabStop = false;
            // 
            // flameattack
            // 
            this.flameattack.Interval = 50;
            this.flameattack.Tick += new System.EventHandler(this.flameattack_Tick);
            // 
            // ending
            // 
            this.ending.BackColor = System.Drawing.Color.Transparent;
            this.ending.Image = global::ngvs.Properties.Resources.cinematic_1;
            this.ending.Location = new System.Drawing.Point(-1, 3);
            this.ending.Name = "ending";
            this.ending.Size = new System.Drawing.Size(655, 410);
            this.ending.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ending.TabIndex = 11;
            this.ending.TabStop = false;
            this.ending.Visible = false;
            this.ending.Click += new System.EventHandler(this.ending_Click);
            // 
            // end
            // 
            this.end.Interval = 2;
            this.end.Tick += new System.EventHandler(this.end_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // exxit
            // 
            this.exxit.Tick += new System.EventHandler(this.exxit_Tick);
            // 
            // exi
            // 
            this.exi.Image = global::ngvs.Properties.Resources.exit1;
            this.exi.Location = new System.Drawing.Point(-1, -1);
            this.exi.Name = "exi";
            this.exi.Size = new System.Drawing.Size(655, 414);
            this.exi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exi.TabIndex = 13;
            this.exi.TabStop = false;
            this.exi.Visible = false;
            // 
            // greetings
            // 
            this.greetings.Tick += new System.EventHandler(this.greetings_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // enidle
            // 
            this.enidle.Interval = 500;
            this.enidle.Tick += new System.EventHandler(this.enidle_Tick);
            // 
            // flame2
            // 
            this.flame2.BackColor = System.Drawing.Color.Transparent;
            this.flame2.Image = global::ngvs.Properties.Resources.flame;
            this.flame2.Location = new System.Drawing.Point(373, 249);
            this.flame2.Name = "flame2";
            this.flame2.Size = new System.Drawing.Size(20, 25);
            this.flame2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flame2.TabIndex = 15;
            this.flame2.TabStop = false;
            this.flame2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // gameov
            // 
            this.gameov.Image = global::ngvs.Properties.Resources.Gameover;
            this.gameov.Location = new System.Drawing.Point(-1, -1);
            this.gameov.Name = "gameov";
            this.gameov.Size = new System.Drawing.Size(655, 414);
            this.gameov.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameov.TabIndex = 17;
            this.gameov.TabStop = false;
            this.gameov.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(179, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(298, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "BABY MODE_ ACTIVATED";
            this.label7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ngvs.Properties.Resources.Screenshot__421_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 413);
            this.Controls.Add(this.gameov);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ending);
            this.Controls.Add(this.introhay);
            this.Controls.Add(this.main);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.shu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hay);
            this.Controls.Add(this.flame1);
            this.Controls.Add(this.flame2);
            this.Controls.Add(this.label7);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ninja Gaiden: Zero";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.hay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.introhay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flame2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hay;
        private System.Windows.Forms.PictureBox enemy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer gravedad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox shu;
        private System.Windows.Forms.Timer weapon;
        private System.Windows.Forms.Timer menu;
        private System.Windows.Forms.PictureBox main;
        private System.Windows.Forms.PictureBox introhay;
        private System.Windows.Forms.Timer hayintro;
        private System.Windows.Forms.PictureBox flame1;
        private System.Windows.Forms.Timer flameattack;
        private System.Windows.Forms.PictureBox ending;
        private System.Windows.Forms.Timer end;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer exxit;
        private System.Windows.Forms.PictureBox exi;
        private System.Windows.Forms.Timer greetings;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer eneidle;
        private System.Windows.Forms.Timer enidle;
        private System.Windows.Forms.PictureBox flame2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox gameov;
        private System.Windows.Forms.Label label7;
    }
}

