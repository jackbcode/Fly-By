namespace flappyBird
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            this.endText1 = new System.Windows.Forms.Label();
            this.endText2 = new System.Windows.Forms.Label();
            this.gameDesigner = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tree = new System.Windows.Forms.PictureBox();
            this.cactus = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.dragon = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.thunder = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thunder)).BeginInit();
            this.SuspendLayout();
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 15;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // scoreText
            // 
            this.scoreText.AccessibleName = "scoreText";
            this.scoreText.AutoSize = true;
            this.scoreText.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.scoreText.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.Color.Red;
            this.scoreText.Location = new System.Drawing.Point(491, 13);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(84, 28);
            this.scoreText.TabIndex = 5;
            this.scoreText.Text = "label1";
            // 
            // endText1
            // 
            this.endText1.AccessibleName = "endText1";
            this.endText1.AutoSize = true;
            this.endText1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endText1.ForeColor = System.Drawing.Color.Red;
            this.endText1.Location = new System.Drawing.Point(205, 171);
            this.endText1.Name = "endText1";
            this.endText1.Size = new System.Drawing.Size(107, 37);
            this.endText1.TabIndex = 6;
            this.endText1.Text = "label2";
            // 
            // endText2
            // 
            this.endText2.AccessibleName = "endText2";
            this.endText2.AutoSize = true;
            this.endText2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endText2.ForeColor = System.Drawing.Color.Red;
            this.endText2.Location = new System.Drawing.Point(265, 12);
            this.endText2.Name = "endText2";
            this.endText2.Size = new System.Drawing.Size(84, 28);
            this.endText2.TabIndex = 7;
            this.endText2.Text = "label3";
            // 
            // gameDesigner
            // 
            this.gameDesigner.AccessibleName = "gameDesigner";
            this.gameDesigner.AutoSize = true;
            this.gameDesigner.BackColor = System.Drawing.Color.PeachPuff;
            this.gameDesigner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameDesigner.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameDesigner.Location = new System.Drawing.Point(68, 665);
            this.gameDesigner.Name = "gameDesigner";
            this.gameDesigner.Size = new System.Drawing.Size(53, 19);
            this.gameDesigner.TabIndex = 8;
            this.gameDesigner.Text = "label4";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(228, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Play Again";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tree
            // 
            this.tree.BackColor = System.Drawing.Color.Transparent;
            this.tree.Image = ((System.Drawing.Image)(resources.GetObject("tree.Image")));
            this.tree.Location = new System.Drawing.Point(28, 441);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(153, 209);
            this.tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree.TabIndex = 10;
            this.tree.TabStop = false;
            // 
            // cactus
            // 
            this.cactus.BackColor = System.Drawing.Color.Transparent;
            this.cactus.Image = ((System.Drawing.Image)(resources.GetObject("cactus.Image")));
            this.cactus.Location = new System.Drawing.Point(412, 367);
            this.cactus.Name = "cactus";
            this.cactus.Size = new System.Drawing.Size(163, 309);
            this.cactus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cactus.TabIndex = 9;
            this.cactus.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.Image = ((System.Drawing.Image)(resources.GetObject("pipeTop.Image")));
            this.pipeTop.Location = new System.Drawing.Point(174, -11);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(100, 157);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 4;
            this.pipeTop.TabStop = false;
            // 
            // dragon
            // 
            this.dragon.AccessibleName = "dragon";
            this.dragon.BackColor = System.Drawing.Color.Transparent;
            this.dragon.Image = ((System.Drawing.Image)(resources.GetObject("dragon.Image")));
            this.dragon.Location = new System.Drawing.Point(315, 43);
            this.dragon.Name = "dragon";
            this.dragon.Size = new System.Drawing.Size(118, 84);
            this.dragon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dragon.TabIndex = 3;
            this.dragon.TabStop = false;
            this.dragon.Click += new System.EventHandler(this.dragon_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.AccessibleName = "pipeTop";
            this.pictureBox3.Location = new System.Drawing.Point(274, -193);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // ground
            // 
            this.ground.AccessibleName = "ground";
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-143, 641);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(917, 65);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // thunder
            // 
            this.thunder.BackColor = System.Drawing.Color.Transparent;
            this.thunder.Image = ((System.Drawing.Image)(resources.GetObject("thunder.Image")));
            this.thunder.Location = new System.Drawing.Point(200, 298);
            this.thunder.Name = "thunder";
            this.thunder.Size = new System.Drawing.Size(158, 114);
            this.thunder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thunder.TabIndex = 12;
            this.thunder.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 665);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(587, 693);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.endText1);
            this.Controls.Add(this.gameDesigner);
            this.Controls.Add(this.endText2);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.dragon);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.thunder);
            this.Controls.Add(this.cactus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "  ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thunder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox dragon;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label endText1;
        private System.Windows.Forms.Label endText2;
        private System.Windows.Forms.Label gameDesigner;
        private System.Windows.Forms.PictureBox cactus;
        private System.Windows.Forms.PictureBox tree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox thunder;
        private System.Windows.Forms.Label label1;
    }
}

