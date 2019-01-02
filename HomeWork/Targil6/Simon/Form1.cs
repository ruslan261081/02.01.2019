﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon
{
    public partial class Form1 : Form
    {

        int stepsInRound = 1;
        int currentStep = 0;
        const int MAX = 4;
        Color pressColor = Color.Black;
        int sleep = 750;
        int[] colors = new int[MAX];

        Random r = new Random();

        Color redPanel;
        Color yellowPanel;
        Color bluePanel;
        Color greenPanel;

        int score;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            redPanel = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            yellowPanel = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            bluePanel = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            greenPanel = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));

            redPanel0.BackColor = redPanel;
            yellowPanel1.BackColor = yellowPanel;
            bluePanel2.BackColor = bluePanel;
            greenPanel3.BackColor = greenPanel;
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {

            score = 0;

            

            stepsInRound = 1;
            currentStep = 0;

            for (int i = 0; i < MAX; i++)
            {
                colors[i] = r.Next(4);
            }

            new Thread(() =>
           {

               switch (colors[0])
               {
                   case 0:
                       redPanel0.BackColor = pressColor;
                       break;
                   case 1:
                       yellowPanel1.BackColor = pressColor;
                       break;
                   case 2:
                       bluePanel2.BackColor = pressColor;
                       break;
                   case 3:
                       greenPanel3.BackColor = pressColor;
                       break;
               }

               Thread.Sleep(sleep);

               //redPanel0.BackColor = Color.Red;
               //yellowPanel1.BackColor = Color.Yellow;
               //bluePanel2.BackColor = Color.Blue;
               //greenPanel3.BackColor = Color.Lime;

               redPanel0.BackColor = redPanel;
               yellowPanel1.BackColor = yellowPanel;
               bluePanel2.BackColor = bluePanel;
               greenPanel3.BackColor = greenPanel;

           }).Start();
           
        }


        private static void foo(int i = 5)
        {

        }
        private void AfterClickColor()
        {
            currentStep++;
            if (currentStep == stepsInRound)
            {
                if (stepsInRound == MAX)
                {
                    MessageBox.Show("GREAT", "YOU WON!!!!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    stepsInRound++;
                    currentStep = 0;

                    for (int i = 0; i < stepsInRound; i++)
                    {
                        switch (colors[i])
                        {
                            case 0:
                                redPanel0.BackColor = pressColor;
                                break;
                            case 1:
                                yellowPanel1.BackColor = pressColor;
                                break;
                            case 2:
                                bluePanel2.BackColor = pressColor;
                                break;
                            case 3:
                                greenPanel3.BackColor = pressColor;
                                break;
                        }

                        Thread.Sleep(sleep);

                        //redPanel0.BackColor = Color.Red;
                        //yellowPanel1.BackColor = Color.Yellow;
                        //bluePanel2.BackColor = Color.Blue;
                        //greenPanel3.BackColor = Color.Lime;

                        redPanel0.BackColor = redPanel;
                        yellowPanel1.BackColor = yellowPanel;
                        bluePanel2.BackColor = bluePanel;
                        greenPanel3.BackColor = greenPanel;

                        Thread.Sleep(100);
                    }

                }

            }
         }

        private void redPanel0_Click(object sender, EventArgs e)
        {
            if (colors[currentStep] == 0)
            {
                score++;
                scoreLbl.Text = score.ToString();
            }

            new Thread(() =>
            {
                redPanel0.BackColor = pressColor;
                Thread.Sleep(sleep);
                //redPanel0.BackColor = Color.Red;
                redPanel0.BackColor = redPanel;
                
                if (colors[currentStep] != 0)
                {
                    MessageBox.Show("WRONG", "WRONG!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AfterClickColor();
                }
            }).Start();
                
        }

        private void yellowPanel1_Click(object sender, EventArgs e)
        {
            if (colors[currentStep] == 1)
            {
                score++;
                scoreLbl.Text = score.ToString();
            }

            new Thread(() =>
            {
                yellowPanel1.BackColor = pressColor;
                Thread.Sleep(sleep);
                //yellowPanel1.BackColor = Color.Yellow;
                yellowPanel1.BackColor = yellowPanel;


                if (colors[currentStep] != 1)
                {
                    MessageBox.Show("WRONG", "WRONG!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AfterClickColor();
                }
            }).Start();
        }

        private void bluePanel2_Click(object sender, EventArgs e)
        {
            if (colors[currentStep] == 2)
            {
                score++;
                scoreLbl.Text = score.ToString();
            }

            new Thread(() =>
            {
                bluePanel2.BackColor = pressColor;
                Thread.Sleep(sleep);
                //bluePanel2.BackColor = Color.Blue;
                bluePanel2.BackColor = bluePanel;

                if (colors[currentStep] != 2)
                {
                    MessageBox.Show("WRONG", "WRONG!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AfterClickColor();
                }
            }).Start();
        }

        private void greenPanel3_Click(object sender, EventArgs e)
        {
            if (colors[currentStep] == 3)
            {
                score++;
                scoreLbl.Text = score.ToString();
            }

            new Thread(() =>
            {
                greenPanel3.BackColor = pressColor;
                Thread.Sleep(sleep);
                //greenPanel3.BackColor = Color.Lime;
                greenPanel3.BackColor = greenPanel;
                if (colors[currentStep] != 3)
                {
                    MessageBox.Show("WRONG", "WRONG!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AfterClickColor();
                }
            }).Start();
        }
    }
}
