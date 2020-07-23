using System.Drawing;

namespace ChessGame
{
    partial class Form1
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
            this.goTumakeBordButtonManuButton = new System.Windows.Forms.Button();
            this.numericXForDataGrid = new System.Windows.Forms.NumericUpDown();
            this.numericYForDataGrid = new System.Windows.Forms.NumericUpDown();
            this.makeBordButton = new System.Windows.Forms.Button();
            this.bordPannel = new System.Windows.Forms.Panel();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.queenButton = new System.Windows.Forms.Button();
            this.numberOfPlayersUpDown = new System.Windows.Forms.NumericUpDown();
            this.PlayerNumberLabel = new System.Windows.Forms.Label();
            this.RowLabel = new System.Windows.Forms.Label();
            this.ColumnLabel = new System.Windows.Forms.Label();
            this.InstantiateNormalGameButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericXForDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYForDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPlayersUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // goTumakeBordButtonManuButton
            // 
            this.goTumakeBordButtonManuButton.Location = new System.Drawing.Point(43, 454);
            this.goTumakeBordButtonManuButton.Name = "goTumakeBordButtonManuButton";
            this.goTumakeBordButtonManuButton.Size = new System.Drawing.Size(88, 27);
            this.goTumakeBordButtonManuButton.TabIndex = 0;
            this.goTumakeBordButtonManuButton.Text = "Start";
            this.goTumakeBordButtonManuButton.UseVisualStyleBackColor = true;
            this.goTumakeBordButtonManuButton.Click += new System.EventHandler(this.goTumakeBordButtonManuButton_Click);
            // 
            // numericXForDataGrid
            // 
            this.numericXForDataGrid.Location = new System.Drawing.Point(144, 50);
            this.numericXForDataGrid.Name = "numericXForDataGrid";
            this.numericXForDataGrid.Size = new System.Drawing.Size(88, 22);
            this.numericXForDataGrid.TabIndex = 2;
            this.numericXForDataGrid.Visible = false;
            // 
            // numericYForDataGrid
            // 
            this.numericYForDataGrid.Location = new System.Drawing.Point(145, 85);
            this.numericYForDataGrid.Name = "numericYForDataGrid";
            this.numericYForDataGrid.Size = new System.Drawing.Size(87, 22);
            this.numericYForDataGrid.TabIndex = 3;
            this.numericYForDataGrid.Visible = false;
            // 
            // makeBordButton
            // 
            this.makeBordButton.Location = new System.Drawing.Point(144, 127);
            this.makeBordButton.Name = "makeBordButton";
            this.makeBordButton.Size = new System.Drawing.Size(88, 26);
            this.makeBordButton.TabIndex = 4;
            this.makeBordButton.Text = "makeBordButton";
            this.makeBordButton.UseVisualStyleBackColor = true;
            this.makeBordButton.Visible = false;
            this.makeBordButton.Click += new System.EventHandler(this.makeBordButton_Click);
            // 
            // bordPannel
            // 
            this.bordPannel.Location = new System.Drawing.Point(258, 19);
            this.bordPannel.Name = "bordPannel";
            this.bordPannel.Size = new System.Drawing.Size(501, 462);
            this.bordPannel.TabIndex = 5;
            this.bordPannel.Visible = false;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(144, 178);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(88, 26);
            this.GoBackButton.TabIndex = 6;
            this.GoBackButton.Text = "GoBackButton";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Visible = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // queenButton
            // 
            this.queenButton.Image = global::ChessGame.Properties.Resources.Queen;
            this.queenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.queenButton.Location = new System.Drawing.Point(258, 504);
            this.queenButton.Name = "queenButton";
            this.queenButton.Size = new System.Drawing.Size(35, 33);
            this.queenButton.TabIndex = 7;
            this.queenButton.UseVisualStyleBackColor = true;
            this.queenButton.Click += new System.EventHandler(this.queenButton_Click);
            // 
            // numberOfPlayersUpDown
            // 
            this.numberOfPlayersUpDown.Location = new System.Drawing.Point(145, 17);
            this.numberOfPlayersUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberOfPlayersUpDown.Name = "numberOfPlayersUpDown";
            this.numberOfPlayersUpDown.Size = new System.Drawing.Size(87, 22);
            this.numberOfPlayersUpDown.TabIndex = 8;
            this.numberOfPlayersUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberOfPlayersUpDown.Visible = false;
            // 
            // PlayerNumberLabel
            // 
            this.PlayerNumberLabel.AutoSize = true;
            this.PlayerNumberLabel.Location = new System.Drawing.Point(3, 19);
            this.PlayerNumberLabel.Name = "PlayerNumberLabel";
            this.PlayerNumberLabel.Size = new System.Drawing.Size(128, 17);
            this.PlayerNumberLabel.TabIndex = 9;
            this.PlayerNumberLabel.Text = "Number Of Players";
            this.PlayerNumberLabel.Visible = false;
            // 
            // RowLabel
            // 
            this.RowLabel.AutoSize = true;
            this.RowLabel.Location = new System.Drawing.Point(3, 52);
            this.RowLabel.Name = "RowLabel";
            this.RowLabel.Size = new System.Drawing.Size(42, 17);
            this.RowLabel.TabIndex = 10;
            this.RowLabel.Text = "Rows";
            this.RowLabel.Visible = false;
            // 
            // ColumnLabel
            // 
            this.ColumnLabel.AutoSize = true;
            this.ColumnLabel.Location = new System.Drawing.Point(3, 90);
            this.ColumnLabel.Name = "ColumnLabel";
            this.ColumnLabel.Size = new System.Drawing.Size(62, 17);
            this.ColumnLabel.TabIndex = 11;
            this.ColumnLabel.Text = "Columns";
            this.ColumnLabel.Visible = false;
            // 
            // InstantiateNormalGameButton
            // 
            this.InstantiateNormalGameButton.Location = new System.Drawing.Point(144, 230);
            this.InstantiateNormalGameButton.Name = "InstantiateNormalGameButton";
            this.InstantiateNormalGameButton.Size = new System.Drawing.Size(88, 26);
            this.InstantiateNormalGameButton.TabIndex = 12;
            this.InstantiateNormalGameButton.Text = "Normal Chess";
            this.InstantiateNormalGameButton.UseVisualStyleBackColor = true;
            this.InstantiateNormalGameButton.Visible = false;
            this.InstantiateNormalGameButton.Click += new System.EventHandler(this.InstantiateNormalGameButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(146, 281);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(85, 25);
            this.playButton.TabIndex = 13;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 695);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.InstantiateNormalGameButton);
            this.Controls.Add(this.ColumnLabel);
            this.Controls.Add(this.RowLabel);
            this.Controls.Add(this.PlayerNumberLabel);
            this.Controls.Add(this.numberOfPlayersUpDown);
            this.Controls.Add(this.queenButton);
            this.Controls.Add(this.goTumakeBordButtonManuButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.bordPannel);
            this.Controls.Add(this.makeBordButton);
            this.Controls.Add(this.numericYForDataGrid);
            this.Controls.Add(this.numericXForDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericXForDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYForDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPlayersUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goTumakeBordButtonManuButton;
        private System.Windows.Forms.NumericUpDown numericXForDataGrid;
        private System.Windows.Forms.NumericUpDown numericYForDataGrid;
        private System.Windows.Forms.Button makeBordButton;
        private System.Windows.Forms.Panel bordPannel;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button queenButton;
        private System.Windows.Forms.NumericUpDown numberOfPlayersUpDown;
        private System.Windows.Forms.Label PlayerNumberLabel;
        private System.Windows.Forms.Label RowLabel;
        private System.Windows.Forms.Label ColumnLabel;
        private System.Windows.Forms.Button InstantiateNormalGameButton;
        private System.Windows.Forms.Button playButton;
    }
}

