namespace DictApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelWord = new System.Windows.Forms.Label();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonAgain = new System.Windows.Forms.Button();
            this.checkBoxRevealWord = new System.Windows.Forms.CheckBox();
            this.axMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWord
            // 
            this.labelWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWord.BackColor = System.Drawing.Color.Gray;
            this.labelWord.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWord.ForeColor = System.Drawing.Color.White;
            this.labelWord.Location = new System.Drawing.Point(12, 9);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(616, 204);
            this.labelWord.TabIndex = 0;
            this.labelWord.Text = "Example";
            this.labelWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPrev.Location = new System.Drawing.Point(12, 226);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 1;
            this.buttonPrev.Text = "Prev";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNext.Location = new System.Drawing.Point(93, 226);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonAgain
            // 
            this.buttonAgain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAgain.Location = new System.Drawing.Point(174, 226);
            this.buttonAgain.Name = "buttonAgain";
            this.buttonAgain.Size = new System.Drawing.Size(75, 23);
            this.buttonAgain.TabIndex = 3;
            this.buttonAgain.Text = "Again";
            this.buttonAgain.UseVisualStyleBackColor = true;
            this.buttonAgain.Click += new System.EventHandler(this.buttonAgain_Click);
            // 
            // checkBoxRevealWord
            // 
            this.checkBoxRevealWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxRevealWord.AutoSize = true;
            this.checkBoxRevealWord.Location = new System.Drawing.Point(255, 230);
            this.checkBoxRevealWord.Name = "checkBoxRevealWord";
            this.checkBoxRevealWord.Size = new System.Drawing.Size(88, 17);
            this.checkBoxRevealWord.TabIndex = 4;
            this.checkBoxRevealWord.Text = "Reveal Word";
            this.checkBoxRevealWord.UseVisualStyleBackColor = true;
            this.checkBoxRevealWord.CheckedChanged += new System.EventHandler(this.checkBoxRevealWord_CheckedChanged);
            // 
            // axMediaPlayer
            // 
            this.axMediaPlayer.Enabled = true;
            this.axMediaPlayer.Location = new System.Drawing.Point(553, 226);
            this.axMediaPlayer.Name = "axMediaPlayer";
            this.axMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMediaPlayer.OcxState")));
            this.axMediaPlayer.Size = new System.Drawing.Size(75, 23);
            this.axMediaPlayer.TabIndex = 5;
            this.axMediaPlayer.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 261);
            this.Controls.Add(this.axMediaPlayer);
            this.Controls.Add(this.checkBoxRevealWord);
            this.Controls.Add(this.buttonAgain);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.labelWord);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Dictation";
            ((System.ComponentModel.ISupportInitialize)(this.axMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonAgain;
        private System.Windows.Forms.CheckBox checkBoxRevealWord;
        private AxWMPLib.AxWindowsMediaPlayer axMediaPlayer;
    }
}

