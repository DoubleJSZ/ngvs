using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;





namespace ngvs
{
    public partial class Form1 : Form
    {
        int conthayidle = 0, contjump = 0, contrun = 0, contattack = 0, contbend = 0, contshu = 0, contenemyidle = 0, contmenu = 0, contend = 0, contex = 0, contenemyrun = 0, contenemy = 0,contenemyattack=0,conthayataked=0,contflame=0;
        bool kd=false, kw = false;
        Image[] hayidle = new Image[2];
        Image[] hayjump = new Image[4];
        Image[] hayrun = new Image[3];
        Image[] hayattack = new Image[3];
        Image[] haybend = new Image[2];
        Image[] shur = new Image[2];
        Image[] enemyidle = new Image[2];
        Image[] enemyrun = new Image[3];
        Image[] introd = new Image[2];
        Image[] exit = new Image[2];
        Image[] enemyattack = new Image[2];
        Image[] hayattacked = new Image[1];


        SoundPlayer Player2 = new SoundPlayer();
        SoundPlayer Player = new SoundPlayer();
        SoundPlayer Player3 = new SoundPlayer();
        SoundPlayer gameo = new SoundPlayer();


        intro controls = new intro();



        public Form1()
        {

            InitializeComponent();

            Player.Stream = Properties.Resources.battle_ost;
            Player2.Stream = Properties.Resources.intro_ost;
            Player3.Stream = Properties.Resources.ending_ost;
            gameo.Stream = Properties.Resources.gameover_ost;

            Player2.Play();
            flame1.Visible = false;
            controls.Visible = true;

            flame2.Visible = false;
            flame1.Location = new Point(enemy.Location.X - 15, enemy.Location.Y + 80);
            flame2.Location = new Point(enemy.Location.X - 15, enemy.Location.Y - 40);

            shu.Location = hay.Location;
        }

        private void hayabushaidle()
        {
            hayidle[0] = ngvs.Properties.Resources.hayidle1;
            hayidle[1] = ngvs.Properties.Resources.hayidle2;


            hay.Image = hayidle[conthayidle];
            if (conthayidle == 1)
            {
                conthayidle = -1;
            }
            conthayidle++;

        }

        private void hayabushajump()
        {
            hayjump[0] = ngvs.Properties.Resources.hayjump1;
            hayjump[1] = ngvs.Properties.Resources.hayjump2;
            hayjump[2] = ngvs.Properties.Resources.hayjump3;
            hayjump[3] = ngvs.Properties.Resources.hayjump4;

            timer1.Stop();
            hay.Image = hayjump[contjump];
            if (contjump == 3)
            {
                contjump = -1;
            }
            contjump++;
            
            timer1.Start();
        }

        private void hayabusharun()
        {
            hayrun[0] = ngvs.Properties.Resources.hayrun1;
            hayrun[1] = ngvs.Properties.Resources.hayrun2;
            hayrun[2] = ngvs.Properties.Resources.hayrun3;

            hay.Image = hayrun[contrun];
            if (contrun == 2)
            {
                contrun = -1;
            }
            contrun++;


            if (hay.Location.Y != 300)
            {
                hayabushajump();

            }
            
                if (hay.Bounds.IntersectsWith(enemy.Bounds) && panel4.Visible == true)
                {
                    hayatacked();
                    timer1.Start();
                    panel4.Visible = false;

                }

               else if(hay.Bounds.IntersectsWith(enemy.Bounds) && panel3.Visible == true)
                {
                    hayatacked();
                    timer1.Start();
                    panel3.Visible = false;
                }
                if (shu.Visible == false)
                {
                    shu.Location = hay.Location;
                }
                  
                
        }

        private void hayabushaattack()
        {

            hayattack[0] = ngvs.Properties.Resources.hayattack3;
            hayattack[1] = ngvs.Properties.Resources.hayattack3;
            hayattack[2] = ngvs.Properties.Resources.hayattack3;

            hay.Image = hayattack[contattack];
            if (contattack == 2)
            {
                contattack = -1;
            }
            contattack++;


        }

