namespace PR6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lb_entertainmentbar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pB_drink1 = new System.Windows.Forms.PictureBox();
            this.pB_drink3 = new System.Windows.Forms.PictureBox();
            this.pB_drink2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_drink1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_drink3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_drink2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar1.Location = new System.Drawing.Point(247, 74);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(320, 42);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.UseWaitCursor = true;
            // 
            // lb_entertainmentbar
            // 
            this.lb_entertainmentbar.AutoSize = true;
            this.lb_entertainmentbar.BackColor = System.Drawing.Color.Transparent;
            this.lb_entertainmentbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_entertainmentbar.Location = new System.Drawing.Point(318, 47);
            this.lb_entertainmentbar.Name = "lb_entertainmentbar";
            this.lb_entertainmentbar.Size = new System.Drawing.Size(196, 24);
            this.lb_entertainmentbar.TabIndex = 4;
            this.lb_entertainmentbar.Text = "Настроение клиента";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Покинуть бар";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Деньги";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PR6.Properties.Resources.Money_PNG_Transparent_Image;
            this.pictureBox2.Location = new System.Drawing.Point(24, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pB_drink1
            // 
            this.pB_drink1.BackColor = System.Drawing.Color.Transparent;
            this.pB_drink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pB_drink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pB_drink1.Image = global::PR6.Properties.Resources._1673025390_grizly_club_p_tekstura_viski_24;
            this.pB_drink1.Location = new System.Drawing.Point(91, 309);
            this.pB_drink1.Name = "pB_drink1";
            this.pB_drink1.Size = new System.Drawing.Size(46, 51);
            this.pB_drink1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_drink1.TabIndex = 7;
            this.pB_drink1.TabStop = false;
            this.pB_drink1.Click += new System.EventHandler(this.pB_drink1_Click);
            // 
            // pB_drink3
            // 
            this.pB_drink3.BackColor = System.Drawing.Color.Transparent;
            this.pB_drink3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pB_drink3.Image = global::PR6.Properties.Resources._18_glass_png_image;
            this.pB_drink3.Location = new System.Drawing.Point(276, 274);
            this.pB_drink3.Name = "pB_drink3";
            this.pB_drink3.Size = new System.Drawing.Size(56, 84);
            this.pB_drink3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_drink3.TabIndex = 9;
            this.pB_drink3.TabStop = false;
            this.pB_drink3.Click += new System.EventHandler(this.pB_drink3_Click);
            // 
            // pB_drink2
            // 
            this.pB_drink2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pB_drink2.BackColor = System.Drawing.Color.Transparent;
            this.pB_drink2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pB_drink2.Image = global::PR6.Properties.Resources._1182043;
            this.pB_drink2.Location = new System.Drawing.Point(181, 276);
            this.pB_drink2.Name = "pB_drink2";
            this.pB_drink2.Size = new System.Drawing.Size(48, 86);
            this.pB_drink2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_drink2.TabIndex = 8;
            this.pB_drink2.TabStop = false;
            this.pB_drink2.Click += new System.EventHandler(this.pB_drink2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PR6.Properties.Resources._2009095;
            this.pictureBox1.Location = new System.Drawing.Point(-184, 274);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(698, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::PR6.Properties.Resources._910_9108890_mor2hu_morshu_zelda;
            this.pictureBox3.Location = new System.Drawing.Point(520, 179);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(383, 420);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PR6.Properties.Resources._1671663122_kalix_club_p_brevenchataya_stena_fon_instagram_59;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 563);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pB_drink1);
            this.Controls.Add(this.pB_drink3);
            this.Controls.Add(this.pB_drink2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_entertainmentbar);
            this.Controls.Add(this.progressBar1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Мишка под шишкой";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_drink1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_drink3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_drink2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lb_entertainmentbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pB_drink3;
        private System.Windows.Forms.PictureBox pB_drink2;
        private System.Windows.Forms.PictureBox pB_drink1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

