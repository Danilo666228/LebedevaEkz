namespace PaymentOrder
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
            this.ButtonCancel = new System.Windows.Forms.Panel();
            this.TextSuccessfullyPayment = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.ComboBoxBankRecipient = new System.Windows.Forms.ComboBox();
            this.ComboBoxBankPerson = new System.Windows.Forms.ComboBox();
            this.TextBoxCheckRecipient = new System.Windows.Forms.TextBox();
            this.TextBoxINN = new System.Windows.Forms.TextBox();
            this.TextBoxBIK = new System.Windows.Forms.TextBox();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.TextBoxPerson = new System.Windows.Forms.TextBox();
            this.TextCheckRecipient = new System.Windows.Forms.Label();
            this.TextBankRecipient = new System.Windows.Forms.Label();
            this.TextINN = new System.Windows.Forms.Label();
            this.TextBIK = new System.Windows.Forms.Label();
            this.TextBankPerson = new System.Windows.Forms.Label();
            this.TextPrice = new System.Windows.Forms.Label();
            this.TextPerson = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxNumberPayment = new System.Windows.Forms.TextBox();
            this.TextBoxDate = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextPayment = new System.Windows.Forms.TextBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonCancel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Controls.Add(this.ButtonDelete);
            this.ButtonCancel.Controls.Add(this.TextSuccessfullyPayment);
            this.ButtonCancel.Controls.Add(this.button2);
            this.ButtonCancel.Controls.Add(this.ButtonSend);
            this.ButtonCancel.Controls.Add(this.ComboBoxBankRecipient);
            this.ButtonCancel.Controls.Add(this.ComboBoxBankPerson);
            this.ButtonCancel.Controls.Add(this.TextBoxCheckRecipient);
            this.ButtonCancel.Controls.Add(this.TextBoxINN);
            this.ButtonCancel.Controls.Add(this.TextBoxBIK);
            this.ButtonCancel.Controls.Add(this.TextBoxPrice);
            this.ButtonCancel.Controls.Add(this.TextBoxPerson);
            this.ButtonCancel.Controls.Add(this.TextCheckRecipient);
            this.ButtonCancel.Controls.Add(this.TextBankRecipient);
            this.ButtonCancel.Controls.Add(this.TextINN);
            this.ButtonCancel.Controls.Add(this.TextBIK);
            this.ButtonCancel.Controls.Add(this.TextBankPerson);
            this.ButtonCancel.Controls.Add(this.TextPrice);
            this.ButtonCancel.Controls.Add(this.TextPerson);
            this.ButtonCancel.Controls.Add(this.panel3);
            this.ButtonCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonCancel.Location = new System.Drawing.Point(0, 0);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(450, 554);
            this.ButtonCancel.TabIndex = 0;
            // 
            // TextSuccessfullyPayment
            // 
            this.TextSuccessfullyPayment.AutoSize = true;
            this.TextSuccessfullyPayment.Location = new System.Drawing.Point(65, 529);
            this.TextSuccessfullyPayment.Name = "TextSuccessfullyPayment";
            this.TextSuccessfullyPayment.Size = new System.Drawing.Size(0, 16);
            this.TextSuccessfullyPayment.TabIndex = 5;
            this.TextSuccessfullyPayment.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(68, 482);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(75, 23);
            this.ButtonSend.TabIndex = 4;
            this.ButtonSend.Text = "Отправить";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // ComboBoxBankRecipient
            // 
            this.ComboBoxBankRecipient.FormattingEnabled = true;
            this.ComboBoxBankRecipient.Items.AddRange(new object[] {
            "ПАО «Лучший банк»",
            "ПАО «Главный банк»",
            "ПАО «Замечательный банк»"});
            this.ComboBoxBankRecipient.Location = new System.Drawing.Point(169, 247);
            this.ComboBoxBankRecipient.Name = "ComboBoxBankRecipient";
            this.ComboBoxBankRecipient.Size = new System.Drawing.Size(243, 24);
            this.ComboBoxBankRecipient.TabIndex = 3;
            // 
            // ComboBoxBankPerson
            // 
            this.ComboBoxBankPerson.FormattingEnabled = true;
            this.ComboBoxBankPerson.Items.AddRange(new object[] {
            "ПАО «Лучший банк»",
            "ПАО «Главный банк»",
            "ПАО «Замечательный банк»"});
            this.ComboBoxBankPerson.Location = new System.Drawing.Point(169, 150);
            this.ComboBoxBankPerson.Name = "ComboBoxBankPerson";
            this.ComboBoxBankPerson.Size = new System.Drawing.Size(243, 24);
            this.ComboBoxBankPerson.TabIndex = 3;
            // 
            // TextBoxCheckRecipient
            // 
            this.TextBoxCheckRecipient.Location = new System.Drawing.Point(169, 285);
            this.TextBoxCheckRecipient.Name = "TextBoxCheckRecipient";
            this.TextBoxCheckRecipient.Size = new System.Drawing.Size(243, 22);
            this.TextBoxCheckRecipient.TabIndex = 2;
            // 
            // TextBoxINN
            // 
            this.TextBoxINN.Location = new System.Drawing.Point(169, 211);
            this.TextBoxINN.Name = "TextBoxINN";
            this.TextBoxINN.Size = new System.Drawing.Size(243, 22);
            this.TextBoxINN.TabIndex = 2;
            // 
            // TextBoxBIK
            // 
            this.TextBoxBIK.Location = new System.Drawing.Point(169, 178);
            this.TextBoxBIK.Name = "TextBoxBIK";
            this.TextBoxBIK.Size = new System.Drawing.Size(243, 22);
            this.TextBoxBIK.TabIndex = 2;
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Location = new System.Drawing.Point(169, 116);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(243, 22);
            this.TextBoxPrice.TabIndex = 2;
            // 
            // TextBoxPerson
            // 
            this.TextBoxPerson.Location = new System.Drawing.Point(169, 90);
            this.TextBoxPerson.Name = "TextBoxPerson";
            this.TextBoxPerson.Size = new System.Drawing.Size(243, 22);
            this.TextBoxPerson.TabIndex = 2;
            // 
            // TextCheckRecipient
            // 
            this.TextCheckRecipient.AutoSize = true;
            this.TextCheckRecipient.Location = new System.Drawing.Point(29, 288);
            this.TextCheckRecipient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextCheckRecipient.Name = "TextCheckRecipient";
            this.TextCheckRecipient.Size = new System.Drawing.Size(111, 16);
            this.TextCheckRecipient.TabIndex = 1;
            this.TextCheckRecipient.Text = "Счёт получателя";
            // 
            // TextBankRecipient
            // 
            this.TextBankRecipient.AutoSize = true;
            this.TextBankRecipient.Location = new System.Drawing.Point(33, 250);
            this.TextBankRecipient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextBankRecipient.Name = "TextBankRecipient";
            this.TextBankRecipient.Size = new System.Drawing.Size(110, 16);
            this.TextBankRecipient.TabIndex = 1;
            this.TextBankRecipient.Text = "Банк получателя";
            // 
            // TextINN
            // 
            this.TextINN.AutoSize = true;
            this.TextINN.Location = new System.Drawing.Point(33, 214);
            this.TextINN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextINN.Name = "TextINN";
            this.TextINN.Size = new System.Drawing.Size(31, 16);
            this.TextINN.TabIndex = 1;
            this.TextINN.Text = "ИНН";
            // 
            // TextBIK
            // 
            this.TextBIK.AutoSize = true;
            this.TextBIK.Location = new System.Drawing.Point(33, 181);
            this.TextBIK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextBIK.Name = "TextBIK";
            this.TextBIK.Size = new System.Drawing.Size(29, 16);
            this.TextBIK.TabIndex = 1;
            this.TextBIK.Text = "БИК";
            // 
            // TextBankPerson
            // 
            this.TextBankPerson.AutoSize = true;
            this.TextBankPerson.Location = new System.Drawing.Point(33, 150);
            this.TextBankPerson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextBankPerson.Name = "TextBankPerson";
            this.TextBankPerson.Size = new System.Drawing.Size(121, 16);
            this.TextBankPerson.TabIndex = 1;
            this.TextBankPerson.Text = "Банк плательщика";
            // 
            // TextPrice
            // 
            this.TextPrice.AutoSize = true;
            this.TextPrice.Location = new System.Drawing.Point(33, 119);
            this.TextPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextPrice.Name = "TextPrice";
            this.TextPrice.Size = new System.Drawing.Size(49, 16);
            this.TextPrice.TabIndex = 1;
            this.TextPrice.Text = "Cумма";
            // 
            // TextPerson
            // 
            this.TextPerson.AutoSize = true;
            this.TextPerson.Location = new System.Drawing.Point(33, 90);
            this.TextPerson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextPerson.Name = "TextPerson";
            this.TextPerson.Size = new System.Drawing.Size(82, 16);
            this.TextPerson.TabIndex = 1;
            this.TextPerson.Text = "Плательщик";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.TextBoxNumberPayment);
            this.panel3.Controls.Add(this.TextBoxDate);
            this.panel3.Location = new System.Drawing.Point(36, 338);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 123);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата";
            // 
            // TextBoxNumberPayment
            // 
            this.TextBoxNumberPayment.Location = new System.Drawing.Point(110, 79);
            this.TextBoxNumberPayment.Name = "TextBoxNumberPayment";
            this.TextBoxNumberPayment.ReadOnly = true;
            this.TextBoxNumberPayment.Size = new System.Drawing.Size(243, 22);
            this.TextBoxNumberPayment.TabIndex = 2;
            this.TextBoxNumberPayment.TextChanged += new System.EventHandler(this.TextBoxNumberPayment_TextChanged);
            // 
            // TextBoxDate
            // 
            this.TextBoxDate.Location = new System.Drawing.Point(110, 20);
            this.TextBoxDate.Name = "TextBoxDate";
            this.TextBoxDate.ReadOnly = true;
            this.TextBoxDate.Size = new System.Drawing.Size(243, 22);
            this.TextBoxDate.TabIndex = 2;
            this.TextBoxDate.TextChanged += new System.EventHandler(this.TextBoxDate_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TextPayment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(450, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 554);
            this.panel2.TabIndex = 1;
            // 
            // TextPayment
            // 
            this.TextPayment.Location = new System.Drawing.Point(129, 54);
            this.TextPayment.Multiline = true;
            this.TextPayment.Name = "TextPayment";
            this.TextPayment.ReadOnly = true;
            this.TextPayment.Size = new System.Drawing.Size(243, 428);
            this.TextPayment.TabIndex = 2;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(180, 482);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 6;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ButtonCancel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Форма платежного поручения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ButtonCancel.ResumeLayout(false);
            this.ButtonCancel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TextCheckRecipient;
        private System.Windows.Forms.Label TextBankRecipient;
        private System.Windows.Forms.Label TextINN;
        private System.Windows.Forms.Label TextBIK;
        private System.Windows.Forms.Label TextBankPerson;
        private System.Windows.Forms.Label TextPrice;
        private System.Windows.Forms.Label TextPerson;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxBankRecipient;
        private System.Windows.Forms.ComboBox ComboBoxBankPerson;
        private System.Windows.Forms.TextBox TextBoxCheckRecipient;
        private System.Windows.Forms.TextBox TextBoxINN;
        private System.Windows.Forms.TextBox TextBoxBIK;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.TextBox TextBoxPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxNumberPayment;
        private System.Windows.Forms.TextBox TextBoxDate;
        private System.Windows.Forms.TextBox TextPayment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.Label TextSuccessfullyPayment;
        private System.Windows.Forms.Button ButtonDelete;
    }
}

