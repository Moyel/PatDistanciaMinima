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
    public partial class Centroid : Form
    {
        /// This is the Centroid for the first Class or B Class
        int[,] centroidOne = new int[6, 6] {     { 0, 1, 1, 0, 0, 0, },
                                                 { 0, 1, 0, 1, 0, 0, },
                                                 { 0, 1, 1, 0, 0, 0, },
                                                 { 0, 1, 0, 1, 0, 0, },
                                                 { 0, 1, 1, 0, 0, 0, },
                                                 { 0, 0, 0, 0, 0, 0, }};

        /// This is the Centroid for the seconds Class or 8 Class
        int[,] centroidTwo = new int[6, 6]{      { 0, 1, 1, 1, 0, 0, },
                                                 { 0, 1, 0, 1, 0, 0, },
                                                 { 0, 1, 1, 1, 0, 0, },
                                                 { 0, 1, 0, 1, 0, 0, },
                                                 { 0, 1, 1, 1, 0, 0, },
                                                 { 0, 0, 0, 0, 0, 0, }};

        /// This is the Container for the Class to be evaluated
        /// 

        public Centroid()
        {
            InitializeComponent();

            ////Drawing Centroid in Window
            if (centroidOne[0, 0] == 1)
                textBox1.BackColor = System.Drawing.Color.Black;
            else
                textBox1.BackColor = System.Drawing.Color.White;

            if (centroidOne[0, 1] == 1)
                textBox2.BackColor = System.Drawing.Color.Black;
            else
                textBox2.BackColor = System.Drawing.Color.White;

            if (centroidOne[0, 3] == 1)
                textBox3.BackColor = System.Drawing.Color.Black;
            else
                textBox3.BackColor = System.Drawing.Color.White;

            if (centroidOne[0, 2] == 1)
                textBox4.BackColor = System.Drawing.Color.Black;
            else
                textBox4.BackColor = System.Drawing.Color.White;

            if (centroidOne[0, 4] == 1)
                textBox5.BackColor = System.Drawing.Color.Black;
            else
                textBox5.BackColor = System.Drawing.Color.White;

            if (centroidOne[0, 5] == 1)
                textBox6.BackColor = System.Drawing.Color.Black;
            else
                textBox6.BackColor = System.Drawing.Color.White;

            if (centroidOne[1, 0] == 1)
                textBox12.BackColor = System.Drawing.Color.Black;
            else
                textBox12.BackColor = System.Drawing.Color.White;

            if (centroidOne[1, 1] == 1)
                textBox11.BackColor = System.Drawing.Color.Black;
            else
                textBox11.BackColor = System.Drawing.Color.White;

            if (centroidOne[1, 2] == 1)
                textBox10.BackColor = System.Drawing.Color.Black;
            else
                textBox10.BackColor = System.Drawing.Color.White;

            if (centroidOne[1, 3] == 1)
                textBox9.BackColor = System.Drawing.Color.Black;
            else
                textBox9.BackColor = System.Drawing.Color.White;

            if (centroidOne[1, 4] == 1)
                textBox8.BackColor = System.Drawing.Color.Black;
            else
                textBox8.BackColor = System.Drawing.Color.White;

            if (centroidOne[1, 5] == 1)
                textBox7.BackColor = System.Drawing.Color.Black;
            else
                textBox7.BackColor = System.Drawing.Color.White;

            if (centroidOne[2, 0] == 1)
                textBox18.BackColor = System.Drawing.Color.Black;
            else
                textBox18.BackColor = System.Drawing.Color.White;

            if (centroidOne[2, 1] == 1)
                textBox17.BackColor = System.Drawing.Color.Black;
            else
                textBox17.BackColor = System.Drawing.Color.White;

            if (centroidOne[2, 2] == 1)
                textBox16.BackColor = System.Drawing.Color.Black;
            else
                textBox16.BackColor = System.Drawing.Color.White;

            if (centroidOne[2, 3] == 1)
                textBox15.BackColor = System.Drawing.Color.Black;
            else
                textBox15.BackColor = System.Drawing.Color.White;

            if (centroidOne[2, 4] == 1)
                textBox14.BackColor = System.Drawing.Color.Black;
            else
                textBox14.BackColor = System.Drawing.Color.White;

            if (centroidOne[2, 5] == 1)
                textBox13.BackColor = System.Drawing.Color.Black;
            else
                textBox13.BackColor = System.Drawing.Color.White;

            if (centroidOne[3, 0] == 1)
                textBox24.BackColor = System.Drawing.Color.Black;
            else
                textBox24.BackColor = System.Drawing.Color.White;

            if (centroidOne[3, 1] == 1)
                textBox23.BackColor = System.Drawing.Color.Black;
            else
                textBox23.BackColor = System.Drawing.Color.White;

            if (centroidOne[3, 2] == 1)
                textBox22.BackColor = System.Drawing.Color.Black;
            else
                textBox22.BackColor = System.Drawing.Color.White;

            if (centroidOne[3, 3] == 1)
                textBox21.BackColor = System.Drawing.Color.Black;
            else
                textBox21.BackColor = System.Drawing.Color.White;

            if (centroidOne[3, 4] == 1)
                textBox20.BackColor = System.Drawing.Color.Black;
            else
                textBox20.BackColor = System.Drawing.Color.White;

            if (centroidOne[3, 5] == 1)
                textBox19.BackColor = System.Drawing.Color.Black;
            else
                textBox19.BackColor = System.Drawing.Color.White;

            if (centroidOne[4, 0] == 1)
                textBox30.BackColor = System.Drawing.Color.Black;
            else
                textBox30.BackColor = System.Drawing.Color.White;

            if (centroidOne[4, 1] == 1)
                textBox29.BackColor = System.Drawing.Color.Black;
            else
                textBox29.BackColor = System.Drawing.Color.White;

            if (centroidOne[4, 2] == 1)
                textBox28.BackColor = System.Drawing.Color.Black;
            else
                textBox28.BackColor = System.Drawing.Color.White;

            if (centroidOne[4, 3] == 1)
                textBox27.BackColor = System.Drawing.Color.Black;
            else
                textBox27.BackColor = System.Drawing.Color.White;

            if (centroidOne[4, 4] == 1)
                textBox26.BackColor = System.Drawing.Color.Black;
            else
                textBox26.BackColor = System.Drawing.Color.White;

            if (centroidOne[4, 5] == 1)
                textBox25.BackColor = System.Drawing.Color.Black;
            else
                textBox25.BackColor = System.Drawing.Color.White;

            if (centroidOne[5, 0] == 1)
                textBox36.BackColor = System.Drawing.Color.Black;
            else
                textBox36.BackColor = System.Drawing.Color.White;

            if (centroidOne[5, 1] == 1)
                textBox35.BackColor = System.Drawing.Color.Black;
            else
                textBox35.BackColor = System.Drawing.Color.White;

            if (centroidOne[5, 2] == 1)
                textBox34.BackColor = System.Drawing.Color.Black;
            else
                textBox34.BackColor = System.Drawing.Color.White;

            if (centroidOne[5, 3] == 1)
                textBox33.BackColor = System.Drawing.Color.Black;
            else
                textBox33.BackColor = System.Drawing.Color.White;

            if (centroidOne[5, 4] == 1)
                textBox32.BackColor = System.Drawing.Color.Black;
            else
                textBox32.BackColor = System.Drawing.Color.White;

            if (centroidOne[5, 5] == 1)
                textBox30.BackColor = System.Drawing.Color.Black;
            else
                textBox30.BackColor = System.Drawing.Color.White;

            ////Centroid Two
            if (centroidTwo[0, 0] == 1)
                textBox72.BackColor = System.Drawing.Color.Black;
            else
                textBox72.BackColor = System.Drawing.Color.White;

            if (centroidTwo[0, 1] == 1)
                textBox71.BackColor = System.Drawing.Color.Black;
            else
                textBox71.BackColor = System.Drawing.Color.White;

            if (centroidTwo[0, 2] == 1)
                textBox70.BackColor = System.Drawing.Color.Black;
            else
                textBox70.BackColor = System.Drawing.Color.White;

            if (centroidTwo[0, 3] == 1)
                textBox69.BackColor = System.Drawing.Color.Black;
            else
                textBox69.BackColor = System.Drawing.Color.White;

            if (centroidTwo[0, 4] == 1)
                textBox68.BackColor = System.Drawing.Color.Black;
            else
                textBox68.BackColor = System.Drawing.Color.White;

            if (centroidTwo[0, 5] == 1)
                textBox67.BackColor = System.Drawing.Color.Black;
            else
                textBox67.BackColor = System.Drawing.Color.White;

            if (centroidTwo[1, 0] == 1)
                textBox66.BackColor = System.Drawing.Color.Black;
            else
                textBox66.BackColor = System.Drawing.Color.White;

            if (centroidTwo[1, 1] == 1)
                textBox65.BackColor = System.Drawing.Color.Black;
            else
                textBox65.BackColor = System.Drawing.Color.White;

            if (centroidTwo[1, 2] == 1)
                textBox64.BackColor = System.Drawing.Color.Black;
            else
                textBox64.BackColor = System.Drawing.Color.White;

            if (centroidTwo[1, 3] == 1)
                textBox63.BackColor = System.Drawing.Color.Black;
            else
                textBox63.BackColor = System.Drawing.Color.White;

            if (centroidTwo[1, 4] == 1)
                textBox62.BackColor = System.Drawing.Color.Black;
            else
                textBox62.BackColor = System.Drawing.Color.White;

            if (centroidTwo[1, 5] == 1)
                textBox61.BackColor = System.Drawing.Color.Black;
            else
                textBox61.BackColor = System.Drawing.Color.White;

            if (centroidTwo[2, 0] == 1)
                textBox60.BackColor = System.Drawing.Color.Black;
            else
                textBox60.BackColor = System.Drawing.Color.White;

            if (centroidTwo[2, 1] == 1)
                textBox59.BackColor = System.Drawing.Color.Black;
            else
                textBox59.BackColor = System.Drawing.Color.White;

            if (centroidTwo[2, 2] == 1)
                textBox58.BackColor = System.Drawing.Color.Black;
            else
                textBox58.BackColor = System.Drawing.Color.White;

            if (centroidTwo[2, 3] == 1)
                textBox57.BackColor = System.Drawing.Color.Black;
            else
                textBox57.BackColor = System.Drawing.Color.White;

            if (centroidTwo[2, 4] == 1)
                textBox56.BackColor = System.Drawing.Color.Black;
            else
                textBox56.BackColor = System.Drawing.Color.White;

            if (centroidTwo[2, 5] == 1)
                textBox55.BackColor = System.Drawing.Color.Black;
            else
                textBox55.BackColor = System.Drawing.Color.White;

            if (centroidTwo[3, 0] == 1)
                textBox54.BackColor = System.Drawing.Color.Black;
            else
                textBox54.BackColor = System.Drawing.Color.White;

            if (centroidTwo[3, 1] == 1)
                textBox53.BackColor = System.Drawing.Color.Black;
            else
                textBox53.BackColor = System.Drawing.Color.White;

            if (centroidTwo[3, 2] == 1)
                textBox52.BackColor = System.Drawing.Color.Black;
            else
                textBox52.BackColor = System.Drawing.Color.White;

            if (centroidTwo[3, 3] == 1)
                textBox51.BackColor = System.Drawing.Color.Black;
            else
                textBox51.BackColor = System.Drawing.Color.White;

            if (centroidTwo[3, 4] == 1)
                textBox50.BackColor = System.Drawing.Color.Black;
            else
                textBox50.BackColor = System.Drawing.Color.White;

            if (centroidTwo[3, 5] == 1)
                textBox49.BackColor = System.Drawing.Color.Black;
            else
                textBox49.BackColor = System.Drawing.Color.White;

            if (centroidTwo[4, 0] == 1)
                textBox48.BackColor = System.Drawing.Color.Black;
            else
                textBox48.BackColor = System.Drawing.Color.White;

            if (centroidTwo[4, 1] == 1)
                textBox47.BackColor = System.Drawing.Color.Black;
            else
                textBox47.BackColor = System.Drawing.Color.White;

            if (centroidTwo[4, 2] == 1)
                textBox46.BackColor = System.Drawing.Color.Black;
            else
                textBox46.BackColor = System.Drawing.Color.White;

            if (centroidTwo[4, 3] == 1)
                textBox45.BackColor = System.Drawing.Color.Black;
            else
                textBox45.BackColor = System.Drawing.Color.White;

            if (centroidTwo[4, 4] == 1)
                textBox44.BackColor = System.Drawing.Color.Black;
            else
                textBox44.BackColor = System.Drawing.Color.White;

            if (centroidTwo[4, 5] == 1)
                textBox43.BackColor = System.Drawing.Color.Black;
            else
                textBox43.BackColor = System.Drawing.Color.White;

            if (centroidTwo[5, 0] == 1)
                textBox42.BackColor = System.Drawing.Color.Black;
            else
                textBox42.BackColor = System.Drawing.Color.White;

            if (centroidTwo[5, 1] == 1)
                textBox41.BackColor = System.Drawing.Color.Black;
            else
                textBox41.BackColor = System.Drawing.Color.White;

            if (centroidTwo[5, 2] == 1)
                textBox40.BackColor = System.Drawing.Color.Black;
            else
                textBox40.BackColor = System.Drawing.Color.White;

            if (centroidTwo[5, 3] == 1)
                textBox39.BackColor = System.Drawing.Color.Black;
            else
                textBox39.BackColor = System.Drawing.Color.White;

            if (centroidTwo[5, 4] == 1)
                textBox38.BackColor = System.Drawing.Color.Black;
            else
                textBox38.BackColor = System.Drawing.Color.White;

            if (centroidTwo[5, 5] == 1)
                textBox37.BackColor = System.Drawing.Color.Black;
            else
                textBox37.BackColor = System.Drawing.Color.White;

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
