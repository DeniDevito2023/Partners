namespace Partners
{
    partial class PartnersForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartnersForm));
            LayoutPanelPartners = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // LayoutPanelPartners
            // 
            LayoutPanelPartners.AutoScroll = true;
            LayoutPanelPartners.BorderStyle = BorderStyle.FixedSingle;
            LayoutPanelPartners.Location = new Point(83, 253);
            LayoutPanelPartners.Name = "LayoutPanelPartners";
            LayoutPanelPartners.Size = new Size(2530, 784);
            LayoutPanelPartners.TabIndex = 0;
            // 
            // PartnersForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(2672, 1097);
            Controls.Add(LayoutPanelPartners);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "PartnersForm";
            Text = "Form1";
            Load += PartnersForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel LayoutPanelPartners;
    }
}
