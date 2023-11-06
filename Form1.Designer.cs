namespace CS311_Project3_MCM
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
            txtPizzaPlanet = new Label();
            pictPizza = new PictureBox();
            lblSize = new Label();
            cboSize = new ComboBox();
            grpPizza = new GroupBox();
            ckbMushroom = new CheckBox();
            ckbExCheese = new CheckBox();
            ckbJalapeno = new CheckBox();
            ckbBanPep = new CheckBox();
            ckbGrnOlives = new CheckBox();
            ckbBlkOlive = new CheckBox();
            ckbGreenPep = new CheckBox();
            ckbOnion = new CheckBox();
            ckbSpicy = new CheckBox();
            ckbBacon = new CheckBox();
            ckbSausage = new CheckBox();
            ckbPep = new CheckBox();
            lblTop = new Label();
            lblCrust = new Label();
            rdoReg = new RadioButton();
            rdoThick = new RadioButton();
            rdoThin = new RadioButton();
            lblOrder = new Label();
            rtfSummary = new RichTextBox();
            lblSubTotal = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            rtfSub = new RichTextBox();
            rtfTax = new RichTextBox();
            rtfTotal = new RichTextBox();
            btnCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictPizza).BeginInit();
            grpPizza.SuspendLayout();
            SuspendLayout();
            // 
            // txtPizzaPlanet
            // 
            txtPizzaPlanet.AutoSize = true;
            txtPizzaPlanet.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold, GraphicsUnit.Point);
            txtPizzaPlanet.Location = new Point(70, 53);
            txtPizzaPlanet.Name = "txtPizzaPlanet";
            txtPizzaPlanet.Size = new Size(410, 90);
            txtPizzaPlanet.TabIndex = 0;
            txtPizzaPlanet.Text = "Pizza Planet";
            // 
            // pictPizza
            // 
            pictPizza.Image = Properties.Resources.pizza_png;
            pictPizza.Location = new Point(486, 12);
            pictPizza.Name = "pictPizza";
            pictPizza.Size = new Size(254, 177);
            pictPizza.SizeMode = PictureBoxSizeMode.Zoom;
            pictPizza.TabIndex = 1;
            pictPizza.TabStop = false;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSize.Location = new Point(44, 21);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(36, 15);
            lblSize.TabIndex = 2;
            lblSize.Text = "Size: ";
            // 
            // cboSize
            // 
            cboSize.FormattingEnabled = true;
            cboSize.Items.AddRange(new object[] { "Small", "Medium", "Large", "X-Large", "Ginormous" });
            cboSize.Location = new Point(87, 18);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(121, 23);
            cboSize.TabIndex = 3;
            // 
            // grpPizza
            // 
            grpPizza.Controls.Add(ckbMushroom);
            grpPizza.Controls.Add(ckbExCheese);
            grpPizza.Controls.Add(ckbJalapeno);
            grpPizza.Controls.Add(ckbBanPep);
            grpPizza.Controls.Add(ckbGrnOlives);
            grpPizza.Controls.Add(ckbBlkOlive);
            grpPizza.Controls.Add(ckbGreenPep);
            grpPizza.Controls.Add(ckbOnion);
            grpPizza.Controls.Add(ckbSpicy);
            grpPizza.Controls.Add(ckbBacon);
            grpPizza.Controls.Add(ckbSausage);
            grpPizza.Controls.Add(ckbPep);
            grpPizza.Controls.Add(lblTop);
            grpPizza.Controls.Add(lblCrust);
            grpPizza.Controls.Add(rdoReg);
            grpPizza.Controls.Add(lblSize);
            grpPizza.Controls.Add(cboSize);
            grpPizza.Controls.Add(rdoThick);
            grpPizza.Controls.Add(rdoThin);
            grpPizza.Location = new Point(45, 191);
            grpPizza.Name = "grpPizza";
            grpPizza.Size = new Size(752, 197);
            grpPizza.TabIndex = 4;
            grpPizza.TabStop = false;
            // 
            // ckbMushroom
            // 
            ckbMushroom.AutoSize = true;
            ckbMushroom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbMushroom.Location = new Point(403, 159);
            ckbMushroom.Name = "ckbMushroom";
            ckbMushroom.Size = new Size(91, 19);
            ckbMushroom.TabIndex = 17;
            ckbMushroom.Text = "Mushrooms";
            ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // ckbExCheese
            // 
            ckbExCheese.AutoSize = true;
            ckbExCheese.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbExCheese.Location = new Point(403, 134);
            ckbExCheese.Name = "ckbExCheese";
            ckbExCheese.Size = new Size(98, 19);
            ckbExCheese.TabIndex = 16;
            ckbExCheese.Text = "Extra Cheese";
            ckbExCheese.UseVisualStyleBackColor = true;
            // 
            // ckbJalapeno
            // 
            ckbJalapeno.AutoSize = true;
            ckbJalapeno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbJalapeno.Location = new Point(403, 109);
            ckbJalapeno.Name = "ckbJalapeno";
            ckbJalapeno.Size = new Size(74, 19);
            ckbJalapeno.TabIndex = 15;
            ckbJalapeno.Text = "Jalapeno";
            ckbJalapeno.UseVisualStyleBackColor = true;
            // 
            // ckbBanPep
            // 
            ckbBanPep.AutoSize = true;
            ckbBanPep.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbBanPep.Location = new Point(403, 84);
            ckbBanPep.Name = "ckbBanPep";
            ckbBanPep.Size = new Size(114, 19);
            ckbBanPep.TabIndex = 14;
            ckbBanPep.Text = "Banana Peppers";
            ckbBanPep.UseVisualStyleBackColor = true;
            // 
            // ckbGrnOlives
            // 
            ckbGrnOlives.AutoSize = true;
            ckbGrnOlives.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbGrnOlives.Location = new Point(253, 159);
            ckbGrnOlives.Name = "ckbGrnOlives";
            ckbGrnOlives.Size = new Size(98, 19);
            ckbGrnOlives.TabIndex = 13;
            ckbGrnOlives.Text = "Green Olives";
            ckbGrnOlives.UseVisualStyleBackColor = true;
            // 
            // ckbBlkOlive
            // 
            ckbBlkOlive.AutoSize = true;
            ckbBlkOlive.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbBlkOlive.Location = new Point(253, 134);
            ckbBlkOlive.Name = "ckbBlkOlive";
            ckbBlkOlive.Size = new Size(93, 19);
            ckbBlkOlive.TabIndex = 12;
            ckbBlkOlive.Text = "Black Olives";
            ckbBlkOlive.UseVisualStyleBackColor = true;
            // 
            // ckbGreenPep
            // 
            ckbGreenPep.AutoSize = true;
            ckbGreenPep.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbGreenPep.Location = new Point(253, 109);
            ckbGreenPep.Name = "ckbGreenPep";
            ckbGreenPep.Size = new Size(109, 19);
            ckbGreenPep.TabIndex = 11;
            ckbGreenPep.Text = "Green Peppers";
            ckbGreenPep.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            ckbOnion.AutoSize = true;
            ckbOnion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbOnion.Location = new Point(253, 84);
            ckbOnion.Name = "ckbOnion";
            ckbOnion.Size = new Size(59, 19);
            ckbOnion.TabIndex = 10;
            ckbOnion.Text = "Onion";
            ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbSpicy
            // 
            ckbSpicy.AutoSize = true;
            ckbSpicy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbSpicy.Location = new Point(79, 159);
            ckbSpicy.Name = "ckbSpicy";
            ckbSpicy.Size = new Size(140, 19);
            ckbSpicy.TabIndex = 9;
            ckbSpicy.Text = "Spicy Italian Sausage";
            ckbSpicy.UseVisualStyleBackColor = true;
            // 
            // ckbBacon
            // 
            ckbBacon.AutoSize = true;
            ckbBacon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbBacon.Location = new Point(79, 134);
            ckbBacon.Name = "ckbBacon";
            ckbBacon.Size = new Size(112, 19);
            ckbBacon.TabIndex = 8;
            ckbBacon.Text = "Canadian Bacon";
            ckbBacon.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            ckbSausage.AutoSize = true;
            ckbSausage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbSausage.Location = new Point(79, 109);
            ckbSausage.Name = "ckbSausage";
            ckbSausage.Size = new Size(71, 19);
            ckbSausage.TabIndex = 7;
            ckbSausage.Text = "Sausage";
            ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbPep
            // 
            ckbPep.AutoSize = true;
            ckbPep.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ckbPep.Location = new Point(79, 84);
            ckbPep.Name = "ckbPep";
            ckbPep.Size = new Size(83, 19);
            ckbPep.TabIndex = 6;
            ckbPep.Text = "Pepperoni";
            ckbPep.UseVisualStyleBackColor = true;
            // 
            // lblTop
            // 
            lblTop.AutoSize = true;
            lblTop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTop.Location = new Point(27, 59);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(62, 15);
            lblTop.TabIndex = 5;
            lblTop.Text = "Toppings: ";
            // 
            // lblCrust
            // 
            lblCrust.AutoSize = true;
            lblCrust.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCrust.Location = new Point(253, 21);
            lblCrust.Name = "lblCrust";
            lblCrust.Size = new Size(71, 15);
            lblCrust.TabIndex = 4;
            lblCrust.Text = "Crust Type: ";
            // 
            // rdoReg
            // 
            rdoReg.AutoSize = true;
            rdoReg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdoReg.Location = new Point(468, 20);
            rdoReg.Name = "rdoReg";
            rdoReg.Size = new Size(68, 19);
            rdoReg.TabIndex = 2;
            rdoReg.TabStop = true;
            rdoReg.Text = "Regular";
            rdoReg.UseVisualStyleBackColor = true;
            // 
            // rdoThick
            // 
            rdoThick.AutoSize = true;
            rdoThick.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdoThick.Location = new Point(403, 20);
            rdoThick.Name = "rdoThick";
            rdoThick.Size = new Size(55, 19);
            rdoThick.TabIndex = 1;
            rdoThick.TabStop = true;
            rdoThick.Text = "Thick";
            rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoThin
            // 
            rdoThin.AutoSize = true;
            rdoThin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdoThin.Location = new Point(344, 20);
            rdoThin.Name = "rdoThin";
            rdoThin.Size = new Size(49, 19);
            rdoThin.TabIndex = 0;
            rdoThin.TabStop = true;
            rdoThin.Text = "Thin";
            rdoThin.UseVisualStyleBackColor = true;
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrder.Location = new Point(25, 405);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(102, 15);
            lblOrder.TabIndex = 5;
            lblOrder.Text = "Order Summary: ";
            // 
            // rtfSummary
            // 
            rtfSummary.Location = new Point(124, 405);
            rtfSummary.Name = "rtfSummary";
            rtfSummary.Size = new Size(490, 148);
            rtfSummary.TabIndex = 6;
            rtfSummary.Text = "";
            rtfSummary.TextChanged += richTextBox1_TextChanged;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubTotal.Location = new Point(640, 409);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(61, 15);
            lblSubTotal.TabIndex = 7;
            lblSubTotal.Text = "SubTotal: ";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTax.Location = new Point(668, 437);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(32, 15);
            lblTax.TabIndex = 8;
            lblTax.Text = "Tax: ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(660, 466);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(40, 15);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total: ";
            // 
            // rtfSub
            // 
            rtfSub.Location = new Point(697, 405);
            rtfSub.Name = "rtfSub";
            rtfSub.Size = new Size(100, 24);
            rtfSub.TabIndex = 10;
            rtfSub.Text = "";
            // 
            // rtfTax
            // 
            rtfTax.Location = new Point(697, 433);
            rtfTax.Name = "rtfTax";
            rtfTax.Size = new Size(100, 24);
            rtfTax.TabIndex = 11;
            rtfTax.Text = "";
            // 
            // rtfTotal
            // 
            rtfTotal.Location = new Point(697, 463);
            rtfTotal.Name = "rtfTotal";
            rtfTotal.Size = new Size(100, 24);
            rtfTotal.TabIndex = 12;
            rtfTotal.Text = "";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Location = new Point(640, 493);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(157, 60);
            btnCalculate.TabIndex = 13;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 606);
            Controls.Add(btnCalculate);
            Controls.Add(rtfTotal);
            Controls.Add(rtfTax);
            Controls.Add(rtfSub);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubTotal);
            Controls.Add(rtfSummary);
            Controls.Add(lblOrder);
            Controls.Add(grpPizza);
            Controls.Add(pictPizza);
            Controls.Add(txtPizzaPlanet);
            Name = "Form1";
            Text = "Pizza Planet";
            ((System.ComponentModel.ISupportInitialize)pictPizza).EndInit();
            grpPizza.ResumeLayout(false);
            grpPizza.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtPizzaPlanet;
        private PictureBox pictPizza;
        private Label lblSize;
        private ComboBox cboSize;
        private GroupBox grpPizza;
        private RadioButton rdoReg;
        private RadioButton rdoThick;
        private RadioButton rdoThin;
        private Label lblCrust;
        private Label lblTop;
        private CheckBox ckbMushroom;
        private CheckBox ckbExCheese;
        private CheckBox ckbJalapeno;
        private CheckBox ckbBanPep;
        private CheckBox ckbGrnOlives;
        private CheckBox ckbBlkOlive;
        private CheckBox ckbGreenPep;
        private CheckBox ckbOnion;
        private CheckBox ckbSpicy;
        private CheckBox ckbBacon;
        private CheckBox ckbSausage;
        private CheckBox ckbPep;
        private Label lblOrder;
        private RichTextBox rtfSummary;
        private Label lblSubTotal;
        private Label lblTax;
        private Label lblTotal;
        private RichTextBox rtfSub;
        private RichTextBox rtfTax;
        private RichTextBox rtfTotal;
        private Button btnCalculate;
    }
}