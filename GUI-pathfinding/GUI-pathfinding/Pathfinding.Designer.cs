namespace GUI_pathfinding
{
    partial class Pathfinding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pathfinding));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbHighscores = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btForward = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.btBackward = new System.Windows.Forms.Button();
            this.btLeft = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lTijd = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbHighscores);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 841);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Highscore";
            // 
            // lbHighscores
            // 
            this.lbHighscores.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHighscores.FormattingEnabled = true;
            this.lbHighscores.ItemHeight = 69;
            this.lbHighscores.Location = new System.Drawing.Point(170, 111);
            this.lbHighscores.Name = "lbHighscores";
            this.lbHighscores.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbHighscores.Size = new System.Drawing.Size(365, 694);
            this.lbHighscores.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btForward);
            this.groupBox2.Controls.Add(this.btRight);
            this.groupBox2.Controls.Add(this.btBackward);
            this.groupBox2.Controls.Add(this.btLeft);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(738, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1179, 1041);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Besturing";
            // 
            // btForward
            // 
            this.btForward.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btForward.ForeColor = System.Drawing.Color.Black;
            this.btForward.Location = new System.Drawing.Point(473, 112);
            this.btForward.Name = "btForward";
            this.btForward.Size = new System.Drawing.Size(209, 143);
            this.btForward.TabIndex = 6;
            this.btForward.Text = "/\\";
            this.btForward.UseVisualStyleBackColor = true;
            this.btForward.Click += new System.EventHandler(this.btForward_Click);
            // 
            // btRight
            // 
            this.btRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRight.ForeColor = System.Drawing.Color.Black;
            this.btRight.Location = new System.Drawing.Point(927, 475);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(209, 143);
            this.btRight.TabIndex = 5;
            this.btRight.Text = ">";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            // 
            // btBackward
            // 
            this.btBackward.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackward.ForeColor = System.Drawing.Color.Black;
            this.btBackward.Location = new System.Drawing.Point(473, 848);
            this.btBackward.Name = "btBackward";
            this.btBackward.Size = new System.Drawing.Size(209, 143);
            this.btBackward.TabIndex = 4;
            this.btBackward.Text = "\\/";
            this.btBackward.UseVisualStyleBackColor = true;
            this.btBackward.Click += new System.EventHandler(this.btBackward_Click);
            // 
            // btLeft
            // 
            this.btLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLeft.ForeColor = System.Drawing.Color.Black;
            this.btLeft.Location = new System.Drawing.Point(38, 475);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(209, 143);
            this.btLeft.TabIndex = 1;
            this.btLeft.Text = "<";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lTijd);
            this.groupBox3.Controls.Add(this.btReset);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(13, 860);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(713, 193);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timer";
            // 
            // lTijd
            // 
            this.lTijd.AutoSize = true;
            this.lTijd.Location = new System.Drawing.Point(313, 87);
            this.lTijd.Name = "lTijd";
            this.lTijd.Size = new System.Drawing.Size(340, 91);
            this.lTijd.TabIndex = 1;
            this.lTijd.Text = "Tijd:  0:0";
            // 
            // btReset
            // 
            this.btReset.ForeColor = System.Drawing.Color.Black;
            this.btReset.Location = new System.Drawing.Point(15, 87);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(292, 91);
            this.btReset.TabIndex = 0;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pathfinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pathfinding";
            this.Text = "Pathfinding";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btForward;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btBackward;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lTijd;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lbHighscores;
    }
}

