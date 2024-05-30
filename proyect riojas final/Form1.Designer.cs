namespace proyect_riojas_final
{
    partial class Form1
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
            listBoxskate = new ListBox();
            listlenght = new ListBox();
            listbrands = new ListBox();
            label1 = new Label();
            txtstore = new TextBox();
            bttnsale = new Button();
            bttnticket = new Button();
            bttninventary = new Button();
            txtlnght = new TextBox();
            txtbrnds = new TextBox();
            SuspendLayout();
            // 
            // listBoxskate
            // 
            listBoxskate.FormattingEnabled = true;
            listBoxskate.ItemHeight = 20;
            listBoxskate.Items.AddRange(new object[] { "       types the skate", "skateboarding", "lomboard", "penny" });
            listBoxskate.Location = new Point(57, 76);
            listBoxskate.Margin = new Padding(3, 4, 3, 4);
            listBoxskate.Name = "listBoxskate";
            listBoxskate.Size = new Size(211, 24);
            listBoxskate.TabIndex = 0;
            listBoxskate.SelectedIndexChanged += listBoxskate_SelectedIndexChanged;
            // 
            // listlenght
            // 
            listlenght.FormattingEnabled = true;
            listlenght.ItemHeight = 20;
            listlenght.Items.AddRange(new object[] { "lenght\"", "7.25 plg\"", "7.5 plg\"", "7.75 plg\"", "7.8 plg\"", "8 plg\"", "8.25 plg\"" });
            listlenght.Location = new Point(344, 76);
            listlenght.Margin = new Padding(3, 4, 3, 4);
            listlenght.Name = "listlenght";
            listlenght.Size = new Size(156, 24);
            listlenght.TabIndex = 1;
            listlenght.SelectedIndexChanged += listlenght_SelectedIndexChanged;
            // 
            // listbrands
            // 
            listbrands.FormattingEnabled = true;
            listbrands.ItemHeight = 20;
            listbrands.Items.AddRange(new object[] { "brands", "Trasher", "santa cruz", "element", "krooked", "loko7" });
            listbrands.Location = new Point(632, 76);
            listbrands.Margin = new Padding(3, 4, 3, 4);
            listbrands.Name = "listbrands";
            listbrands.Size = new Size(202, 24);
            listbrands.TabIndex = 2;
            listbrands.SelectedIndexChanged += listbrands_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(215, 9);
            label1.Name = "label1";
            label1.Size = new Size(336, 46);
            label1.TabIndex = 3;
            label1.Text = "                                               Store \r\n                                          Skate or Die";
            // 
            // txtstore
            // 
            txtstore.Location = new Point(160, 172);
            txtstore.Name = "txtstore";
            txtstore.Size = new Size(219, 27);
            txtstore.TabIndex = 4;
            txtstore.TextChanged += txtstore_TextChanged;
            // 
            // bttnsale
            // 
            bttnsale.Location = new Point(210, 343);
            bttnsale.Name = "bttnsale";
            bttnsale.Size = new Size(133, 36);
            bttnsale.TabIndex = 5;
            bttnsale.Text = "button1";
            bttnsale.UseVisualStyleBackColor = true;
            // 
            // bttnticket
            // 
            bttnticket.Location = new Point(447, 343);
            bttnticket.Name = "bttnticket";
            bttnticket.Size = new Size(127, 36);
            bttnticket.TabIndex = 6;
            bttnticket.Text = "button2";
            bttnticket.UseVisualStyleBackColor = true;
            // 
            // bttninventary
            // 
            bttninventary.Location = new Point(667, 343);
            bttninventary.Name = "bttninventary";
            bttninventary.Size = new Size(127, 35);
            bttninventary.TabIndex = 7;
            bttninventary.Text = "button3";
            bttninventary.UseVisualStyleBackColor = true;
            // 
            // txtlnght
            // 
            txtlnght.Location = new Point(374, 172);
            txtlnght.Name = "txtlnght";
            txtlnght.Size = new Size(75, 27);
            txtlnght.TabIndex = 8;
            // 
            // txtbrnds
            // 
            txtbrnds.Location = new Point(447, 172);
            txtbrnds.Name = "txtbrnds";
            txtbrnds.Size = new Size(127, 27);
            txtbrnds.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1050, 535);
            Controls.Add(txtbrnds);
            Controls.Add(txtlnght);
            Controls.Add(bttninventary);
            Controls.Add(bttnticket);
            Controls.Add(bttnsale);
            Controls.Add(txtstore);
            Controls.Add(label1);
            Controls.Add(listbrands);
            Controls.Add(listlenght);
            Controls.Add(listBoxskate);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxskate;
        private ListBox listlenght;
        private ListBox listbrands;
        private Label label1;
        private TextBox txtstore;
        private Button bttnsale;
        private Button bttnticket;
        private Button bttninventary;
        private TextBox txtlnght;
        private TextBox txtbrnds;
    }
}
