namespace Robot_Proj
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
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_rust = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.lbl_robot = new System.Windows.Forms.Label();
            this.lbl_positie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(21, 174);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(75, 23);
            this.btn_left.TabIndex = 0;
            this.btn_left.Text = "Left(-1)";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_rust
            // 
            this.btn_rust.Location = new System.Drawing.Point(102, 174);
            this.btn_rust.Name = "btn_rust";
            this.btn_rust.Size = new System.Drawing.Size(75, 23);
            this.btn_rust.TabIndex = 1;
            this.btn_rust.Text = "Rust(0)";
            this.btn_rust.UseVisualStyleBackColor = true;
            this.btn_rust.Click += new System.EventHandler(this.btn_rust_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(183, 174);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(75, 23);
            this.btn_right.TabIndex = 2;
            this.btn_right.Text = "Right(+1)";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // lbl_robot
            // 
            this.lbl_robot.AutoSize = true;
            this.lbl_robot.Location = new System.Drawing.Point(18, 38);
            this.lbl_robot.Name = "lbl_robot";
            this.lbl_robot.Size = new System.Drawing.Size(71, 13);
            this.lbl_robot.TabIndex = 3;
            this.lbl_robot.Text = "Positie robot: ";
            // 
            // lbl_positie
            // 
            this.lbl_positie.AutoSize = true;
            this.lbl_positie.Location = new System.Drawing.Point(95, 38);
            this.lbl_positie.Name = "lbl_positie";
            this.lbl_positie.Size = new System.Drawing.Size(10, 13);
            this.lbl_positie.TabIndex = 4;
            this.lbl_positie.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_positie);
            this.Controls.Add(this.lbl_robot);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_rust);
            this.Controls.Add(this.btn_left);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_rust;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Label lbl_robot;
        private System.Windows.Forms.Label lbl_positie;
    }
}