        private void hayabushabend()
        {
            timer1.Stop();
            haybend[0] = ngvs.Properties.Resources.haybend1;


            hay.Image = haybend[contbend];
            if (contbend == 0)
            {
                contbend = -1;
            }
            contbend++;

            timer1.Start();

        }

        private void shuriken()
        {

            shur[0] = ngvs.Properties.Resources.shuriken1;
            shur[1] = ngvs.Properties.Resources.shuriken2;

            shu.Image = shur[contshu];
            if (contshu == 1)
            {
                contshu = -1;
            }
            contshu++;


            if (shu.Location.X == 800 || shu.Location == enemy.Location)
            {
                shu.Location = hay.Location;

            }



        }

        private void enemidle()
        {
            enemyidle[0] = ngvs.Properties.Resources.ninjidle1;
            enemyidle[1] = ngvs.Properties.Resources.ninjidle2;

            enemyidle[0].RotateFlip(RotateFlipType.Rotate180FlipY);
            enemyidle[1].RotateFlip(RotateFlipType.Rotate180FlipY);



            enemy.Image = enemyidle[contenemyidle];
            if (contenemyidle == 1)
            {
                contenemyidle = -1;
            }
            contenemyidle++;

        }

        private void enemirun()
        {

            enemyrun[0] = ngvs.Properties.Resources.ninjrun1;
            enemyrun[1] = ngvs.Properties.Resources.ninjrun2;
            enemyrun[2] = ngvs.Properties.Resources.ninjrun3;

            enemyrun[0].RotateFlip(RotateFlipType.Rotate180FlipY);
            enemyrun[1].RotateFlip(RotateFlipType.Rotate180FlipY);
            enemyrun[2].RotateFlip(RotateFlipType.Rotate180FlipY);




            enemy.Image = enemyrun[contenemyrun];
            if (contenemyrun == 2)
            {
                contenemyrun = -1;
            }
            contenemy++;
        }

        private void enemiattack(){
            enemyattack[0] = ngvs.Properties.Resources.ninjilunch1;
            enemyattack[1] = ngvs.Properties.Resources.ninjilunch2;
           
            enemy.Image = enemyattack[contenemyrun];
            if (contenemyattack == 1)
            {
                contenemyattack = -1;
            }
            
            
            contenemyattack++;

        }

        private void hayatacked()
        {
            timer1.Stop();
            hayattacked[0] = ngvs.Properties.Resources.hayattacked;
            hay.Location = new Point (hay.Location.X-100,hay.Location.Y-0);
            

        }





        private void timer1_Tick(object sender, EventArgs e)
        {
           
            hayabushaidle();
            shuriken();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            hayintro.Start();
            
        }

