using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class MinesweeperGame : Form
    {
        public MinesweeperGame()
        {
            InitializeComponent();
        }
        
        // declarations

        // arrays
        int[,] ia2Table;        // to fill with mines and calculate no. of neighbouring mines
        int[,] ia2Clicked;      // store user clicks

        // ints
        int iRows;
        int iColumns;           // number of rows, columns
        int iFlags;             // number of flags
        int iFlagsDown;         // number of flags placed down
       
        int iSeconds;           // timer counter

        // bools
        bool bIsGame = false;

        // brushes 
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush grayBrush = new SolidBrush(Color.Gray);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush greenBrush = new SolidBrush(Color.Green);

        // pens
        Pen blackPen = new Pen(Color.Black, 2);

        // fonts
        Font font = new Font("Arial", 12, FontStyle.Bold);

        // methods

        private void NewGame()
        {

            if (
                int.TryParse(TEXTBOX_numberOfRows.Text, out iRows)
                && int.TryParse(TEXTBOX_numberOfColumns.Text, out iColumns)
               )
            {
                iColumns = Math.Min(Math.Max(5, iColumns), 20);     // cols and rows between 5 and 20
                iRows = Math.Min(Math.Max(5, iRows), 20);

                bIsGame = true;

                double dMultiplier;

                // choose difficulty level and calculate the no. of mines accordingly
                if (RADIO_easy.Checked)
                {
                    dMultiplier = 0.1;
                }
                else if (RADIO_medium.Checked)
                {
                    dMultiplier = 0.2;
                }
                else
                {
                    dMultiplier = 0.3;
                }

                iFlags = (int)(dMultiplier * iColumns * iRows);
                iFlagsDown = 0;

                // show no. of mines and remaining flags
                STATICTEXT_numberOfMines.Text = iFlags.ToString();
                STATICTEXT_flagsLeft.Text = iFlags.ToString();

                // show progress : total no. of points = sum of fields
                progressBar1.Maximum = iColumns * iRows;
                progressBar1.Value = 0;

                iSeconds = 0;

                // start timer, start game
                timer1.Enabled = true;

                GenerateMines(iColumns, iRows);

                this.Invalidate();
            }
        }

        private void DrawTable(Graphics sheet)
        {
            // upper left frame of table: [50, 70]
            // width, height: 2 + column * 21 px

            sheet.FillRectangle(grayBrush, 50, 70, iColumns * 21 + 2, iRows * 21 + 2);
            sheet.DrawRectangle(blackPen, 50, 70, iColumns * 21 + 2, iRows * 21 + 2);

            for (int i = 0; i < iRows; i++)             // iterate over whole domain
            {                                           // fill fields with mine, no. of neighbour mines or flag
                for (int j = 0; j < iColumns; j++)
                {
                    // draw fields
                    // frame
                    sheet.FillRectangle(blackBrush, 52 + j * 21, 72 + i * 21, 19, 19);              
                    // inner domain (under mine/number)
                    sheet.FillRectangle(whiteBrush, 52 + j * 21 + 2, 72 + i * 21 + 2, 15, 15);      

                    Rectangle rect = new Rectangle(52 + j * 21 + 2, 72 + i * 21 + 2, 15, 15);

                    if (ia2Clicked[j + 1, i + 1] == 1)      // left mouse button clicked
                    {
                        if (ia2Table[j + 1, i + 1] == -1)
                        {
                            // draw mine
                            sheet.FillEllipse(redBrush, 52 + j * 21 + 2, 72 + i * 21 + 2, 15, 15);
                        }
                        else
                        {
                            // draw no. of neighbour mines
                            sheet.DrawString(ia2Table[j + 1, i + 1].ToString(), font, greenBrush, rect);
                        }
                    }
                    else if (ia2Clicked[j + 1, i + 1] == 2)     // right mouse button clicked
                    {
                        // set up points for drawing the flag
                        Point[] flagPoints = new Point[3];

                        flagPoints[0] = new Point(rect.X + 2, rect.Y + 4);
                        flagPoints[1] = new Point(rect.X + 7, rect.Y + 1);
                        flagPoints[2] = new Point(rect.X + 7, rect.Y + 8);

                        // draw the flag
                        sheet.FillPolygon(redBrush, flagPoints);
                        sheet.DrawLine(blackPen, rect.X + 7, rect.Y + 1, rect.X + 7, rect.Y + 12);

                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void GenerateMines(int iCols, int iRows)
        {
            ia2Table = new int[iCols + 2, iRows + 2];       // store mines   
            ia2Clicked = new int[iCols + 2, iRows + 2];     // store fields the user has clicked in

            Random rn = new Random();

            int iMines = 0;     // number of mines generated

            while (iMines < iFlags)
            {
                int iX, iY;

                iX = rn.Next(1, iCols + 1);     // get random field for the mine
                iY = rn.Next(1, iRows + 1);

                if (ia2Table[iX, iY] != -1)     // if the current field is not occupied by a mine
                {
                    ia2Table[iX, iY] = -1;
                    iMines++;
                }
            }

            for (int i = 1; i < iCols + 1; i++)             // iterate over the whole domain
            {
                for (int j = 1; j < iRows + 1; j++)
                {
                    ia2Clicked[i, j] = 0;                   // set clicked status 0. 1 = left click, 2 = right click

                    if (ia2Table[i, j] != -1)               // if not a mine in the field
                    {
                        int iNeighbourMines = 0;

                        for (int k = -1; k < 2; k++)        // iterate over the neighbouring cells
                        {
                            for (int l = -1; l < 2; l++)
                            {
                                if (ia2Table[i + k, j + l] == -1)   // if mine found in the neighbourhood
                                {
                                    iNeighbourMines++;      // count mine
                                }
                            }
                        }

                        ia2Table[i, j] = iNeighbourMines;   // set the total amount of neighbouring mines
                    }
                }
            }
        }


        private void MinesweeperGame_Paint(object sender, PaintEventArgs e)
        {
            DrawTable(e.Graphics);
        }

        private void MinesweeperGame_MouseDown(object sender, MouseEventArgs e)
        {
            if (bIsGame)
            {
                double dXClick = e.X;       // get click coordinates
                double dYClick = e.Y;

                dXClick -= 52;              // offset coordinates
                dYClick -= 72;

                if (dXClick >= 0 && dYClick >= 0)           // click inside game domain: Condition 1
                {
                    int iXDirNumber = (int)dXClick / 21;
                    int iYDirNumber = (int)dYClick / 21;

                    if (iXDirNumber < iRows && iYDirNumber < iColumns)      // click inside game domain: Condition 2
                    {
                        dXClick -= iXDirNumber * 21;            // offset coordinates inside field
                        dYClick -= iYDirNumber * 21;

                        if (dXClick <= 19 && dYClick <= 19)     // button click inside a field
                        {

                            if (e.Button == MouseButtons.Left)  // left click in field
                            {
                                if (ia2Clicked[iXDirNumber + 1, iYDirNumber + 1] == 0)  // if not clicked yet
                                {
                                    ia2Clicked[iXDirNumber + 1, iYDirNumber + 1] = 1;   // then mark it clicked (as left click)

                                    if (ia2Table[iXDirNumber + 1, iYDirNumber + 1] == -1)   // if mine hit
                                    {
                                        bIsGame = false;
                                        MessageBox.Show("You have hit a mine!", "Game over.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        progressBar1.Value++;
                                    }
                                }


                            }
                            if (e.Button == MouseButtons.Right) // right click in field
                            {
                                if (ia2Clicked[iXDirNumber + 1, iYDirNumber + 1] == 0)  // if not clicked yet
                                {
                                    if (iFlagsDown < iFlags)    // if flag still available
                                    {
                                        ia2Clicked[iXDirNumber + 1, iYDirNumber + 1] = 2;   // mark field as right clicked

                                        iFlagsDown++;
                                        progressBar1.Value++;

                                        STATICTEXT_flagsLeft.Text = (iFlags - iFlagsDown).ToString();
                                    }

                                }
                                else if (ia2Clicked[iXDirNumber + 1, iYDirNumber + 1] == 2) // if clicked, flag already down on field
                                {
                                        ia2Clicked[iXDirNumber + 1, iYDirNumber + 1] = 0;   // remove flag, mark as unclicked

                                        iFlagsDown--;
                                        progressBar1.Value--;

                                        STATICTEXT_flagsLeft.Text = (iFlags - iFlagsDown).ToString();
                                    
                                }

                            }

                        }

                    }

                }


            }
            this.Invalidate();

            if (progressBar1.Value+iFlags-iFlagsDown == progressBar1.Maximum)   // check win condition
            {
                bIsGame = false;
                MessageBox.Show("Congratulations! You won!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bIsGame)
            {
                iSeconds++;
            }
        }
    }
}
