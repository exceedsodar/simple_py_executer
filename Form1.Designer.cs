namespace simple_py_exec
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.arg1 = new System.Windows.Forms.TextBox();
            this.url_arg = new System.Windows.Forms.Label();
            this.python_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.py_path = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.arg2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.arg3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.arg4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.arg5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.arg6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Excecuter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // arg1
            // 
            this.arg1.Location = new System.Drawing.Point(35, 19);
            this.arg1.Name = "arg1";
            this.arg1.Size = new System.Drawing.Size(451, 20);
            this.arg1.TabIndex = 1;
            // 
            // url_arg
            // 
            this.url_arg.AutoSize = true;
            this.url_arg.Location = new System.Drawing.Point(8, 22);
            this.url_arg.Name = "url_arg";
            this.url_arg.Size = new System.Drawing.Size(21, 13);
            this.url_arg.TabIndex = 2;
            this.url_arg.Text = "url:";
            this.url_arg.Click += new System.EventHandler(this.label1_Click);
            // 
            // python_path
            // 
            this.python_path.Location = new System.Drawing.Point(76, 29);
            this.python_path.Name = "python_path";
            this.python_path.Size = new System.Drawing.Size(214, 20);
            this.python_path.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Python path:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.arg6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.arg5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.arg4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.arg3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.arg2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.arg1);
            this.groupBox1.Controls.Add(this.url_arg);
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 251);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arguments";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.py_path);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.python_path);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paths";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = ".py path:";
            // 
            // py_path
            // 
            this.py_path.Location = new System.Drawing.Point(76, 62);
            this.py_path.Name = "py_path";
            this.py_path.Size = new System.Drawing.Size(214, 20);
            this.py_path.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "(use default python if empty)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "(use .py in the same derectory if empty)";
            // 
            // arg2
            // 
            this.arg2.Location = new System.Drawing.Point(95, 54);
            this.arg2.Name = "arg2";
            this.arg2.Size = new System.Drawing.Size(391, 20);
            this.arg2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "dblist:";
            // 
            // arg3
            // 
            this.arg3.Location = new System.Drawing.Point(95, 91);
            this.arg3.Name = "arg3";
            this.arg3.Size = new System.Drawing.Size(391, 20);
            this.arg3.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "justmodules:";
            // 
            // arg4
            // 
            this.arg4.Location = new System.Drawing.Point(95, 128);
            this.arg4.Name = "arg4";
            this.arg4.Size = new System.Drawing.Size(391, 20);
            this.arg4.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "excludemodules:";
            // 
            // arg5
            // 
            this.arg5.Location = new System.Drawing.Point(95, 165);
            this.arg5.Name = "arg5";
            this.arg5.Size = new System.Drawing.Size(391, 20);
            this.arg5.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "tagold:";
            // 
            // arg6
            // 
            this.arg6.Location = new System.Drawing.Point(95, 205);
            this.arg6.Name = "arg6";
            this.arg6.Size = new System.Drawing.Size(391, 20);
            this.arg6.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "tagnew:";
            // 
            // result
            // 
            this.result.Enabled = false;
            this.result.Location = new System.Drawing.Point(13, 405);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(502, 44);
            this.result.TabIndex = 7;
            this.result.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Generate cmd";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "cmd:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 525);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Simple python executer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox arg1;
        private System.Windows.Forms.Label url_arg;
        private System.Windows.Forms.TextBox python_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox arg6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox arg5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox arg4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox arg3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox arg2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox py_path;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
    }
}

