using System.ComponentModel;

namespace MemoryGame
{
    partial class SettingsScreen
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
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelInitVisib = new System.Windows.Forms.Label();
            this.labelVisib = new System.Windows.Forms.Label();
            this.buttonPlusLevel = new System.Windows.Forms.Button();
            this.buttonMinusLevel = new System.Windows.Forms.Button();
            this.buttonMinusInitVisib = new System.Windows.Forms.Button();
            this.buttonPlusInitVisib = new System.Windows.Forms.Button();
            this.buttonMinusVisib = new System.Windows.Forms.Button();
            this.buttonPlusVisib = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonQuit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonQuit.Location = new System.Drawing.Point(188, 310);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(204, 48);
            this.buttonQuit.TabIndex = 10;
            this.buttonQuit.Text = "QUIT";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonApply.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonApply.Location = new System.Drawing.Point(398, 310);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(204, 48);
            this.buttonApply.TabIndex = 11;
            this.buttonApply.Text = "APPLY";
            this.buttonApply.UseVisualStyleBackColor = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // labelLevel
            // 
            this.labelLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLevel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelLevel.Location = new System.Drawing.Point(212, 161);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(364, 38);
            this.labelLevel.TabIndex = 12;
            this.labelLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInitVisib
            // 
            this.labelInitVisib.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInitVisib.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelInitVisib.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelInitVisib.Location = new System.Drawing.Point(212, 209);
            this.labelInitVisib.Name = "labelInitVisib";
            this.labelInitVisib.Size = new System.Drawing.Size(364, 38);
            this.labelInitVisib.TabIndex = 13;
            this.labelInitVisib.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVisib
            // 
            this.labelVisib.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVisib.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelVisib.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.labelVisib.Location = new System.Drawing.Point(212, 257);
            this.labelVisib.Name = "labelVisib";
            this.labelVisib.Size = new System.Drawing.Size(364, 38);
            this.labelVisib.TabIndex = 14;
            this.labelVisib.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlusLevel
            // 
            this.buttonPlusLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlusLevel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonPlusLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonPlusLevel.Location = new System.Drawing.Point(582, 168);
            this.buttonPlusLevel.Name = "buttonPlusLevel";
            this.buttonPlusLevel.Size = new System.Drawing.Size(20, 19);
            this.buttonPlusLevel.TabIndex = 16;
            this.buttonPlusLevel.UseVisualStyleBackColor = false;
            this.buttonPlusLevel.Click += new System.EventHandler(this.buttonPlusLevel_Click);
            // 
            // buttonMinusLevel
            // 
            this.buttonMinusLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMinusLevel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonMinusLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonMinusLevel.Location = new System.Drawing.Point(188, 168);
            this.buttonMinusLevel.Name = "buttonMinusLevel";
            this.buttonMinusLevel.Size = new System.Drawing.Size(18, 19);
            this.buttonMinusLevel.TabIndex = 17;
            this.buttonMinusLevel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinusLevel.UseVisualStyleBackColor = false;
            this.buttonMinusLevel.Click += new System.EventHandler(this.buttonMinusLevel_Click);
            // 
            // buttonMinusInitVisib
            // 
            this.buttonMinusInitVisib.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMinusInitVisib.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonMinusInitVisib.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonMinusInitVisib.Location = new System.Drawing.Point(188, 216);
            this.buttonMinusInitVisib.Name = "buttonMinusInitVisib";
            this.buttonMinusInitVisib.Size = new System.Drawing.Size(18, 19);
            this.buttonMinusInitVisib.TabIndex = 19;
            this.buttonMinusInitVisib.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinusInitVisib.UseVisualStyleBackColor = false;
            this.buttonMinusInitVisib.Click += new System.EventHandler(this.buttonMinusInitVisib_Click);
            // 
            // buttonPlusInitVisib
            // 
            this.buttonPlusInitVisib.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlusInitVisib.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonPlusInitVisib.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonPlusInitVisib.Location = new System.Drawing.Point(582, 216);
            this.buttonPlusInitVisib.Name = "buttonPlusInitVisib";
            this.buttonPlusInitVisib.Size = new System.Drawing.Size(20, 19);
            this.buttonPlusInitVisib.TabIndex = 18;
            this.buttonPlusInitVisib.UseVisualStyleBackColor = false;
            this.buttonPlusInitVisib.Click += new System.EventHandler(this.buttonPlusInitVisib_Click);
            // 
            // buttonMinusVisib
            // 
            this.buttonMinusVisib.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMinusVisib.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonMinusVisib.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonMinusVisib.Location = new System.Drawing.Point(188, 264);
            this.buttonMinusVisib.Name = "buttonMinusVisib";
            this.buttonMinusVisib.Size = new System.Drawing.Size(18, 19);
            this.buttonMinusVisib.TabIndex = 21;
            this.buttonMinusVisib.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinusVisib.UseVisualStyleBackColor = false;
            this.buttonMinusVisib.Click += new System.EventHandler(this.buttonMinusVisib_Click);
            // 
            // buttonPlusVisib
            // 
            this.buttonPlusVisib.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlusVisib.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonPlusVisib.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.buttonPlusVisib.Location = new System.Drawing.Point(582, 264);
            this.buttonPlusVisib.Name = "buttonPlusVisib";
            this.buttonPlusVisib.Size = new System.Drawing.Size(20, 19);
            this.buttonPlusVisib.TabIndex = 20;
            this.buttonPlusVisib.UseVisualStyleBackColor = false;
            this.buttonPlusVisib.Click += new System.EventHandler(this.buttonPlusVisib_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(82, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "LEVEL";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(82, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "SHOW TIME";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(82, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "VISIBILITY";
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMinusVisib);
            this.Controls.Add(this.buttonPlusVisib);
            this.Controls.Add(this.buttonMinusInitVisib);
            this.Controls.Add(this.buttonPlusInitVisib);
            this.Controls.Add(this.buttonMinusLevel);
            this.Controls.Add(this.buttonPlusLevel);
            this.Controls.Add(this.labelVisib);
            this.Controls.Add(this.labelInitVisib);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonQuit);
            this.Name = "SettingsScreen";
            this.Text = "SettingsScreen";
            this.Load += new System.EventHandler(this.SettingsScreen_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button buttonMinusInitVisib;
        private System.Windows.Forms.Button buttonPlusInitVisib;
        private System.Windows.Forms.Button buttonMinusVisib;
        private System.Windows.Forms.Button buttonPlusVisib;

        private System.Windows.Forms.Button buttonMinusLevel;

        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelInitVisib;
        private System.Windows.Forms.Label labelVisib;
        private System.Windows.Forms.Button buttonPlusLevel;

        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonApply;

        #endregion

    }
}