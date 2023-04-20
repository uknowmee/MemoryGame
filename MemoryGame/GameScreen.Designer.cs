using System.ComponentModel;
using System.Drawing;

namespace MemoryGame
{
    partial class GameScreen
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
            this.labelMoves_str = new System.Windows.Forms.Label();
            this.labelMoves_int = new System.Windows.Forms.Label();
            this.labelWrongMoves_str = new System.Windows.Forms.Label();
            this.labelWrongMoves_int = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.labelScore_txt = new System.Windows.Forms.Label();
            this.labelScore_int = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.timerSettingsScreen = new System.Timers.Timer();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonScore = new System.Windows.Forms.Button();
            this.timerScoreScreen = new System.Timers.Timer();
            this.timerClock = new System.Timers.Timer();
            this.timerClockScore = new System.Timers.Timer();
            this.timerShow = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize) (this.timerSettingsScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.timerScoreScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.timerClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.timerClockScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.timerShow)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMoves_str
            // 
            this.labelMoves_str.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelMoves_str.Location = new System.Drawing.Point(12, 9);
            this.labelMoves_str.Name = "labelMoves_str";
            this.labelMoves_str.Size = new System.Drawing.Size(234, 40);
            this.labelMoves_str.TabIndex = 0;
            this.labelMoves_str.Text = "Number Of Moves:";
            // 
            // labelMoves_int
            // 
            this.labelMoves_int.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelMoves_int.Location = new System.Drawing.Point(252, 9);
            this.labelMoves_int.Name = "labelMoves_int";
            this.labelMoves_int.Size = new System.Drawing.Size(107, 33);
            this.labelMoves_int.TabIndex = 1;
            this.labelMoves_int.Text = "0";
            this.labelMoves_int.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelWrongMoves_str
            // 
            this.labelWrongMoves_str.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelWrongMoves_str.Location = new System.Drawing.Point(12, 61);
            this.labelWrongMoves_str.Name = "labelWrongMoves_str";
            this.labelWrongMoves_str.Size = new System.Drawing.Size(234, 40);
            this.labelWrongMoves_str.TabIndex = 2;
            this.labelWrongMoves_str.Text = "Wrong Moves:";
            // 
            // labelWrongMoves_int
            // 
            this.labelWrongMoves_int.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelWrongMoves_int.Location = new System.Drawing.Point(252, 61);
            this.labelWrongMoves_int.Name = "labelWrongMoves_int";
            this.labelWrongMoves_int.Size = new System.Drawing.Size(107, 33);
            this.labelWrongMoves_int.TabIndex = 3;
            this.labelWrongMoves_int.Text = "0";
            this.labelWrongMoves_int.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(212, 104);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(411, 267);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Visible = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonStart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonStart.Location = new System.Drawing.Point(12, 104);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(125, 40);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonStop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonStop.Location = new System.Drawing.Point(12, 150);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(125, 40);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonReset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonReset.Location = new System.Drawing.Point(12, 196);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(125, 40);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelTimer.Location = new System.Drawing.Point(653, 9);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(135, 33);
            this.labelTimer.TabIndex = 8;
            this.labelTimer.Text = "0s";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonShow
            // 
            this.buttonShow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonShow.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonShow.Location = new System.Drawing.Point(12, 242);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(125, 40);
            this.buttonShow.TabIndex = 4;
            this.buttonShow.Text = "SHOW";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonHide.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonHide.Location = new System.Drawing.Point(12, 288);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(125, 40);
            this.buttonHide.TabIndex = 5;
            this.buttonHide.Text = "HIDE";
            this.buttonHide.UseVisualStyleBackColor = false;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // labelScore_txt
            // 
            this.labelScore_txt.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScore_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelScore_txt.Location = new System.Drawing.Point(666, 352);
            this.labelScore_txt.Name = "labelScore_txt";
            this.labelScore_txt.Size = new System.Drawing.Size(122, 44);
            this.labelScore_txt.TabIndex = 11;
            this.labelScore_txt.Text = "SCORE";
            this.labelScore_txt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelScore_int
            // 
            this.labelScore_int.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScore_int.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelScore_int.Location = new System.Drawing.Point(653, 397);
            this.labelScore_int.Name = "labelScore_int";
            this.labelScore_int.Size = new System.Drawing.Size(137, 34);
            this.labelScore_int.TabIndex = 12;
            this.labelScore_int.Text = "0";
            this.labelScore_int.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSettings.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSettings.Location = new System.Drawing.Point(12, 377);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(69, 69);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // timerSettingsScreen
            // 
            this.timerSettingsScreen.SynchronizingObject = this;
            this.timerSettingsScreen.Elapsed += new System.Timers.ElapsedEventHandler(this.timerSettingsScreen_Elapsed);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonLogout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonLogout.Location = new System.Drawing.Point(732, 135);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(58, 162);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            this.buttonLogout.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonLogout_Paint);
            // 
            // buttonScore
            // 
            this.buttonScore.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonScore.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonScore.Location = new System.Drawing.Point(87, 406);
            this.buttonScore.Name = "buttonScore";
            this.buttonScore.Size = new System.Drawing.Size(159, 40);
            this.buttonScore.TabIndex = 7;
            this.buttonScore.Text = "Top Scores";
            this.buttonScore.UseVisualStyleBackColor = false;
            this.buttonScore.Click += new System.EventHandler(this.buttonScore_Click);
            // 
            // timerScoreScreen
            // 
            this.timerScoreScreen.SynchronizingObject = this;
            this.timerScoreScreen.Elapsed += new System.Timers.ElapsedEventHandler(this.timerScoreScreen_Elapsed);
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000D;
            this.timerClock.SynchronizingObject = this;
            this.timerClock.Elapsed += new System.Timers.ElapsedEventHandler(this.timerClock_Elapsed);
            // 
            // timerClockScore
            // 
            this.timerClockScore.Interval = 50D;
            this.timerClockScore.SynchronizingObject = this;
            this.timerClockScore.Elapsed += new System.Timers.ElapsedEventHandler(this.timerClockScore_Elapsed);
            // 
            // timerShow
            // 
            this.timerShow.Interval = 1000D;
            this.timerShow.SynchronizingObject = this;
            this.timerShow.Elapsed += new System.Timers.ElapsedEventHandler(this.timerShow_Elapsed);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonScore);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.labelScore_int);
            this.Controls.Add(this.labelScore_txt);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelWrongMoves_int);
            this.Controls.Add(this.labelWrongMoves_str);
            this.Controls.Add(this.labelMoves_int);
            this.Controls.Add(this.labelMoves_str);
            this.Name = "GameScreen";
            this.Text = "Memory Game";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ClosingEvent);
            this.Load += new System.EventHandler(this.InitScreen_Load);
            this.ResizeBegin += new System.EventHandler(this.GameScreen_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.GameScreen_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize) (this.timerSettingsScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.timerScoreScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.timerClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.timerClockScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.timerShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Timers.Timer timerShow;

        private System.Timers.Timer timerClockScore;

        private System.Timers.Timer timerClock;

        private System.Timers.Timer timerScoreScreen;

        private System.Windows.Forms.Button buttonScore;

        private System.Windows.Forms.Button buttonLogout;

        private System.Timers.Timer timerSettingsScreen;

        private System.Windows.Forms.Button buttonSettings;

        private System.Windows.Forms.Label labelScore_int;

        private System.Windows.Forms.Label labelScore_txt;

        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonHide;

        private System.Windows.Forms.Label labelTimer;

        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonReset;

        private System.Windows.Forms.Button buttonStart;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.Label labelMoves_int;

        private System.Windows.Forms.Label labelWrongMoves_int;

        private System.Windows.Forms.Label labelWrongMoves_str;

        private System.Windows.Forms.Label labelMoves_str;

        #endregion

    }
}