        private void gravedad_Tick(object sender, EventArgs e)
        {

            if (hay.Location.Y != 300)
            {
                hay.Location = new Point(hay.Location.X, hay.Location.Y + 12);
                hayabushajump();
            }
            else
            {
                hay.Location = new Point(hay.Location.X, hay.Location.Y);
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar("d"))
            {
                hayabusharun();
                hay.Location = new Point(hay.Location.X + 5, hay.Location.Y);
                if (hay.Location.X >= 580)
                {
                    hay.Location = new Point(hay.Location.X - 5, hay.Location.Y);
                }
            }
            if (e.KeyChar == Convert.ToChar("a"))
            {
                hayabusharun();
                hay.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                hay.Location = new Point(hay.Location.X - 5, hay.Location.Y);
                if (hay.Location.X <= 0)
                {
                    hay.Location = new Point(hay.Location.X + 5, hay.Location.Y);
                }
            }

            if (e.KeyChar == Convert.ToChar("2") )
            {
                hayabushajump();


                if (hay.Location.Y != 300)
                {
                    hay.Location = new Point(hay.Location.X, hay.Location.Y - 0);
                }
                else
                {
                    hay.Location = new Point(hay.Location.X, hay.Location.Y - 120);
                    if (kd == true)
                    {
                        hay.Location = new Point(hay.Location.X+20, hay.Location.Y-0);
                    }
                }
                if (flame1.Visible == true && hay.Bounds.IntersectsWith(flame1.Bounds))
                {
                    flame1.Visible = false;
                    

                }
            }

            if (e.KeyChar == Convert.ToChar("1"))
            {

                hayabushaattack();

                if (hay.Bounds.IntersectsWith(enemy.Bounds) && panel8.Visible == true)
                {
                    panel8.Visible = false;

                }
                else if (hay.Bounds.IntersectsWith(enemy.Bounds) && panel8.Visible == false)
                {
                    panel7.Visible = false;
                }
                if (hay.Bounds.IntersectsWith(enemy.Bounds) && panel7.Visible == false)
                {
                    panel6.Visible = false;
                }

                if (kw == true)
                {
                    
                    
                    weapon.Start();
                    kw = false;
                   

                }
                
                
                if (panel6.Visible == false)
                {
                    flameattack.Stop();
                    Player3.Play();
                    timer2.Stop();
                    enidle.Stop();
                    end.Start();
                    ending.Visible = true;

                }




            }
             
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                main.Visible = false;
                menu.Stop();
                introhay.Visible = false;
                timer1.Start();
                enidle.Start();
                gravedad.Start();
                Player2.Stop();
                Player.Play();
                if (exi.Visible == true)
                {
                    contend = 0;
                    //this.Close();
                    exi.Visible = false;
                    Application.Restart();

                }

                if (ending.Visible == true)
                {

                    exxit.Start();
                    exi.Visible = true;
                    ending.Visible = false;

                }
                if (gameov.Visible == true)
                {
                    Application.Restart();
                    
                }
            }
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {

                if (exi.Visible == true)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Select no sirve de nada aqui, asi que cierra esto y vuelve al juego");
                }
            }

            if (e.KeyChar == Convert.ToChar("s"))
            {
                hayabushabend();
            }

            if (e.KeyChar == Convert.ToChar("b"))
            {
                flameattack.Interval = 500;
                label7.Visible = true;

            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {

                kw = true;

            }
            if (e.KeyCode == Keys.D)
            {

                kd = true;

            }
           
           

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            

        }

        private void weapon_Tick(object sender, EventArgs e)
        {
            
            shuriken();
            shu.Location = new Point(shu.Location.X + 5, shu.Location.Y);
            shu.Visible = true;
            if (shu.Location.X == 800 || shu.Location == enemy.Location)
            {
                weapon.Stop();
                shu.Visible = false;
            }
            if (shu.Location == enemy.Location && panel8.Visible == true)
            {
                panel8.Visible = false;

            }
            else if (shu.Location == enemy.Location && panel8.Visible == false)
            {
                panel7.Visible = false;
            }
            if (panel7.Visible == false)
            {
                shu.Visible = false;
            }



        }

        private void menu_Tick(object sender, EventArgs e)
        {

            introd[0] = ngvs.Properties.Resources.menuu;
            introd[1] = ngvs.Properties.Resources.menuu2;


            main.Image = introd[contmenu];
            if (contmenu == 1)
            {
                contmenu = -1;
            }
            contmenu++;

        }

        private void hayintro_Tick(object sender, EventArgs e)
        {
            if (introhay.Location.X != -2)
            {
                introhay.Location = new Point(introhay.Location.X + 2, introhay.Location.Y + 0);
            }

            if (introhay.Location.X == -2)
            {

                menu.Start();

            }


        }

