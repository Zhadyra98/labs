namespace game_project
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
            this.components = new System.ComponentModel.Container();
            this.rocket = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rockets = new System.Windows.Forms.PictureBox();
            this.Square = new System.Windows.Forms.PictureBox();
            this.Score_label = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square)).BeginInit();
            this.SuspendLayout();
            // 
            // rocket
            // 
            this.rocket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rocket.Location = new System.Drawing.Point(186, 375);
            this.rocket.Name = "rocket";
            this.rocket.Size = new System.Drawing.Size(179, 22);
            this.rocket.TabIndex = 0;
            this.rocket.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Yellow;
            this.ball.Location = new System.Drawing.Point(277, 274);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(34, 29);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 440);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // rockets
            // 
            this.rockets.BackColor = System.Drawing.Color.LawnGreen;
            this.rockets.Location = new System.Drawing.Point(100, 301);
            this.rockets.Name = "rockets";
            this.rockets.Size = new System.Drawing.Size(211, 23);
            this.rockets.TabIndex = 3;
            this.rockets.TabStop = false;
            // 
            // Square
            // 
            this.Square.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Square.Location = new System.Drawing.Point(250, 197);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(34, 32);
            this.Square.TabIndex = 4;
            this.Square.TabStop = false;
            // 
            // Score_label
            // 
            this.Score_label.AutoSize = true;
            this.Score_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score_label.Location = new System.Drawing.Point(23, 171);
            this.Score_label.Name = "Score_label";
            this.Score_label.Size = new System.Drawing.Size(83, 23);
            this.Score_label.TabIndex = 5;
            this.Score_label.Text = "SCORE:";
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.points.Location = new System.Drawing.Point(112, 171);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(21, 23);
            this.points.TabIndex = 6;
            this.points.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(253, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Game over";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.points);
            this.Controls.Add(this.Score_label);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.rockets);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.rocket);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Square)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rocket;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox rockets;
        private System.Windows.Forms.PictureBox Square;
        private System.Windows.Forms.Label Score_label;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label label1;
    }
}

