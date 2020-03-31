namespace Example30
{
    partial class Glavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavna));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новКлиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всичкиПродажбиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажбиПоВидToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.търсенеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.времетраенеНаРазговориToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaToolStripMenuItem,
            this.справкиToolStripMenuItem,
            this.отчетиToolStripMenuItem,
            this.изходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nowaToolStripMenuItem
            // 
            this.nowaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новКлиентToolStripMenuItem});
            this.nowaToolStripMenuItem.Name = "nowaToolStripMenuItem";
            this.nowaToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.nowaToolStripMenuItem.Text = "Въвеждане на данни";
            this.nowaToolStripMenuItem.Click += new System.EventHandler(this.nowaToolStripMenuItem_Click);
            // 
            // новКлиентToolStripMenuItem
            // 
            this.новКлиентToolStripMenuItem.Name = "новКлиентToolStripMenuItem";
            this.новКлиентToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.новКлиентToolStripMenuItem.Text = "Нов Клиент";
            this.новКлиентToolStripMenuItem.Click += new System.EventHandler(this.новКлиентToolStripMenuItem_Click);
            // 
            // справкиToolStripMenuItem
            // 
            this.справкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всичкиПродажбиToolStripMenuItem,
            this.продажбиПоВидToolStripMenuItem,
            this.търсенеToolStripMenuItem,
            this.времетраенеНаРазговориToolStripMenuItem});
            this.справкиToolStripMenuItem.Name = "справкиToolStripMenuItem";
            this.справкиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.справкиToolStripMenuItem.Text = "Справки";
            this.справкиToolStripMenuItem.Click += new System.EventHandler(this.справкиToolStripMenuItem_Click);
            // 
            // всичкиПродажбиToolStripMenuItem
            // 
            this.всичкиПродажбиToolStripMenuItem.Name = "всичкиПродажбиToolStripMenuItem";
            this.всичкиПродажбиToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.всичкиПродажбиToolStripMenuItem.Text = "Всички оператори справки";
            this.всичкиПродажбиToolStripMenuItem.Click += new System.EventHandler(this.всичкиПродажбиToolStripMenuItem_Click);
            // 
            // продажбиПоВидToolStripMenuItem
            // 
            this.продажбиПоВидToolStripMenuItem.Name = "продажбиПоВидToolStripMenuItem";
            this.продажбиПоВидToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.продажбиПоВидToolStripMenuItem.Text = "Справки по оператори";
            this.продажбиПоВидToolStripMenuItem.Click += new System.EventHandler(this.продажбиПоВидToolStripMenuItem_Click);
            // 
            // търсенеToolStripMenuItem
            // 
            this.търсенеToolStripMenuItem.Name = "търсенеToolStripMenuItem";
            this.търсенеToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.търсенеToolStripMenuItem.Text = "Търсене на клиент";
            this.търсенеToolStripMenuItem.Click += new System.EventHandler(this.търсенеToolStripMenuItem_Click);
            // 
            // времетраенеНаРазговориToolStripMenuItem
            // 
            this.времетраенеНаРазговориToolStripMenuItem.Name = "времетраенеНаРазговориToolStripMenuItem";
            this.времетраенеНаРазговориToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.времетраенеНаРазговориToolStripMenuItem.Text = "Времетраене на разговори";
            this.времетраенеНаРазговориToolStripMenuItem.Click += new System.EventHandler(this.времетраенеНаРазговориToolStripMenuItem_Click);
            // 
            // отчетиToolStripMenuItem
            // 
            this.отчетиToolStripMenuItem.Name = "отчетиToolStripMenuItem";
            this.отчетиToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.отчетиToolStripMenuItem.Text = "Отчети";
            this.отчетиToolStripMenuItem.Click += new System.EventHandler(this.отчетиToolStripMenuItem_Click);
            // 
            // изходToolStripMenuItem
            // 
            this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            this.изходToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.изходToolStripMenuItem.Text = "Изход";
            this.изходToolStripMenuItem.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 432);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(929, 551);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Glavna";
            this.Text = "Мобилни оператори";
            this.Load += new System.EventHandler(this.Glavna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всичкиПродажбиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажбиПоВидToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem новКлиентToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem търсенеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem времетраенеНаРазговориToolStripMenuItem;
    }
}