        private void flameattack_Tick(object sender, EventArgs e)
        {
            label6.Text = Convert.ToString(contflame);

            if (flame1.Location.X <=0 )
            {
                flame1.Visible = false;
                flame1.Location = new Point(enemy.Location.X - 15, enemy.Location.Y + 80);

            }else
            flame1.Visible = true;
            
            flame1.Location = new Point(flame1.Location.X - 20, flame1.Location.Y + 0);

            if (flame1.Bounds.IntersectsWith(hay.Bounds) && panel4.Visible == true && flame1.Visible == true)
            {
                panel4.Visible = false;
                flame1.Visible = false;
                flame1.Location = new Point(hay.Location.X-10,hay.Location.Y+80);
                

            }
            else
                if (flame1.Bounds.IntersectsWith(hay.Bounds) && panel3.Visible == true && flame1.Visible == true)
                {
                panel3.Visible = false;
                flame1.Visible = false;
                flame1.Location = new Point(hay.Location.X - 10, hay.Location.Y + 80);
                }
             else
                if (flame1.Bounds.IntersectsWith(hay.Bounds) && panel2.Visible == true && flame1.Visible == true)
                {
                    panel2.Visible = false;
                    flame1.Visible = false;
                    flame1.Location = new Point(hay.Location.X - 10, hay.Location.Y + 80);
                }
                else
                    if (flame1.Bounds.IntersectsWith(hay.Bounds) && panel1.Visible == true && flame1.Visible == true)
                    {
                        panel1.Visible = false;
                        flame1.Visible = false;
                        flame1.Location = new Point(hay.Location.X - 10, hay.Location.Y + 80);
                        gameo.Play();
                    }
            if (panel1.Visible == false)
            {
                
                gameov.Visible = true;
            }
          


            if(contflame>=40&&contflame<=100){

            if (flame2.Location.X <= 0)
            {
                flame2.Visible = false;
                flame2.Location = new Point(enemy.Location.X - 5, enemy.Location.Y-40);

            }
            else
                flame2.Visible = true;

            flame2.Location = new Point(flame2.Location.X - 10, flame2.Location.Y + 0);

            if (flame2.Bounds.IntersectsWith(hay.Bounds) && panel4.Visible == true && flame2.Visible == true)
            {
                panel4.Visible = false;
                flame2.Visible = false;
                flame2.Location = new Point(flame1.Location.X - 2000);


            }
            else
                if (flame2.Bounds.IntersectsWith(hay.Bounds) && panel3.Visible == true && flame2.Visible == true)
                {
                    panel3.Visible = false;
                    flame2.Visible = false;
                    flame2.Location = new Point(flame2.Location.X - 2000);
                }
                else
                    if (flame2.Bounds.IntersectsWith(hay.Bounds) && panel2.Visible == true && flame2.Visible == true)
                    {
                        panel2.Visible = false;
                        flame2.Visible = false;
                        flame2.Location = new Point(flame2.Location.X - 2000);
                    }
                    else
                        if (flame2.Bounds.IntersectsWith(hay.Bounds) && panel1.Visible == true && flame2.Visible == true)
                        {
                            panel1.Visible = false;
                            flame2.Visible = false;
                            flame2.Location = new Point(flame2.Location.X - 2000);
                            gameo.Play();
                        }
          
            
            }
            if (contflame == 100)
            {
                contflame = 40;
            }
            contflame++;

           
        }

        private void end_Tick(object sender, EventArgs e)
        {


            contend++;
            label4.Text = Convert.ToString(contend);

            if (contend == 1600)
            {

                ending.Visible = false;
                exi.Visible = true;

                exxit.Start();
            }

        }

        private void ending_Click(object sender, EventArgs e)
        {

        }

        private void exxit_Tick(object sender, EventArgs e)
        {


            Player.Stop();

            exit[0] = ngvs.Properties.Resources.exit1;
            exit[1] = ngvs.Properties.Resources.exit2;


            exi.Image = exit[contex];
            if (contex == 1)
            {

                contex = -1;
            }


            contex++;
        }

        private void greetings_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            enemiattack();
            flameattack.Start();
                
        }

        private void enidle_Tick(object sender, EventArgs e)
        {
            enemidle();
            if (contenemy == 4)
            {

                

                timer2.Start();
                contenemy = 0;
            }
            else
            {
                timer2.Stop();
            }
            label5.Text = Convert.ToString(contenemy);
            contenemy++;
           
        }

        }

    }
