using System.ComponentModel;

namespace MemoryGame
{
    partial class InitScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelFace = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.timerSettings = new System.Timers.Timer();
            this.timerRegister = new System.Timers.Timer();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonScore = new System.Windows.Forms.Button();
            this.timerScore = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize) (this.timerSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.timerRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.timerScore)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonLogin.Location = new System.Drawing.Point(248, 210);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(154, 40);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonRegister.Location = new System.Drawing.Point(408, 210);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(154, 40);
            this.buttonRegister.TabIndex = 4;
            this.buttonRegister.Text = "REGISTER";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxLogin.Location = new System.Drawing.Point(248, 130);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(314, 34);
            this.textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.textBoxPassword.Location = new System.Drawing.Point(248, 170);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(314, 34);
            this.textBoxPassword.TabIndex = 2;
            // 
            // labelFace
            // 
            this.labelFace.Location = new System.Drawing.Point(12, 9);
            this.labelFace.Margin = new System.Windows.Forms.Padding(0);
            this.labelFace.Name = "labelFace";
            this.labelFace.Size = new System.Drawing.Size(289, 262);
            this.labelFace.TabIndex = 4;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSettings.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSettings.Location = new System.Drawing.Point(12, 377);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(69, 69);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // timerSettings
            // 
            this.timerSettings.SynchronizingObject = this;
            this.timerSettings.Elapsed += new System.Timers.ElapsedEventHandler(this.timerSettings_Elapsed);
            // 
            // timerRegister
            // 
            this.timerRegister.SynchronizingObject = this;
            this.timerRegister.Elapsed += new System.Timers.ElapsedEventHandler(this.timerRegister_Elapsed);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonQuit.Location = new System.Drawing.Point(678, 398);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(110, 48);
            this.buttonQuit.TabIndex = 7;
            this.buttonQuit.Text = "QUIT";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonScore
            // 
            this.buttonScore.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonScore.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonScore.Location = new System.Drawing.Point(87, 377);
            this.buttonScore.Name = "buttonScore";
            this.buttonScore.Size = new System.Drawing.Size(159, 69);
            this.buttonScore.TabIndex = 6;
            this.buttonScore.Text = "Top Scores";
            this.buttonScore.UseVisualStyleBackColor = false;
            this.buttonScore.Click += new System.EventHandler(this.buttonScore_Click);
            // 
            // timerScore
            // 
            this.timerScore.SynchronizingObject = this;
            this.timerScore.Elapsed += new System.Timers.ElapsedEventHandler(this.timerScore_Elapsed);
            // 
            // InitScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonScore);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.labelFace);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonLogin);
            this.Name = "InitScreen";
            this.Text = "InitScreen";
            this.Load += new System.EventHandler(this.InitScreen_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ClosingEvent);
            ((System.ComponentModel.ISupportInitialize) (this.timerSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.timerRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.timerScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Timers.Timer timerScore;

        private System.Windows.Forms.Button buttonScore;

        private System.Windows.Forms.Button buttonQuit;

        private System.Timers.Timer timerSettings;
        private System.Timers.Timer timerRegister;

        private System.Windows.Forms.Button buttonSettings;

        private System.Windows.Forms.Label labelFace;

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;

        private System.Windows.Forms.Button buttonLogin;

        #endregion

    }
}