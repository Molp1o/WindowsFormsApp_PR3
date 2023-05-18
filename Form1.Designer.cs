namespace WindowsFormsApp_PR3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list_lbl = new System.Windows.Forms.Label();
            this.create_btn = new System.Windows.Forms.Button();
            this.el_amnt_tb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mst_cmn_key_lbl = new System.Windows.Forms.Label();
            this.mst_cmn_lbl = new System.Windows.Forms.Label();
            this.mst_cmn_tb = new System.Windows.Forms.TextBox();
            this.mst_cmn_btn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.list_lbl);
            this.groupBox1.Controls.Add(this.create_btn);
            this.groupBox1.Controls.Add(this.el_amnt_tb);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание последовательности";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(101, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Введите кол-во элементов последовательности:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(169, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ваша последовательность:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "СОЗДАНИЕ ПОСЛЕДОВАТЕЛЬНОСТИ";
            // 
            // list_lbl
            // 
            this.list_lbl.AutoSize = true;
            this.list_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.list_lbl.Location = new System.Drawing.Point(118, 86);
            this.list_lbl.Name = "list_lbl";
            this.list_lbl.Size = new System.Drawing.Size(294, 16);
            this.list_lbl.TabIndex = 2;
            this.list_lbl.Text = "(Здесь появится ваша последовательность)";
            this.list_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.list_lbl.Click += new System.EventHandler(this.list_lbl_Click);
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(475, 166);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(75, 23);
            this.create_btn.TabIndex = 1;
            this.create_btn.Text = "Создать";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // el_amnt_tb
            // 
            this.el_amnt_tb.Location = new System.Drawing.Point(206, 166);
            this.el_amnt_tb.Name = "el_amnt_tb";
            this.el_amnt_tb.Size = new System.Drawing.Size(100, 20);
            this.el_amnt_tb.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mst_cmn_key_lbl);
            this.groupBox2.Controls.Add(this.mst_cmn_lbl);
            this.groupBox2.Controls.Add(this.mst_cmn_tb);
            this.groupBox2.Controls.Add(this.mst_cmn_btn);
            this.groupBox2.Location = new System.Drawing.Point(12, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 220);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(121, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Введите кол-во выводимых элементов:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Повторяющиеся числа:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество повторений:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "ВЫВОД ПОВТОРЯЮЩИХСЯ ЗНАЧЕНИЙ";
            // 
            // mst_cmn_key_lbl
            // 
            this.mst_cmn_key_lbl.AutoSize = true;
            this.mst_cmn_key_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mst_cmn_key_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.mst_cmn_key_lbl.Location = new System.Drawing.Point(183, 46);
            this.mst_cmn_key_lbl.Name = "mst_cmn_key_lbl";
            this.mst_cmn_key_lbl.Size = new System.Drawing.Size(356, 16);
            this.mst_cmn_key_lbl.TabIndex = 3;
            this.mst_cmn_key_lbl.Text = "(Здесь будут выведины числа, которые повторяются)";
            this.mst_cmn_key_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mst_cmn_lbl
            // 
            this.mst_cmn_lbl.AutoSize = true;
            this.mst_cmn_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mst_cmn_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.mst_cmn_lbl.Location = new System.Drawing.Point(183, 73);
            this.mst_cmn_lbl.Name = "mst_cmn_lbl";
            this.mst_cmn_lbl.Size = new System.Drawing.Size(292, 16);
            this.mst_cmn_lbl.TabIndex = 2;
            this.mst_cmn_lbl.Text = "(Здесь будет выведено кол-во повторений)";
            this.mst_cmn_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mst_cmn_tb
            // 
            this.mst_cmn_tb.Location = new System.Drawing.Point(206, 180);
            this.mst_cmn_tb.Name = "mst_cmn_tb";
            this.mst_cmn_tb.Size = new System.Drawing.Size(100, 20);
            this.mst_cmn_tb.TabIndex = 1;
            // 
            // mst_cmn_btn
            // 
            this.mst_cmn_btn.Location = new System.Drawing.Point(475, 180);
            this.mst_cmn_btn.Name = "mst_cmn_btn";
            this.mst_cmn_btn.Size = new System.Drawing.Size(75, 23);
            this.mst_cmn_btn.TabIndex = 0;
            this.mst_cmn_btn.Text = "Показать";
            this.mst_cmn_btn.UseVisualStyleBackColor = true;
            this.mst_cmn_btn.Click += new System.EventHandler(this.mst_cmn_btn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(602, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click_1);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(888, 518);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(904, 557);
            this.MinimumSize = new System.Drawing.Size(904, 557);
            this.Name = "Form1";
            this.Text = "Последовательность";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.TextBox el_amnt_tb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox mst_cmn_tb;
        private System.Windows.Forms.Button mst_cmn_btn;
        private System.Windows.Forms.Label mst_cmn_lbl;
        private System.Windows.Forms.Label list_lbl;
        private System.Windows.Forms.Label mst_cmn_key_lbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

