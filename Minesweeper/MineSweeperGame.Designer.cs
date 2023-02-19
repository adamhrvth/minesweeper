namespace Minesweeper
{
    partial class MinesweeperGame
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TEXTBOX_numberOfRows = new System.Windows.Forms.TextBox();
            this.TEXTBOX_numberOfColumns = new System.Windows.Forms.TextBox();
            this.RADIO_easy = new System.Windows.Forms.RadioButton();
            this.RADIO_medium = new System.Windows.Forms.RadioButton();
            this.RADIO_difficult = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.STATICTEXT_numberOfMines = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.STATICTEXT_flagsLeft = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of rows:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of columns:";
            // 
            // TEXTBOX_numberOfRows
            // 
            this.TEXTBOX_numberOfRows.Location = new System.Drawing.Point(119, 4);
            this.TEXTBOX_numberOfRows.Name = "TEXTBOX_numberOfRows";
            this.TEXTBOX_numberOfRows.Size = new System.Drawing.Size(100, 20);
            this.TEXTBOX_numberOfRows.TabIndex = 2;
            // 
            // TEXTBOX_numberOfColumns
            // 
            this.TEXTBOX_numberOfColumns.Location = new System.Drawing.Point(119, 29);
            this.TEXTBOX_numberOfColumns.Name = "TEXTBOX_numberOfColumns";
            this.TEXTBOX_numberOfColumns.Size = new System.Drawing.Size(100, 20);
            this.TEXTBOX_numberOfColumns.TabIndex = 3;
            // 
            // RADIO_easy
            // 
            this.RADIO_easy.AutoSize = true;
            this.RADIO_easy.Checked = true;
            this.RADIO_easy.Location = new System.Drawing.Point(238, 3);
            this.RADIO_easy.Name = "RADIO_easy";
            this.RADIO_easy.Size = new System.Drawing.Size(107, 17);
            this.RADIO_easy.TabIndex = 4;
            this.RADIO_easy.TabStop = true;
            this.RADIO_easy.Text = "Easy (10% mines)";
            this.RADIO_easy.UseVisualStyleBackColor = true;
            // 
            // RADIO_medium
            // 
            this.RADIO_medium.AutoSize = true;
            this.RADIO_medium.Location = new System.Drawing.Point(238, 22);
            this.RADIO_medium.Name = "RADIO_medium";
            this.RADIO_medium.Size = new System.Drawing.Size(121, 17);
            this.RADIO_medium.TabIndex = 5;
            this.RADIO_medium.Text = "Medium (20% mines)";
            this.RADIO_medium.UseVisualStyleBackColor = true;
            // 
            // RADIO_difficult
            // 
            this.RADIO_difficult.AutoSize = true;
            this.RADIO_difficult.Location = new System.Drawing.Point(238, 45);
            this.RADIO_difficult.Name = "RADIO_difficult";
            this.RADIO_difficult.Size = new System.Drawing.Size(119, 17);
            this.RADIO_difficult.TabIndex = 6;
            this.RADIO_difficult.Text = "Difficult (30% mines)";
            this.RADIO_difficult.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mines:";
            // 
            // STATICTEXT_numberOfMines
            // 
            this.STATICTEXT_numberOfMines.AutoSize = true;
            this.STATICTEXT_numberOfMines.Location = new System.Drawing.Point(443, 7);
            this.STATICTEXT_numberOfMines.Name = "STATICTEXT_numberOfMines";
            this.STATICTEXT_numberOfMines.Size = new System.Drawing.Size(16, 13);
            this.STATICTEXT_numberOfMines.TabIndex = 8;
            this.STATICTEXT_numberOfMines.Text = " - ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "New game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 548);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(900, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Flags left:";
            // 
            // STATICTEXT_flagsLeft
            // 
            this.STATICTEXT_flagsLeft.AutoSize = true;
            this.STATICTEXT_flagsLeft.Location = new System.Drawing.Point(612, 9);
            this.STATICTEXT_flagsLeft.Name = "STATICTEXT_flagsLeft";
            this.STATICTEXT_flagsLeft.Size = new System.Drawing.Size(16, 13);
            this.STATICTEXT_flagsLeft.TabIndex = 12;
            this.STATICTEXT_flagsLeft.Text = " - ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MinesweeperGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 571);
            this.Controls.Add(this.STATICTEXT_flagsLeft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.STATICTEXT_numberOfMines);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RADIO_difficult);
            this.Controls.Add(this.RADIO_medium);
            this.Controls.Add(this.RADIO_easy);
            this.Controls.Add(this.TEXTBOX_numberOfColumns);
            this.Controls.Add(this.TEXTBOX_numberOfRows);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MinesweeperGame";
            this.Text = "MinesweeperGame";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MinesweeperGame_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinesweeperGame_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TEXTBOX_numberOfRows;
        private System.Windows.Forms.TextBox TEXTBOX_numberOfColumns;
        private System.Windows.Forms.RadioButton RADIO_easy;
        private System.Windows.Forms.RadioButton RADIO_medium;
        private System.Windows.Forms.RadioButton RADIO_difficult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label STATICTEXT_numberOfMines;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label STATICTEXT_flagsLeft;
        private System.Windows.Forms.Timer timer1;
    }
}

