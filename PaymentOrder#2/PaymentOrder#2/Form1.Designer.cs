namespace PaymentOrder_2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBSend = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RBPRED = new System.Windows.Forms.RadioButton();
            this.RBUR = new System.Windows.Forms.RadioButton();
            this.TBINN = new System.Windows.Forms.TextBox();
            this.TBBIK = new System.Windows.Forms.TextBox();
            this.TLINN = new System.Windows.Forms.Label();
            this.TLBIK = new System.Windows.Forms.Label();
            this.CBBankPerson = new System.Windows.Forms.ComboBox();
            this.TBPrice = new System.Windows.Forms.TextBox();
            this.TBPerson = new System.Windows.Forms.TextBox();
            this.TLBankPerson = new System.Windows.Forms.Label();
            this.TLPrice = new System.Windows.Forms.Label();
            this.TLPerson = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TBCheckRecipient = new System.Windows.Forms.TextBox();
            this.CBBankRecipient = new System.Windows.Forms.ComboBox();
            this.TLCheckRecipient = new System.Windows.Forms.Label();
            this.TLBankRecipient = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TBNumber = new System.Windows.Forms.TextBox();
            this.TBDate = new System.Windows.Forms.TextBox();
            this.TLNumber = new System.Windows.Forms.Label();
            this.TLDate = new System.Windows.Forms.Label();
            this.TBPayment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PRBAR = new System.Windows.Forms.ProgressBar();
            this.LoadPR = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.LoadPR);
            this.panel1.Controls.Add(this.ButtonSend);
            this.panel1.Controls.Add(this.ButtonCancel);
            this.panel1.Controls.Add(this.PRBAR);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 663);
            this.panel1.TabIndex = 0;
            // 
            // LBSend
            // 
            this.LBSend.AutoSize = true;
            this.LBSend.Location = new System.Drawing.Point(153, 534);
            this.LBSend.Name = "LBSend";
            this.LBSend.Size = new System.Drawing.Size(102, 18);
            this.LBSend.TabIndex = 3;
            this.LBSend.Text = "Сообщение";
            this.LBSend.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(206, 663);
            this.panel6.TabIndex = 2;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(816, 251);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(123, 28);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "Отменить";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Visible = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSend
            // 
            this.ButtonSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonSend.Location = new System.Drawing.Point(816, 101);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(123, 28);
            this.ButtonSend.TabIndex = 0;
            this.ButtonSend.Text = "Отправить";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.RBPRED);
            this.panel4.Controls.Add(this.RBUR);
            this.panel4.Controls.Add(this.TBINN);
            this.panel4.Controls.Add(this.TBBIK);
            this.panel4.Controls.Add(this.TLINN);
            this.panel4.Controls.Add(this.TLBIK);
            this.panel4.Controls.Add(this.CBBankPerson);
            this.panel4.Controls.Add(this.TBPrice);
            this.panel4.Controls.Add(this.TBPerson);
            this.panel4.Controls.Add(this.TLBankPerson);
            this.panel4.Controls.Add(this.TLPrice);
            this.panel4.Controls.Add(this.TLPerson);
            this.panel4.Location = new System.Drawing.Point(275, 35);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(448, 418);
            this.panel4.TabIndex = 1;
            // 
            // RBPRED
            // 
            this.RBPRED.AutoSize = true;
            this.RBPRED.Location = new System.Drawing.Point(198, 379);
            this.RBPRED.Name = "RBPRED";
            this.RBPRED.Size = new System.Drawing.Size(167, 22);
            this.RBPRED.TabIndex = 13;
            this.RBPRED.TabStop = true;
            this.RBPRED.Text = "Предприниматель";
            this.RBPRED.UseVisualStyleBackColor = true;
            this.RBPRED.CheckedChanged += new System.EventHandler(this.RBPRED_CheckedChanged);
            // 
            // RBUR
            // 
            this.RBUR.AutoSize = true;
            this.RBUR.Location = new System.Drawing.Point(198, 351);
            this.RBUR.Name = "RBUR";
            this.RBUR.Size = new System.Drawing.Size(177, 22);
            this.RBUR.TabIndex = 12;
            this.RBUR.TabStop = true;
            this.RBUR.Text = "Юридическое лицо";
            this.RBUR.UseVisualStyleBackColor = true;
            this.RBUR.CheckedChanged += new System.EventHandler(this.RBUR_CheckedChanged);
            // 
            // TBINN
            // 
            this.TBINN.Location = new System.Drawing.Point(191, 319);
            this.TBINN.Name = "TBINN";
            this.TBINN.Size = new System.Drawing.Size(227, 26);
            this.TBINN.TabIndex = 11;
            // 
            // TBBIK
            // 
            this.TBBIK.Location = new System.Drawing.Point(191, 258);
            this.TBBIK.Name = "TBBIK";
            this.TBBIK.Size = new System.Drawing.Size(227, 26);
            this.TBBIK.TabIndex = 10;
            // 
            // TLINN
            // 
            this.TLINN.AutoSize = true;
            this.TLINN.Location = new System.Drawing.Point(30, 319);
            this.TLINN.Name = "TLINN";
            this.TLINN.Size = new System.Drawing.Size(38, 18);
            this.TLINN.TabIndex = 9;
            this.TLINN.Text = "ИНН";
            // 
            // TLBIK
            // 
            this.TLBIK.AutoSize = true;
            this.TLBIK.Location = new System.Drawing.Point(27, 258);
            this.TLBIK.Name = "TLBIK";
            this.TLBIK.Size = new System.Drawing.Size(36, 18);
            this.TLBIK.TabIndex = 8;
            this.TLBIK.Text = "БИК";
            // 
            // CBBankPerson
            // 
            this.CBBankPerson.FormattingEnabled = true;
            this.CBBankPerson.Items.AddRange(new object[] {
            "ПАО «Лучший банк» ",
            "ПАО «Главный банк»",
            "ПАО «Замечательный банк»"});
            this.CBBankPerson.Location = new System.Drawing.Point(191, 203);
            this.CBBankPerson.Name = "CBBankPerson";
            this.CBBankPerson.Size = new System.Drawing.Size(227, 26);
            this.CBBankPerson.TabIndex = 7;
            // 
            // TBPrice
            // 
            this.TBPrice.Location = new System.Drawing.Point(191, 133);
            this.TBPrice.Name = "TBPrice";
            this.TBPrice.Size = new System.Drawing.Size(227, 26);
            this.TBPrice.TabIndex = 6;
            // 
            // TBPerson
            // 
            this.TBPerson.Location = new System.Drawing.Point(191, 69);
            this.TBPerson.Name = "TBPerson";
            this.TBPerson.Size = new System.Drawing.Size(227, 26);
            this.TBPerson.TabIndex = 5;
            // 
            // TLBankPerson
            // 
            this.TLBankPerson.AutoSize = true;
            this.TLBankPerson.Location = new System.Drawing.Point(27, 203);
            this.TLBankPerson.Name = "TLBankPerson";
            this.TLBankPerson.Size = new System.Drawing.Size(152, 18);
            this.TLBankPerson.TabIndex = 4;
            this.TLBankPerson.Text = "Банк плательщика";
            // 
            // TLPrice
            // 
            this.TLPrice.AutoSize = true;
            this.TLPrice.Location = new System.Drawing.Point(27, 141);
            this.TLPrice.Name = "TLPrice";
            this.TLPrice.Size = new System.Drawing.Size(63, 18);
            this.TLPrice.TabIndex = 3;
            this.TLPrice.Text = "Сумма";
            // 
            // TLPerson
            // 
            this.TLPerson.AutoSize = true;
            this.TLPerson.Location = new System.Drawing.Point(27, 76);
            this.TLPerson.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TLPerson.Name = "TLPerson";
            this.TLPerson.Size = new System.Drawing.Size(102, 18);
            this.TLPerson.TabIndex = 2;
            this.TLPerson.Text = "Плательщик";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.TBCheckRecipient);
            this.panel3.Controls.Add(this.CBBankRecipient);
            this.panel3.Controls.Add(this.TLCheckRecipient);
            this.panel3.Controls.Add(this.TLBankRecipient);
            this.panel3.Location = new System.Drawing.Point(275, 486);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 131);
            this.panel3.TabIndex = 0;
            // 
            // TBCheckRecipient
            // 
            this.TBCheckRecipient.Location = new System.Drawing.Point(192, 87);
            this.TBCheckRecipient.Name = "TBCheckRecipient";
            this.TBCheckRecipient.Size = new System.Drawing.Size(220, 26);
            this.TBCheckRecipient.TabIndex = 3;
            // 
            // CBBankRecipient
            // 
            this.CBBankRecipient.FormattingEnabled = true;
            this.CBBankRecipient.Items.AddRange(new object[] {
            "ПАО «Лучший банк» ",
            "ПАО «Главный банк»",
            "ПАО «Замечательный банк»"});
            this.CBBankRecipient.Location = new System.Drawing.Point(192, 48);
            this.CBBankRecipient.Name = "CBBankRecipient";
            this.CBBankRecipient.Size = new System.Drawing.Size(220, 26);
            this.CBBankRecipient.TabIndex = 2;
            // 
            // TLCheckRecipient
            // 
            this.TLCheckRecipient.AutoSize = true;
            this.TLCheckRecipient.Location = new System.Drawing.Point(39, 90);
            this.TLCheckRecipient.Name = "TLCheckRecipient";
            this.TLCheckRecipient.Size = new System.Drawing.Size(138, 18);
            this.TLCheckRecipient.TabIndex = 1;
            this.TLCheckRecipient.Text = "Счёт получателя";
            // 
            // TLBankRecipient
            // 
            this.TLBankRecipient.AutoSize = true;
            this.TLBankRecipient.Location = new System.Drawing.Point(39, 48);
            this.TLBankRecipient.Name = "TLBankRecipient";
            this.TLBankRecipient.Size = new System.Drawing.Size(137, 18);
            this.TLBankRecipient.TabIndex = 0;
            this.TLBankRecipient.Text = "Банк получателя";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.TBPayment);
            this.panel2.Controls.Add(this.LBSend);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(977, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 663);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TBNumber);
            this.panel5.Controls.Add(this.TBDate);
            this.panel5.Controls.Add(this.TLNumber);
            this.panel5.Controls.Add(this.TLDate);
            this.panel5.Location = new System.Drawing.Point(77, 371);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(396, 120);
            this.panel5.TabIndex = 1;
            // 
            // TBNumber
            // 
            this.TBNumber.Location = new System.Drawing.Point(129, 72);
            this.TBNumber.Name = "TBNumber";
            this.TBNumber.ReadOnly = true;
            this.TBNumber.Size = new System.Drawing.Size(236, 26);
            this.TBNumber.TabIndex = 3;
            // 
            // TBDate
            // 
            this.TBDate.Location = new System.Drawing.Point(129, 18);
            this.TBDate.Name = "TBDate";
            this.TBDate.ReadOnly = true;
            this.TBDate.Size = new System.Drawing.Size(236, 26);
            this.TBDate.TabIndex = 2;
            // 
            // TLNumber
            // 
            this.TLNumber.AutoSize = true;
            this.TLNumber.Location = new System.Drawing.Point(34, 72);
            this.TLNumber.Name = "TLNumber";
            this.TLNumber.Size = new System.Drawing.Size(60, 18);
            this.TLNumber.TabIndex = 1;
            this.TLNumber.Text = "Номер";
            // 
            // TLDate
            // 
            this.TLDate.AutoSize = true;
            this.TLDate.Location = new System.Drawing.Point(29, 18);
            this.TLDate.Name = "TLDate";
            this.TLDate.Size = new System.Drawing.Size(48, 18);
            this.TLDate.TabIndex = 0;
            this.TLDate.Text = "Дата";
            // 
            // TBPayment
            // 
            this.TBPayment.HideSelection = false;
            this.TBPayment.Location = new System.Drawing.Point(79, 201);
            this.TBPayment.Multiline = true;
            this.TBPayment.Name = "TBPayment";
            this.TBPayment.ReadOnly = true;
            this.TBPayment.Size = new System.Drawing.Size(394, 136);
            this.TBPayment.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Реквизиты получателя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Реквизиты плательщика";
            // 
            // PRBAR
            // 
            this.PRBAR.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PRBAR.Location = new System.Drawing.Point(797, 176);
            this.PRBAR.Name = "PRBAR";
            this.PRBAR.Size = new System.Drawing.Size(160, 23);
            this.PRBAR.TabIndex = 4;
            // 
            // LoadPR
            // 
            this.LoadPR.AutoSize = true;
            this.LoadPR.Location = new System.Drawing.Point(831, 155);
            this.LoadPR.Name = "LoadPR";
            this.LoadPR.Size = new System.Drawing.Size(89, 18);
            this.LoadPR.TabIndex = 5;
            this.LoadPR.Text = "Загрузка...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 663);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "Платежное поручение";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label TLPerson;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CBBankPerson;
        private System.Windows.Forms.TextBox TBPrice;
        private System.Windows.Forms.TextBox TBPerson;
        private System.Windows.Forms.Label TLBankPerson;
        private System.Windows.Forms.Label TLPrice;
        private System.Windows.Forms.Label TLINN;
        private System.Windows.Forms.Label TLBIK;
        private System.Windows.Forms.ComboBox CBBankRecipient;
        private System.Windows.Forms.Label TLCheckRecipient;
        private System.Windows.Forms.Label TLBankRecipient;
        private System.Windows.Forms.TextBox TBINN;
        private System.Windows.Forms.TextBox TBBIK;
        private System.Windows.Forms.TextBox TBCheckRecipient;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label TLNumber;
        private System.Windows.Forms.Label TLDate;
        private System.Windows.Forms.TextBox TBPayment;
        private System.Windows.Forms.TextBox TBNumber;
        private System.Windows.Forms.TextBox TBDate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.RadioButton RBPRED;
        private System.Windows.Forms.RadioButton RBUR;
        private System.Windows.Forms.Label LBSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar PRBAR;
        private System.Windows.Forms.Label LoadPR;
    }
}

