using ChessGame.BordFolder;
using ChessGame.Pices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGame
{
    public partial class Form1 : Form
    {
        Bord chessBord;
        Button[,] buttonsOnThePannel;
        Pice printPice;
        Game game;

        public Form1()
        {
            InitializeComponent();
        }

        private void makeBordButton_Click(object sender, EventArgs e)
        {
            this.bordPannel.Controls.Clear();
            if(this.numericXForDataGrid.Value > 0 && this.numericYForDataGrid.Value > 0)
            {
                int x = (int)this.numericXForDataGrid.Value;
                int y = (int)this.numericYForDataGrid.Value;
                chessBord = new Bord(x, y);
                buttonsOnThePannel = new Button[x, y];
                FillPannelGui(x, y);
            }
        }

        private void FillPannelGui(int numericXForDataGrid, int numericYForDataGrid)
        { 
            int buttonHeight = this.bordPannel.Height / numericXForDataGrid;
            int buttonWidth = this.bordPannel.Width / numericYForDataGrid;            
            for (int i = 0; i < numericXForDataGrid; i++) {
                for(int j = 0; j < numericYForDataGrid; j++)
                {
                    buttonsOnThePannel[i, j] = new Button();
                    buttonsOnThePannel[i, j].Height = buttonHeight;
                    buttonsOnThePannel[i, j].Width = buttonWidth;
                    buttonsOnThePannel[i, j].Click += bordCellGrid;

                    this.bordPannel.Controls.Add(buttonsOnThePannel[i,j]);

                    buttonsOnThePannel[i, j].Location = new Point(i * buttonWidth, j * buttonHeight);
                }
            }
        }

        private void bordCellGrid(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented Yet");
        }

        private void goTumakeBordButtonManuButton_Click(object sender, EventArgs e)
        {
            this.RowLabel.Visible = true;
            this.ColumnLabel.Visible = true;
            this.PlayerNumberLabel.Visible = true;
            this.numberOfPlayersUpDown.Visible = true;
            this.goTumakeBordButtonManuButton.Visible = false;
            this.bordPannel.Visible = true;
            this.numericXForDataGrid.Visible = true;
            this.numericYForDataGrid.Visible = true;
            this.makeBordButton.Visible = true;
            this.GoBackButton.Visible = true;
            this.InstantiateNormalGameButton.Visible = true;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.InstantiateNormalGameButton.Visible = false;
            this.RowLabel.Visible = false;
            this.ColumnLabel.Visible = false;
            this.PlayerNumberLabel.Visible = false;
            this.numberOfPlayersUpDown.Visible = false;
            this.bordPannel.Visible = false;
            this.numericXForDataGrid.Visible = false;
            this.numericYForDataGrid.Visible = false;
            this.makeBordButton.Visible = false;
            this.GoBackButton.Visible = false;
            this.goTumakeBordButtonManuButton.Visible = true;
        }

        private void queenButton_Click(object sender, EventArgs e)
        {
            printPice = new Queen();
        }

        private void InstantiateNormalGameButton_Click(object sender, EventArgs e)
        {
            this.bordPannel.Controls.Clear();
            this.numericXForDataGrid.Value = 8;
            this.numericYForDataGrid.Value = 8;
            this.numberOfPlayersUpDown.Value = 2;
            makeBordButton_Click(sender, e);
        }

        private void playButton_Click(object sender, EventArgs e)
        {

        }
    }
}
