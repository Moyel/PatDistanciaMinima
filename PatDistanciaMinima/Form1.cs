using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatDistanciaMinima
{
    public partial class Form1 : Form
    {
        /// This is the Centroid for the first Class
        int[,] centroidOne = new int[6, 6] {     { 0, 1, 1, 1, 0, 0, },
                                                 { 0, 1, 0, 0, 1, 0, },
                                                 { 0, 1, 0, 0, 1, 0, },
                                                 { 0, 1, 0, 1, 0, 0, },
                                                 { 0, 1, 0, 0, 1, 0, },
                                                 { 0, 1, 1, 1, 1, 0, }};

        /// This is the Centroid for the seconds Class
        int[,] centroidTwo = new int[6, 6]{      { 0, 0, 1, 0, 0, 0, },
                                                 { 0, 1, 0, 1, 0, 0, },
                                                 { 0, 0, 1, 1, 0, 0, },
                                                 { 0, 0, 0, 0, 0, 0, },
                                                 { 0, 1, 0, 1, 0, 0, },
                                                 { 0, 0, 1, 0, 0, 0, }};
        
        /// This is the Container for the Class to be evaluated
        int[,] claseTemp = new int[6, 6]{        { 0, 0, 0, 0, 0, 0, },
                                                 { 0, 0, 0, 0, 0, 0, },
                                                 { 0, 0, 0, 0, 0, 0, },
                                                 { 0, 0, 0, 0, 0, 0, },
                                                 { 0, 0, 0, 0, 0, 0, },
                                                 { 0, 0, 0, 0, 0, 0, }};
        int featureOneCentroidOne=10;
        int featureTwoCentroidOne=26;
        int featureOneCentroidTwo=13;
        int featureTwoCentroidTwo=23;
        int featureOneClassTemp = 0;
        int featureTwoClassTemp = 0;

        double abs1 = 0;
        double abs2 = 0;
        double distEucliOne = 0;
        double distEucliTwo = 0;

        double abs3 = 0;
        double abs4 = 0;
        double distManhaOne = 0;
        double distManhaTwo = 0;
        
        public Form1()
        {
            InitializeComponent();

         /// B Class Descriptors
            /// Number of colored cells
            for (int row = 0; row <= 5; row++)
            {
                for (int col = 0; col <= 5; col++)
                {
                    if (centroidOne[col, row] == 1)
                    {
                        featureOneCentroidOne++;
                    }
                }
            }

            /// Number of no colored cells
            for (int row = 0; row <= 5; row++)
            {
                for (int col = 0; col <= 5; col++)
                {
                    if (centroidOne[col, row] == 0)
                    {
                        featureTwoCentroidOne++;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == System.Drawing.Color.Black)
            {
                button1.BackColor = System.Drawing.Color.White;
                claseTemp[0, 0] = 0;
                
            }
            else
            {
                button1.BackColor = System.Drawing.Color.Black;
                claseTemp[0, 0] = 1;
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == System.Drawing.Color.Black)
            {
                button2.BackColor = System.Drawing.Color.White;
                claseTemp[0, 1] = 0;
            }
            else
            {
                button2.BackColor = System.Drawing.Color.Black;
                claseTemp[0, 1] = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == System.Drawing.Color.Black)
            {
                button4.BackColor = System.Drawing.Color.White;
                claseTemp[0, 2] = 0;
            }
            else
            {
                button4.BackColor = System.Drawing.Color.Black;
                claseTemp[0, 2] = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == System.Drawing.Color.Black)
            {
                button3.BackColor = System.Drawing.Color.White;
                claseTemp[0, 3] = 0;
            }
            else
            {
                button3.BackColor = System.Drawing.Color.Black;
                claseTemp[0, 3] = 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == System.Drawing.Color.Black)
            {
                button6.BackColor = System.Drawing.Color.White;
                claseTemp[0, 4] = 0;
            }
            else
            {
                button6.BackColor = System.Drawing.Color.Black;
                claseTemp[0, 4] = 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == System.Drawing.Color.Black)
            {
                button5.BackColor = System.Drawing.Color.White;
                claseTemp[0, 5] = 0;
            }
            else
            {
                button5.BackColor = System.Drawing.Color.Black;
                claseTemp[0, 5] = 1;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == System.Drawing.Color.Black)
            {
                button12.BackColor = System.Drawing.Color.White;
                claseTemp[1, 0] = 0;
            }
            else
            {
                button12.BackColor = System.Drawing.Color.Black;
                claseTemp[1, 0] = 1;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == System.Drawing.Color.Black)
            {
                button11.BackColor = System.Drawing.Color.White;
                claseTemp[1, 1] = 0;
            }
            else
            {
                button11.BackColor = System.Drawing.Color.Black;
                claseTemp[1, 1] = 1;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == System.Drawing.Color.Black)
            {
                button10.BackColor = System.Drawing.Color.White;
                claseTemp[1, 2] = 0;
            }
            else
            {
                button10.BackColor = System.Drawing.Color.Black;
                claseTemp[1, 2] = 1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == System.Drawing.Color.Black)
            {
                button9.BackColor = System.Drawing.Color.White;
                claseTemp[1, 3] = 0;
            }
            else
            {
                button9.BackColor = System.Drawing.Color.Black;
                claseTemp[1, 3] = 1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == System.Drawing.Color.Black)
            {
                button8.BackColor = System.Drawing.Color.White;
                claseTemp[1, 4] = 0;
            }
            else
            {
                button8.BackColor = System.Drawing.Color.Black;
                claseTemp[1, 4] = 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == System.Drawing.Color.Black)
            {
                button7.BackColor = System.Drawing.Color.White;
                claseTemp[1, 5] = 0;
            }
            else
            {
                button7.BackColor = System.Drawing.Color.Black;
                claseTemp[1, 5] = 1;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.BackColor == System.Drawing.Color.Black)
            {
                button18.BackColor = System.Drawing.Color.White;
                claseTemp[2, 0] = 0;
            }
            else
            {
                button18.BackColor = System.Drawing.Color.Black;
                claseTemp[2, 0] = 1;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.BackColor == System.Drawing.Color.Black)
            {
                button17.BackColor = System.Drawing.Color.White;
                claseTemp[2, 1] = 0;
            }
            else
            {
                button17.BackColor = System.Drawing.Color.Black;
                claseTemp[2, 1] = 1;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor == System.Drawing.Color.Black)
            {
                button16.BackColor = System.Drawing.Color.White;
                claseTemp[2, 2] = 0;
            }
            else
            {
                button16.BackColor = System.Drawing.Color.Black;
                claseTemp[2, 2] = 1;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == System.Drawing.Color.Black)
            {
                button15.BackColor = System.Drawing.Color.White;
                claseTemp[2, 3] = 0;
            }
            else
            {
                button15.BackColor = System.Drawing.Color.Black;
                claseTemp[2, 3] = 1;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == System.Drawing.Color.Black)
            {
                button14.BackColor = System.Drawing.Color.White;
                claseTemp[2, 4] = 0;
            }
            else
            {
                button14.BackColor = System.Drawing.Color.Black;
                claseTemp[2, 4] = 1;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == System.Drawing.Color.Black)
            {
                button13.BackColor = System.Drawing.Color.White;
                claseTemp[2, 5] = 0;
            }
            else
            {
                button13.BackColor = System.Drawing.Color.Black;
                claseTemp[2, 5] = 1;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button24.BackColor == System.Drawing.Color.Black)
            {
                button24.BackColor = System.Drawing.Color.White;
                claseTemp[3, 0] = 0;
            }
            else
            {
                button24.BackColor = System.Drawing.Color.Black;
                claseTemp[3, 0] = 1;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button23.BackColor == System.Drawing.Color.Black)
            {
                button23.BackColor = System.Drawing.Color.White;
                claseTemp[3, 1] = 0;
            }
            else
            {
                button23.BackColor = System.Drawing.Color.Black;
                claseTemp[3, 1] = 1;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.BackColor == System.Drawing.Color.Black)
            {
                button22.BackColor = System.Drawing.Color.White;
                claseTemp[3, 2] = 0;
            }
            else
            {
                button22.BackColor = System.Drawing.Color.Black;
                claseTemp[3, 2] = 1;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.BackColor == System.Drawing.Color.Black)
            {
                button21.BackColor = System.Drawing.Color.White;
                claseTemp[3, 3] = 0;
            }
            else
            {
                button21.BackColor = System.Drawing.Color.Black;
                claseTemp[3, 3] = 1;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.BackColor == System.Drawing.Color.Black)
            {
                button20.BackColor = System.Drawing.Color.White;
                claseTemp[3, 4] = 0;
            }
            else
            {
                button20.BackColor = System.Drawing.Color.Black;
                claseTemp[3, 4] = 1;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.BackColor == System.Drawing.Color.Black)
            {
                button19.BackColor = System.Drawing.Color.White;
                claseTemp[3, 5] = 0;
            }
            else
            {
                button19.BackColor = System.Drawing.Color.Black;
                claseTemp[3, 5] = 1;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (button30.BackColor == System.Drawing.Color.Black)
            {
                button30.BackColor = System.Drawing.Color.White;
                claseTemp[4, 0] = 0;
            }
            else
            {
                button30.BackColor = System.Drawing.Color.Black;
                claseTemp[4, 0] = 1;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (button29.BackColor == System.Drawing.Color.Black)
            {
                button29.BackColor = System.Drawing.Color.White;
                claseTemp[4, 1] = 0;
            }
            else
            {
                button29.BackColor = System.Drawing.Color.Black;
                claseTemp[4, 1] = 1;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (button28.BackColor == System.Drawing.Color.Black)
            {
                button28.BackColor = System.Drawing.Color.White;
                claseTemp[4, 2] = 0;
            }
            else
            {
                button28.BackColor = System.Drawing.Color.Black;
                claseTemp[4, 2] = 1;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (button27.BackColor == System.Drawing.Color.Black)
            {
                button27.BackColor = System.Drawing.Color.White;
                claseTemp[4, 3] = 0;
            }
            else
            {
                button27.BackColor = System.Drawing.Color.Black;
                claseTemp[4, 3] = 1;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (button26.BackColor == System.Drawing.Color.Black)
            {
                button26.BackColor = System.Drawing.Color.White;
                claseTemp[4, 4] = 0;
            }
            else
            {
                button26.BackColor = System.Drawing.Color.Black;
                claseTemp[4, 4] = 1;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (button25.BackColor == System.Drawing.Color.Black)
            {
                button25.BackColor = System.Drawing.Color.White;
                claseTemp[4, 5] = 0;
            }
            else
            {
                button25.BackColor = System.Drawing.Color.Black;
                claseTemp[4, 5] = 1;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (button36.BackColor == System.Drawing.Color.Black)
            {
                button36.BackColor = System.Drawing.Color.White;
                claseTemp[5, 0] = 0;
            }
            else
            {
                button36.BackColor = System.Drawing.Color.Black;
                claseTemp[5, 0] = 1;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (button35.BackColor == System.Drawing.Color.Black)
            {
                button35.BackColor = System.Drawing.Color.White;
                claseTemp[5, 1] = 0;
            }
            else
            {
                button35.BackColor = System.Drawing.Color.Black;
                claseTemp[5, 1] = 1;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (button34.BackColor == System.Drawing.Color.Black)
            {
                button34.BackColor = System.Drawing.Color.White;
                claseTemp[5, 2] = 0;
            }
            else
            {
                button34.BackColor = System.Drawing.Color.Black;
                claseTemp[5, 2] = 1;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (button33.BackColor == System.Drawing.Color.Black)
            {
                button33.BackColor = System.Drawing.Color.White;
                claseTemp[5, 3] = 0;
            }
            else
            {
                button33.BackColor = System.Drawing.Color.Black;
                claseTemp[5, 3] = 1;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (button32.BackColor == System.Drawing.Color.Black)
            {
                button32.BackColor = System.Drawing.Color.White;
                claseTemp[5, 4] = 0;
            }
            else
            {
                button32.BackColor = System.Drawing.Color.Black;
                claseTemp[5, 4] = 1;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (button31.BackColor == System.Drawing.Color.Black)
            {
                button31.BackColor = System.Drawing.Color.White;
                claseTemp[5, 5] = 0;
            }
            else
            {
                button31.BackColor = System.Drawing.Color.Black;
                claseTemp[5, 5] = 1;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Centroid frm = new Centroid();
            frm.Show();

            
        }

        private void button38_Click(object sender, EventArgs e)
        {
            ////Drawing Centroid in Window
            if (claseTemp[0, 0] == 1)
                textBox1.BackColor = System.Drawing.Color.Black;
            else
                textBox1.BackColor = System.Drawing.Color.White;

            if (claseTemp[0, 1] == 1)
                textBox2.BackColor = System.Drawing.Color.Black;
            else
                textBox2.BackColor = System.Drawing.Color.White;

            if (claseTemp[0, 3] == 1)
                textBox3.BackColor = System.Drawing.Color.Black;
            else
                textBox3.BackColor = System.Drawing.Color.White;

            if (claseTemp[0, 2] == 1)
                textBox4.BackColor = System.Drawing.Color.Black;
            else
                textBox4.BackColor = System.Drawing.Color.White;

            if (claseTemp[0, 5] == 1)
                textBox5.BackColor = System.Drawing.Color.Black;
            else
                textBox5.BackColor = System.Drawing.Color.White;

            if (claseTemp[0, 4] == 1)
                textBox6.BackColor = System.Drawing.Color.Black;
            else
                textBox6.BackColor = System.Drawing.Color.White;

            if (claseTemp[1, 0] == 1)
                textBox12.BackColor = System.Drawing.Color.Black;
            else
                textBox12.BackColor = System.Drawing.Color.White;

            if (claseTemp[1, 1] == 1)
                textBox11.BackColor = System.Drawing.Color.Black;
            else
                textBox11.BackColor = System.Drawing.Color.White;

            if (claseTemp[1, 2] == 1)
                textBox10.BackColor = System.Drawing.Color.Black;
            else
                textBox10.BackColor = System.Drawing.Color.White;

            if (claseTemp[1, 3] == 1)
                textBox9.BackColor = System.Drawing.Color.Black;
            else
                textBox9.BackColor = System.Drawing.Color.White;

            if (claseTemp[1, 4] == 1)
                textBox8.BackColor = System.Drawing.Color.Black;
            else
                textBox8.BackColor = System.Drawing.Color.White;

            if (claseTemp[1, 5] == 1)
                textBox7.BackColor = System.Drawing.Color.Black;
            else
                textBox7.BackColor = System.Drawing.Color.White;

            if (claseTemp[2, 0] == 1)
                textBox18.BackColor = System.Drawing.Color.Black;
            else
                textBox18.BackColor = System.Drawing.Color.White;

            if (claseTemp[2, 1] == 1)
                textBox17.BackColor = System.Drawing.Color.Black;
            else
                textBox17.BackColor = System.Drawing.Color.White;

            if (claseTemp[2, 2] == 1)
                textBox16.BackColor = System.Drawing.Color.Black;
            else
                textBox16.BackColor = System.Drawing.Color.White;

            if (claseTemp[2, 3] == 1)
                textBox15.BackColor = System.Drawing.Color.Black;
            else
                textBox15.BackColor = System.Drawing.Color.White;

            if (claseTemp[2, 4] == 1)
                textBox14.BackColor = System.Drawing.Color.Black;
            else
                textBox14.BackColor = System.Drawing.Color.White;

            if (claseTemp[2, 5] == 1)
                textBox13.BackColor = System.Drawing.Color.Black;
            else
                textBox13.BackColor = System.Drawing.Color.White;

            if (claseTemp[3, 0] == 1)
                textBox24.BackColor = System.Drawing.Color.Black;
            else
                textBox24.BackColor = System.Drawing.Color.White;

            if (claseTemp[3, 1] == 1)
                textBox23.BackColor = System.Drawing.Color.Black;
            else
                textBox23.BackColor = System.Drawing.Color.White;

            if (claseTemp[3, 2] == 1)
                textBox22.BackColor = System.Drawing.Color.Black;
            else
                textBox22.BackColor = System.Drawing.Color.White;

            if (claseTemp[3, 3] == 1)
                textBox21.BackColor = System.Drawing.Color.Black;
            else
                textBox21.BackColor = System.Drawing.Color.White;

            if (claseTemp[3, 4] == 1)
                textBox20.BackColor = System.Drawing.Color.Black;
            else
                textBox20.BackColor = System.Drawing.Color.White;

            if (claseTemp[3, 5] == 1)
                textBox19.BackColor = System.Drawing.Color.Black;
            else
                textBox19.BackColor = System.Drawing.Color.White;

            if (claseTemp[4, 0] == 1)
                textBox30.BackColor = System.Drawing.Color.Black;
            else
                textBox30.BackColor = System.Drawing.Color.White;

            if (claseTemp[4, 1] == 1)
                textBox29.BackColor = System.Drawing.Color.Black;
            else
                textBox29.BackColor = System.Drawing.Color.White;

            if (claseTemp[4, 2] == 1)
                textBox28.BackColor = System.Drawing.Color.Black;
            else
                textBox28.BackColor = System.Drawing.Color.White;

            if (claseTemp[4, 3] == 1)
                textBox27.BackColor = System.Drawing.Color.Black;
            else
                textBox27.BackColor = System.Drawing.Color.White;

            if (claseTemp[4, 4] == 1)
                textBox26.BackColor = System.Drawing.Color.Black;
            else
                textBox26.BackColor = System.Drawing.Color.White;

            if (claseTemp[4, 5] == 1)
                textBox25.BackColor = System.Drawing.Color.Black;
            else
                textBox25.BackColor = System.Drawing.Color.White;

            if (claseTemp[5, 0] == 1)
                textBox36.BackColor = System.Drawing.Color.Black;
            else
                textBox36.BackColor = System.Drawing.Color.White;

            if (claseTemp[5, 1] == 1)
                textBox35.BackColor = System.Drawing.Color.Black;
            else
                textBox35.BackColor = System.Drawing.Color.White;

            if (claseTemp[5, 2] == 1)
                textBox34.BackColor = System.Drawing.Color.Black;
            else
                textBox34.BackColor = System.Drawing.Color.White;

            if (claseTemp[5, 3] == 1)
                textBox33.BackColor = System.Drawing.Color.Black;
            else
                textBox33.BackColor = System.Drawing.Color.White;

            if (claseTemp[5, 4] == 1)
                textBox32.BackColor = System.Drawing.Color.Black;
            else
                textBox32.BackColor = System.Drawing.Color.White;

            if (claseTemp[5, 5] == 1)
                textBox30.BackColor = System.Drawing.Color.Black;
            else
                textBox30.BackColor = System.Drawing.Color.White;

            /// B Class Descriptors
            /// Number of colored cells
            for (int row = 0; row <= 5; row++)
            {
                for (int col = 0; col <= 5; col++)
                {
                    if (claseTemp[col, row] == 1)
                    {
                        featureOneClassTemp++;
                    }
                }
            }

            /// Number of no colored cells
            for (int row = 0; row <= 5; row++)
            {
                for (int col = 0; col <= 5; col++)
                {
                    if (centroidOne[col, row] == 0)
                    {
                        featureTwoClassTemp++;
                    }
                }
            }


        }

        private void button40_Click(object sender, EventArgs e)
        {
            ////Clear Drawing
            textBox1.BackColor = System.Drawing.Color.White;
            textBox2.BackColor = System.Drawing.Color.White;
            textBox3.BackColor = System.Drawing.Color.White;
            textBox4.BackColor = System.Drawing.Color.White;
            textBox5.BackColor = System.Drawing.Color.White;
            textBox6.BackColor = System.Drawing.Color.White;
            textBox7.BackColor = System.Drawing.Color.White;
            textBox8.BackColor = System.Drawing.Color.White;
            textBox9.BackColor = System.Drawing.Color.White;
            textBox10.BackColor = System.Drawing.Color.White;
            textBox11.BackColor = System.Drawing.Color.White;
            textBox12.BackColor = System.Drawing.Color.White;
            textBox13.BackColor = System.Drawing.Color.White;
            textBox14.BackColor = System.Drawing.Color.White;
            textBox15.BackColor = System.Drawing.Color.White;
            textBox16.BackColor = System.Drawing.Color.White;
            textBox17.BackColor = System.Drawing.Color.White;
            textBox18.BackColor = System.Drawing.Color.White;
            textBox19.BackColor = System.Drawing.Color.White;
            textBox20.BackColor = System.Drawing.Color.White;
            textBox21.BackColor = System.Drawing.Color.White;
            textBox22.BackColor = System.Drawing.Color.White;
            textBox23.BackColor = System.Drawing.Color.White;
            textBox24.BackColor = System.Drawing.Color.White;
            textBox25.BackColor = System.Drawing.Color.White;
            textBox26.BackColor = System.Drawing.Color.White;
            textBox27.BackColor = System.Drawing.Color.White;
            textBox28.BackColor = System.Drawing.Color.White;
            textBox29.BackColor = System.Drawing.Color.White;
            textBox30.BackColor = System.Drawing.Color.White;
            textBox31.BackColor = System.Drawing.Color.White;
            textBox32.BackColor = System.Drawing.Color.White;
            textBox33.BackColor = System.Drawing.Color.White;
            textBox34.BackColor = System.Drawing.Color.White;
            textBox35.BackColor = System.Drawing.Color.White;
            textBox36.BackColor = System.Drawing.Color.White;

            ////Clear Drawing
            button1.BackColor = System.Drawing.Color.White;
            button2.BackColor = System.Drawing.Color.White;
            button3.BackColor = System.Drawing.Color.White;
            button4.BackColor = System.Drawing.Color.White;
            button5.BackColor = System.Drawing.Color.White;
            button6.BackColor = System.Drawing.Color.White;
            button7.BackColor = System.Drawing.Color.White;
            button8.BackColor = System.Drawing.Color.White;
            button9.BackColor = System.Drawing.Color.White;
            button10.BackColor = System.Drawing.Color.White;
            button11.BackColor = System.Drawing.Color.White;
            button12.BackColor = System.Drawing.Color.White;
            button13.BackColor = System.Drawing.Color.White;
            button14.BackColor = System.Drawing.Color.White;
            button15.BackColor = System.Drawing.Color.White;
            button16.BackColor = System.Drawing.Color.White;
            button17.BackColor = System.Drawing.Color.White;
            button18.BackColor = System.Drawing.Color.White;
            button19.BackColor = System.Drawing.Color.White;
            button20.BackColor = System.Drawing.Color.White;
            button21.BackColor = System.Drawing.Color.White;
            button22.BackColor = System.Drawing.Color.White;
            button23.BackColor = System.Drawing.Color.White;
            button24.BackColor = System.Drawing.Color.White;
            button25.BackColor = System.Drawing.Color.White;
            button26.BackColor = System.Drawing.Color.White;
            button27.BackColor = System.Drawing.Color.White;
            button28.BackColor = System.Drawing.Color.White;
            button29.BackColor = System.Drawing.Color.White;
            button30.BackColor = System.Drawing.Color.White;
            button31.BackColor = System.Drawing.Color.White;
            button32.BackColor = System.Drawing.Color.White;
            button33.BackColor = System.Drawing.Color.White;
            button34.BackColor = System.Drawing.Color.White;
            button35.BackColor = System.Drawing.Color.White;
            button36.BackColor = System.Drawing.Color.White;

            for (int row = 0; row <= 5; row++)
            {
                for (int col = 0; col <= 5; col++)
                {
                    claseTemp[col, row] = 0;
                }
            }

            label1.Text = "";
            label2.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            distEucliOne = Math.Sqrt(Math.Pow(featureOneClassTemp - featureOneCentroidOne, 2) + Math.Pow(featureTwoClassTemp - featureTwoCentroidOne, 2));
            distEucliTwo=  Math.Sqrt( Math.Pow(featureTwoClassTemp - featureTwoCentroidTwo, 2) + Math.Pow(featureTwoClassTemp - featureTwoCentroidTwo, 2));
            
            //abs1 = (featureOneClassTemp - featureOneCentroidOne >= 0) ? (featureOneClassTemp - featureOneCentroidOne) : (featureOneClassTemp - featureOneCentroidOne) * -1;
            //abs2 = (featureTwoClassTemp - featureTwoCentroidOne >= 0) ? (featureTwoClassTemp - featureTwoCentroidOne) : (featureTwoClassTemp - featureTwoCentroidOne) * -1;
            //distEucli=Math.Sqrt((abs1 * abs1) + (abs2 * abs2));
            label1.Text = distEucliOne.ToString();
            label2.Text = distEucliTwo.ToString();
        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Distancia Manhattan o norma 1
            //double abs1 = (x1 - y1 >= 0) ? (x1 - y1) : (x1 - y1) * -1;
            //double abs2 = (x1 - y1 >= 0) ? (x1 - y1) : (x1 - y1) * -1;
            //return abs1 + abs2;
            //abs1 = (featureOneClassTemp - featureOneCentroidOne >= 0) ? (featureOneClassTemp - featureOneCentroidOne) : (featureOneClassTemp - featureOneCentroidOne) * -1;
            //abs2 = (featureTwoClassTemp - featureTwoCentroidOne >= 0) ? (featureTwoClassTemp - featureTwoCentroidOne) : (featureTwoClassTemp - featureTwoCentroidOne) * -1;
            //distManha = abs1 + abs2;
            distManhaOne = Math.Abs(((featureOneClassTemp - featureOneCentroidOne) + (featureTwoClassTemp - featureTwoCentroidOne)));
            distManhaTwo = Math.Abs(((featureOneClassTemp - featureOneCentroidTwo) + (featureTwoClassTemp - featureTwoCentroidTwo)));

            label1.Text = distManhaOne.ToString();
            label2.Text = distManhaTwo.ToString();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Descriptors frm = new Descriptors();
            frm.Show();
            
        }
        
    }
}
