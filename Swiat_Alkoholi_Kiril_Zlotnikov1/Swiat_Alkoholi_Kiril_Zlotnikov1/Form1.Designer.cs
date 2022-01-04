
namespace Swiat_Alkoholi_Kiril_Zlotnikov1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxForename = new System.Windows.Forms.TextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxLokal = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Tan;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(58, 202);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(195, 45);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Imię";
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxForename
            // 
            this.textBoxForename.BackColor = System.Drawing.Color.Tan;
            this.textBoxForename.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxForename.Location = new System.Drawing.Point(58, 327);
            this.textBoxForename.Name = "textBoxForename";
            this.textBoxForename.Size = new System.Drawing.Size(195, 45);
            this.textBoxForename.TabIndex = 1;
            this.textBoxForename.Text = "Nazwisko";
            this.textBoxForename.TextChanged += new System.EventHandler(this.textBoxForename_TextChanged);
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.BackColor = System.Drawing.Color.Tan;
            this.textBoxAdres.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdres.Location = new System.Drawing.Point(395, 203);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(195, 45);
            this.textBoxAdres.TabIndex = 2;
            this.textBoxAdres.Text = "Adres(nr)";
            this.textBoxAdres.TextChanged += new System.EventHandler(this.textBoxAdres_TextChanged);
            // 
            // textBoxLokal
            // 
            this.textBoxLokal.BackColor = System.Drawing.Color.Tan;
            this.textBoxLokal.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLokal.Location = new System.Drawing.Point(395, 327);
            this.textBoxLokal.Name = "textBoxLokal";
            this.textBoxLokal.Size = new System.Drawing.Size(195, 45);
            this.textBoxLokal.TabIndex = 3;
            this.textBoxLokal.Text = "Nr lokalu";
            this.textBoxLokal.TextChanged += new System.EventHandler(this.textBoxLokal_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePicker1.Location = new System.Drawing.Point(477, 481);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(734, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 416);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(92, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Wyślij zamówienie";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Aqua;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(25, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(314, 140);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(151, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "08:09",
            "09:10",
            "10:11",
            "11:12",
            "12:13",
            "13:14",
            "14:15",
            "15:16",
            "16:17",
            "17:18"});
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Piwo",
            "Wódka",
            "Whiskey",
            "Wino czerwone",
            "Wino białe",
            "Wino różowe",
            "Koniak",
            "Brandy",
            "Likier"});
            this.comboBox1.Location = new System.Drawing.Point(25, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 44);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Wybór produktów";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 83);
            this.label1.TabIndex = 6;
            this.label1.Text = "Świat alkoholi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prosimy o wypełnienie formularza w celu weryfikacji:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1243, 624);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxLokal);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.textBoxForename);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxForename;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxLokal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

