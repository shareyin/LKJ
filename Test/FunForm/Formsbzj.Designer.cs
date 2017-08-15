namespace Test.FunForm
{
    partial class Formsbzj
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQX0 = new System.Windows.Forms.Button();
            this.btnTSYCS5 = new System.Windows.Forms.Button();
            this.btnJPZJ4 = new System.Windows.Forms.Button();
            this.btnJJZJ3 = new System.Windows.Forms.Button();
            this.btnCYZJ2 = new System.Windows.Forms.Button();
            this.btnXHZJ1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQX0);
            this.groupBox1.Controls.Add(this.btnTSYCS5);
            this.groupBox1.Controls.Add(this.btnJPZJ4);
            this.groupBox1.Controls.Add(this.btnJJZJ3);
            this.groupBox1.Controls.Add(this.btnCYZJ2);
            this.groupBox1.Controls.Add(this.btnXHZJ1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "系统自检测";
            // 
            // btnQX0
            // 
            this.btnQX0.Location = new System.Drawing.Point(201, 151);
            this.btnQX0.Name = "btnQX0";
            this.btnQX0.Size = new System.Drawing.Size(128, 31);
            this.btnQX0.TabIndex = 5;
            this.btnQX0.Text = "取    消[0]";
            this.btnQX0.UseVisualStyleBackColor = true;
            this.btnQX0.Click += new System.EventHandler(this.btnQX0_Click);
            this.btnQX0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnQX0_KeyDown);
            // 
            // btnTSYCS5
            // 
            this.btnTSYCS5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTSYCS5.Location = new System.Drawing.Point(31, 151);
            this.btnTSYCS5.Name = "btnTSYCS5";
            this.btnTSYCS5.Size = new System.Drawing.Size(129, 31);
            this.btnTSYCS5.TabIndex = 4;
            this.btnTSYCS5.Text = "提示音测试[5]";
            this.btnTSYCS5.UseVisualStyleBackColor = true;
            // 
            // btnJPZJ4
            // 
            this.btnJPZJ4.Location = new System.Drawing.Point(201, 102);
            this.btnJPZJ4.Name = "btnJPZJ4";
            this.btnJPZJ4.Size = new System.Drawing.Size(128, 31);
            this.btnJPZJ4.TabIndex = 3;
            this.btnJPZJ4.Text = "键盘自检[4]";
            this.btnJPZJ4.UseVisualStyleBackColor = true;
            // 
            // btnJJZJ3
            // 
            this.btnJJZJ3.Location = new System.Drawing.Point(31, 102);
            this.btnJJZJ3.Name = "btnJJZJ3";
            this.btnJJZJ3.Size = new System.Drawing.Size(129, 31);
            this.btnJJZJ3.TabIndex = 2;
            this.btnJJZJ3.Text = "紧急自检[3]";
            this.btnJJZJ3.UseVisualStyleBackColor = true;
            // 
            // btnCYZJ2
            // 
            this.btnCYZJ2.Location = new System.Drawing.Point(201, 56);
            this.btnCYZJ2.Name = "btnCYZJ2";
            this.btnCYZJ2.Size = new System.Drawing.Size(128, 31);
            this.btnCYZJ2.TabIndex = 1;
            this.btnCYZJ2.Text = "常用自检[2]";
            this.btnCYZJ2.UseVisualStyleBackColor = true;
            // 
            // btnXHZJ1
            // 
            this.btnXHZJ1.Location = new System.Drawing.Point(31, 56);
            this.btnXHZJ1.Name = "btnXHZJ1";
            this.btnXHZJ1.Size = new System.Drawing.Size(129, 31);
            this.btnXHZJ1.TabIndex = 0;
            this.btnXHZJ1.Text = "信号自检[1]";
            this.btnXHZJ1.UseVisualStyleBackColor = true;
            this.btnXHZJ1.Click += new System.EventHandler(this.btnXHZJ1_Click);
            this.btnXHZJ1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnXHZJ1_KeyDown);
            // 
            // Formsbzj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 262);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "Formsbzj";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formsbzj_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQX0;
        private System.Windows.Forms.Button btnTSYCS5;
        private System.Windows.Forms.Button btnJPZJ4;
        private System.Windows.Forms.Button btnJJZJ3;
        private System.Windows.Forms.Button btnCYZJ2;
        private System.Windows.Forms.Button btnXHZJ1;
    }
}