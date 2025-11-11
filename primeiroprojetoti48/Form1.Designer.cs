namespace primeiroprojetoti48
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
            this.Somabnt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bntsoma = new System.Windows.Forms.Button();
            this.Subtraçãobnt = new System.Windows.Forms.Button();
            this.Multbnt = new System.Windows.Forms.Button();
            this.Divibnt = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.equal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Somabnt
            // 
            this.Somabnt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Somabnt.Location = new System.Drawing.Point(62, 128);
            this.Somabnt.Name = "Somabnt";
            this.Somabnt.Size = new System.Drawing.Size(53, 40);
            this.Somabnt.TabIndex = 1;
            this.Somabnt.Text = "+";
            this.Somabnt.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calculadora";
            // 
            // bntsoma
            // 
            this.bntsoma.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bntsoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntsoma.Location = new System.Drawing.Point(62, 128);
            this.bntsoma.Name = "bntsoma";
            this.bntsoma.Size = new System.Drawing.Size(53, 40);
            this.bntsoma.TabIndex = 1;
            this.bntsoma.Text = "+";
            this.bntsoma.UseVisualStyleBackColor = false;
            this.bntsoma.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Subtraçãobnt
            // 
            this.Subtraçãobnt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Subtraçãobnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtraçãobnt.Location = new System.Drawing.Point(140, 128);
            this.Subtraçãobnt.Name = "Subtraçãobnt";
            this.Subtraçãobnt.Size = new System.Drawing.Size(53, 40);
            this.Subtraçãobnt.TabIndex = 1;
            this.Subtraçãobnt.Text = "-";
            this.Subtraçãobnt.UseVisualStyleBackColor = false;
            this.Subtraçãobnt.Click += new System.EventHandler(this.Subtraçãobnt_Click);
            // 
            // Multbnt
            // 
            this.Multbnt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Multbnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multbnt.Location = new System.Drawing.Point(219, 128);
            this.Multbnt.Name = "Multbnt";
            this.Multbnt.Size = new System.Drawing.Size(53, 40);
            this.Multbnt.TabIndex = 1;
            this.Multbnt.Text = "x";
            this.Multbnt.UseVisualStyleBackColor = false;
            this.Multbnt.Click += new System.EventHandler(this.Multbnt_Click);
            // 
            // Divibnt
            // 
            this.Divibnt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Divibnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divibnt.Location = new System.Drawing.Point(301, 128);
            this.Divibnt.Name = "Divibnt";
            this.Divibnt.Size = new System.Drawing.Size(53, 40);
            this.Divibnt.TabIndex = 1;
            this.Divibnt.Text = "/";
            this.Divibnt.UseVisualStyleBackColor = false;
            this.Divibnt.Click += new System.EventHandler(this.Divibnt_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.Control;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(67, 213);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(126, 29);
            this.num1.TabIndex = 3;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.Control;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(124, 310);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(170, 29);
            this.result.TabIndex = 3;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.Control;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(228, 213);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(126, 29);
            this.num2.TabIndex = 3;
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(198, 269);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(21, 24);
            this.equal.TabIndex = 4;
            this.equal.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(403, 402);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.result);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Divibnt);
            this.Controls.Add(this.Multbnt);
            this.Controls.Add(this.Subtraçãobnt);
            this.Controls.Add(this.bntsoma);
            this.Controls.Add(this.Somabnt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Somabnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntsoma;
        private System.Windows.Forms.Button Subtraçãobnt;
        private System.Windows.Forms.Button Multbnt;
        private System.Windows.Forms.Button Divibnt;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label equal;
    }
}

