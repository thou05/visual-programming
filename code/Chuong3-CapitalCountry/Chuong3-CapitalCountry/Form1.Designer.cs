namespace Chuong3_CapitalCountry
{
    partial class Form1
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
            this.grpCountry = new System.Windows.Forms.GroupBox();
            this.grpCapital = new System.Windows.Forms.GroupBox();
            this.grpPlan = new System.Windows.Forms.GroupBox();
            this.rdoFr = new System.Windows.Forms.RadioButton();
            this.rdoGe = new System.Windows.Forms.RadioButton();
            this.rdoUK = new System.Windows.Forms.RadioButton();
            this.rdoUS = new System.Windows.Forms.RadioButton();
            this.rdoIt = new System.Windows.Forms.RadioButton();
            this.rdoVi = new System.Windows.Forms.RadioButton();
            this.rdoCa = new System.Windows.Forms.RadioButton();
            this.rdoRu = new System.Windows.Forms.RadioButton();
            this.rdoHa = new System.Windows.Forms.RadioButton();
            this.rdoLo = new System.Windows.Forms.RadioButton();
            this.rdoRo = new System.Windows.Forms.RadioButton();
            this.rdoPa = new System.Windows.Forms.RadioButton();
            this.rdoBe = new System.Windows.Forms.RadioButton();
            this.rdoWa = new System.Windows.Forms.RadioButton();
            this.rdoMo = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.rdoOt = new System.Windows.Forms.RadioButton();
            this.lbYeuCau = new System.Windows.Forms.Label();
            this.grpCountry.SuspendLayout();
            this.grpCapital.SuspendLayout();
            this.grpPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCountry
            // 
            this.grpCountry.Controls.Add(this.rdoRu);
            this.grpCountry.Controls.Add(this.rdoCa);
            this.grpCountry.Controls.Add(this.rdoVi);
            this.grpCountry.Controls.Add(this.rdoIt);
            this.grpCountry.Controls.Add(this.rdoUS);
            this.grpCountry.Controls.Add(this.rdoUK);
            this.grpCountry.Controls.Add(this.rdoGe);
            this.grpCountry.Controls.Add(this.rdoFr);
            this.grpCountry.Location = new System.Drawing.Point(48, 43);
            this.grpCountry.Name = "grpCountry";
            this.grpCountry.Size = new System.Drawing.Size(191, 323);
            this.grpCountry.TabIndex = 0;
            this.grpCountry.TabStop = false;
            this.grpCountry.Text = "Country";
            this.grpCountry.Enter += new System.EventHandler(this.grpCountry_Enter);
            // 
            // grpCapital
            // 
            this.grpCapital.Controls.Add(this.rdoOt);
            this.grpCapital.Controls.Add(this.rdoMo);
            this.grpCapital.Controls.Add(this.rdoWa);
            this.grpCapital.Controls.Add(this.rdoBe);
            this.grpCapital.Controls.Add(this.rdoPa);
            this.grpCapital.Controls.Add(this.rdoRo);
            this.grpCapital.Controls.Add(this.rdoLo);
            this.grpCapital.Controls.Add(this.rdoHa);
            this.grpCapital.Location = new System.Drawing.Point(283, 43);
            this.grpCapital.Name = "grpCapital";
            this.grpCapital.Size = new System.Drawing.Size(249, 323);
            this.grpCapital.TabIndex = 1;
            this.grpCapital.TabStop = false;
            this.grpCapital.Text = "Captital";
            // 
            // grpPlan
            // 
            this.grpPlan.Controls.Add(this.checkBox4);
            this.grpPlan.Controls.Add(this.checkBox3);
            this.grpPlan.Controls.Add(this.checkBox2);
            this.grpPlan.Controls.Add(this.checkBox1);
            this.grpPlan.Location = new System.Drawing.Point(573, 266);
            this.grpPlan.Name = "grpPlan";
            this.grpPlan.Size = new System.Drawing.Size(200, 155);
            this.grpPlan.TabIndex = 2;
            this.grpPlan.TabStop = false;
            this.grpPlan.Text = "You come to";
            // 
            // rdoFr
            // 
            this.rdoFr.AutoSize = true;
            this.rdoFr.Location = new System.Drawing.Point(23, 31);
            this.rdoFr.Name = "rdoFr";
            this.rdoFr.Size = new System.Drawing.Size(58, 17);
            this.rdoFr.TabIndex = 0;
            this.rdoFr.Text = "France";
            this.rdoFr.UseVisualStyleBackColor = true;
            this.rdoFr.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoGe
            // 
            this.rdoGe.AutoSize = true;
            this.rdoGe.Location = new System.Drawing.Point(23, 65);
            this.rdoGe.Name = "rdoGe";
            this.rdoGe.Size = new System.Drawing.Size(67, 17);
            this.rdoGe.TabIndex = 1;
            this.rdoGe.TabStop = true;
            this.rdoGe.Text = "Germany";
            this.rdoGe.UseVisualStyleBackColor = true;
            this.rdoGe.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoUK
            // 
            this.rdoUK.AutoSize = true;
            this.rdoUK.Location = new System.Drawing.Point(23, 99);
            this.rdoUK.Name = "rdoUK";
            this.rdoUK.Size = new System.Drawing.Size(100, 17);
            this.rdoUK.TabIndex = 2;
            this.rdoUK.TabStop = true;
            this.rdoUK.Text = "United Kingdom";
            this.rdoUK.UseVisualStyleBackColor = true;
            this.rdoUK.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoUS
            // 
            this.rdoUS.AutoSize = true;
            this.rdoUS.Location = new System.Drawing.Point(23, 134);
            this.rdoUS.Name = "rdoUS";
            this.rdoUS.Size = new System.Drawing.Size(89, 17);
            this.rdoUS.TabIndex = 3;
            this.rdoUS.TabStop = true;
            this.rdoUS.Text = "United States";
            this.rdoUS.UseVisualStyleBackColor = true;
            this.rdoUS.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoIt
            // 
            this.rdoIt.AutoSize = true;
            this.rdoIt.Location = new System.Drawing.Point(23, 201);
            this.rdoIt.Name = "rdoIt";
            this.rdoIt.Size = new System.Drawing.Size(44, 17);
            this.rdoIt.TabIndex = 4;
            this.rdoIt.TabStop = true;
            this.rdoIt.Text = "Italy";
            this.rdoIt.UseVisualStyleBackColor = true;
            this.rdoIt.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoVi
            // 
            this.rdoVi.AutoSize = true;
            this.rdoVi.Location = new System.Drawing.Point(23, 167);
            this.rdoVi.Name = "rdoVi";
            this.rdoVi.Size = new System.Drawing.Size(68, 17);
            this.rdoVi.TabIndex = 5;
            this.rdoVi.TabStop = true;
            this.rdoVi.Text = "Viet Nam";
            this.rdoVi.UseVisualStyleBackColor = true;
            this.rdoVi.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoCa
            // 
            this.rdoCa.AutoSize = true;
            this.rdoCa.Location = new System.Drawing.Point(23, 224);
            this.rdoCa.Name = "rdoCa";
            this.rdoCa.Size = new System.Drawing.Size(62, 17);
            this.rdoCa.TabIndex = 6;
            this.rdoCa.TabStop = true;
            this.rdoCa.Text = "Canada";
            this.rdoCa.UseVisualStyleBackColor = true;
            this.rdoCa.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoRu
            // 
            this.rdoRu.AutoSize = true;
            this.rdoRu.Location = new System.Drawing.Point(23, 258);
            this.rdoRu.Name = "rdoRu";
            this.rdoRu.Size = new System.Drawing.Size(57, 17);
            this.rdoRu.TabIndex = 7;
            this.rdoRu.TabStop = true;
            this.rdoRu.Text = "Russia";
            this.rdoRu.UseVisualStyleBackColor = true;
            this.rdoRu.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoHa
            // 
            this.rdoHa.AutoSize = true;
            this.rdoHa.Location = new System.Drawing.Point(22, 36);
            this.rdoHa.Name = "rdoHa";
            this.rdoHa.Size = new System.Drawing.Size(58, 17);
            this.rdoHa.TabIndex = 0;
            this.rdoHa.TabStop = true;
            this.rdoHa.Text = "Ha Noi";
            this.rdoHa.UseVisualStyleBackColor = true;
            this.rdoHa.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoLo
            // 
            this.rdoLo.AutoSize = true;
            this.rdoLo.Location = new System.Drawing.Point(22, 65);
            this.rdoLo.Name = "rdoLo";
            this.rdoLo.Size = new System.Drawing.Size(61, 17);
            this.rdoLo.TabIndex = 1;
            this.rdoLo.TabStop = true;
            this.rdoLo.Text = "London";
            this.rdoLo.UseVisualStyleBackColor = true;
            this.rdoLo.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoRo
            // 
            this.rdoRo.AutoSize = true;
            this.rdoRo.Location = new System.Drawing.Point(25, 99);
            this.rdoRo.Name = "rdoRo";
            this.rdoRo.Size = new System.Drawing.Size(53, 17);
            this.rdoRo.TabIndex = 2;
            this.rdoRo.TabStop = true;
            this.rdoRo.Text = "Rome";
            this.rdoRo.UseVisualStyleBackColor = true;
            this.rdoRo.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoPa
            // 
            this.rdoPa.AutoSize = true;
            this.rdoPa.Location = new System.Drawing.Point(25, 167);
            this.rdoPa.Name = "rdoPa";
            this.rdoPa.Size = new System.Drawing.Size(48, 17);
            this.rdoPa.TabIndex = 3;
            this.rdoPa.TabStop = true;
            this.rdoPa.Text = "Paris";
            this.rdoPa.UseVisualStyleBackColor = true;
            this.rdoPa.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoBe
            // 
            this.rdoBe.AutoSize = true;
            this.rdoBe.Location = new System.Drawing.Point(25, 134);
            this.rdoBe.Name = "rdoBe";
            this.rdoBe.Size = new System.Drawing.Size(51, 17);
            this.rdoBe.TabIndex = 4;
            this.rdoBe.TabStop = true;
            this.rdoBe.Text = "Berlin";
            this.rdoBe.UseVisualStyleBackColor = true;
            this.rdoBe.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoWa
            // 
            this.rdoWa.AutoSize = true;
            this.rdoWa.Location = new System.Drawing.Point(22, 258);
            this.rdoWa.Name = "rdoWa";
            this.rdoWa.Size = new System.Drawing.Size(106, 17);
            this.rdoWa.TabIndex = 5;
            this.rdoWa.TabStop = true;
            this.rdoWa.Text = "Washington, D.C";
            this.rdoWa.UseVisualStyleBackColor = true;
            this.rdoWa.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoMo
            // 
            this.rdoMo.AutoSize = true;
            this.rdoMo.Location = new System.Drawing.Point(25, 217);
            this.rdoMo.Name = "rdoMo";
            this.rdoMo.Size = new System.Drawing.Size(65, 17);
            this.rdoMo.TabIndex = 6;
            this.rdoMo.TabStop = true;
            this.rdoMo.Text = "Moscow";
            this.rdoMo.UseVisualStyleBackColor = true;
            this.rdoMo.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Travel";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(24, 51);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(53, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Study";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(24, 83);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(52, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Work";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(24, 107);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(63, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Another";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(612, 68);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // rdoOt
            // 
            this.rdoOt.AutoSize = true;
            this.rdoOt.Location = new System.Drawing.Point(22, 190);
            this.rdoOt.Name = "rdoOt";
            this.rdoOt.Size = new System.Drawing.Size(59, 17);
            this.rdoOt.TabIndex = 7;
            this.rdoOt.TabStop = true;
            this.rdoOt.Text = "Ottawa";
            this.rdoOt.UseVisualStyleBackColor = true;
            this.rdoOt.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // lbYeuCau
            // 
            this.lbYeuCau.AutoSize = true;
            this.lbYeuCau.Location = new System.Drawing.Point(61, 406);
            this.lbYeuCau.Name = "lbYeuCau";
            this.lbYeuCau.Size = new System.Drawing.Size(0, 13);
            this.lbYeuCau.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbYeuCau);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpPlan);
            this.Controls.Add(this.grpCapital);
            this.Controls.Add(this.grpCountry);
            this.Name = "Form1";
            this.Text = "Captital of Country";
            this.grpCountry.ResumeLayout(false);
            this.grpCountry.PerformLayout();
            this.grpCapital.ResumeLayout(false);
            this.grpCapital.PerformLayout();
            this.grpPlan.ResumeLayout(false);
            this.grpPlan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCountry;
        private System.Windows.Forms.RadioButton rdoFr;
        private System.Windows.Forms.GroupBox grpCapital;
        private System.Windows.Forms.GroupBox grpPlan;
        private System.Windows.Forms.RadioButton rdoRu;
        private System.Windows.Forms.RadioButton rdoCa;
        private System.Windows.Forms.RadioButton rdoVi;
        private System.Windows.Forms.RadioButton rdoIt;
        private System.Windows.Forms.RadioButton rdoUS;
        private System.Windows.Forms.RadioButton rdoUK;
        private System.Windows.Forms.RadioButton rdoGe;
        private System.Windows.Forms.RadioButton rdoMo;
        private System.Windows.Forms.RadioButton rdoWa;
        private System.Windows.Forms.RadioButton rdoBe;
        private System.Windows.Forms.RadioButton rdoPa;
        private System.Windows.Forms.RadioButton rdoRo;
        private System.Windows.Forms.RadioButton rdoLo;
        private System.Windows.Forms.RadioButton rdoHa;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdoOt;
        private System.Windows.Forms.Label lbYeuCau;
    }
}

