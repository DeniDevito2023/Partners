namespace Partners
{
    partial class PartnersSaleUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            TypeLbl = new Label();
            DirectorLbl = new Label();
            PhoneLbl = new Label();
            RatingLbl = new Label();
            DiscountLbl = new Label();
            SuspendLayout();
            // 
            // TypeLbl
            // 
            TypeLbl.AutoSize = true;
            TypeLbl.Location = new Point(161, 99);
            TypeLbl.Name = "TypeLbl";
            TypeLbl.Size = new Size(63, 37);
            TypeLbl.TabIndex = 0;
            TypeLbl.Text = "Тип";
            // 
            // DirectorLbl
            // 
            DirectorLbl.AutoSize = true;
            DirectorLbl.Location = new Point(155, 211);
            DirectorLbl.Name = "DirectorLbl";
            DirectorLbl.Size = new Size(138, 37);
            DirectorLbl.TabIndex = 1;
            DirectorLbl.Text = "Директор";
            // 
            // PhoneLbl
            // 
            PhoneLbl.AutoSize = true;
            PhoneLbl.Location = new Point(155, 314);
            PhoneLbl.Name = "PhoneLbl";
            PhoneLbl.Size = new Size(124, 37);
            PhoneLbl.TabIndex = 2;
            PhoneLbl.Text = "Телефон";
            // 
            // RatingLbl
            // 
            RatingLbl.AutoSize = true;
            RatingLbl.Location = new Point(155, 450);
            RatingLbl.Name = "RatingLbl";
            RatingLbl.Size = new Size(115, 37);
            RatingLbl.TabIndex = 3;
            RatingLbl.Text = "Рейтинг";
            // 
            // DiscountLbl
            // 
            DiscountLbl.AutoSize = true;
            DiscountLbl.Location = new Point(2261, 137);
            DiscountLbl.Name = "DiscountLbl";
            DiscountLbl.Size = new Size(105, 37);
            DiscountLbl.TabIndex = 4;
            DiscountLbl.Text = "Скидка";
            // 
            // PartnersSaleUserControl
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(DiscountLbl);
            Controls.Add(RatingLbl);
            Controls.Add(PhoneLbl);
            Controls.Add(DirectorLbl);
            Controls.Add(TypeLbl);
            Name = "PartnersSaleUserControl";
            Size = new Size(2930, 582);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TypeLbl;
        private Label DirectorLbl;
        private Label PhoneLbl;
        private Label RatingLbl;
        private Label DiscountLbl;
    }
}
