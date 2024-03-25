namespace Listbox_Lookup
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChangeForColor = new System.Windows.Forms.Button();
            this.btnChangeBackColor = new System.Windows.Forms.Button();
            this.btnShort = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Ajeet Pal",
            "Aman Sahu",
            "Aman Pal",
            "Alok Bind",
            "Akul Kr Srivastav",
            "Amit Pal",
            "Veeru Pal"});
            this.listBox1.Location = new System.Drawing.Point(391, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 104);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(755, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remove from list";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(298, 222);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(424, 26);
            this.txtInput.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(118, 318);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 33);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add to list";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(807, 318);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(129, 33);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnChangeForColor
            // 
            this.btnChangeForColor.Location = new System.Drawing.Point(295, 318);
            this.btnChangeForColor.Name = "btnChangeForColor";
            this.btnChangeForColor.Size = new System.Drawing.Size(200, 33);
            this.btnChangeForColor.TabIndex = 3;
            this.btnChangeForColor.Text = "Change for color";
            this.btnChangeForColor.UseVisualStyleBackColor = true;
            this.btnChangeForColor.Click += new System.EventHandler(this.btnChangeForColor_Click);
            // 
            // btnChangeBackColor
            // 
            this.btnChangeBackColor.Location = new System.Drawing.Point(552, 318);
            this.btnChangeBackColor.Name = "btnChangeBackColor";
            this.btnChangeBackColor.Size = new System.Drawing.Size(191, 33);
            this.btnChangeBackColor.TabIndex = 3;
            this.btnChangeBackColor.Text = "Change back color";
            this.btnChangeBackColor.UseVisualStyleBackColor = true;
            this.btnChangeBackColor.Click += new System.EventHandler(this.btnChangeBackColor_Click);
            // 
            // btnShort
            // 
            this.btnShort.Location = new System.Drawing.Point(168, 383);
            this.btnShort.Name = "btnShort";
            this.btnShort.Size = new System.Drawing.Size(308, 36);
            this.btnShort.TabIndex = 3;
            this.btnShort.Text = "Sort";
            this.btnShort.UseVisualStyleBackColor = true;
            this.btnShort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(552, 383);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(308, 36);
            this.btnResize.TabIndex = 3;
            this.btnResize.Text = "Change Size";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 570);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnChangeBackColor);
            this.Controls.Add(this.btnChangeForColor);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.btnShort);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Listbox Lookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnChangeForColor;
        private System.Windows.Forms.Button btnChangeBackColor;
        private System.Windows.Forms.Button btnShort;
        private System.Windows.Forms.Button btnResize;
    }
}

