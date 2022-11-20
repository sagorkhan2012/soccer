namespace Soccer
{
    partial class AdminHome
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
            this.button1 = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.empdetbtn = new System.Windows.Forms.Button();
            this.aempbtn = new System.Windows.Forms.Button();
            this.btnCi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(547, 50);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 33);
            this.username.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Welcome,";
            // 
            // empdetbtn
            // 
            this.empdetbtn.Location = new System.Drawing.Point(338, 184);
            this.empdetbtn.Name = "empdetbtn";
            this.empdetbtn.Size = new System.Drawing.Size(142, 40);
            this.empdetbtn.TabIndex = 18;
            this.empdetbtn.Text = "Employee Details";
            this.empdetbtn.UseVisualStyleBackColor = true;
            this.empdetbtn.Click += new System.EventHandler(this.empdetbtn_Click);
            // 
            // aempbtn
            // 
            this.aempbtn.Location = new System.Drawing.Point(108, 184);
            this.aempbtn.Name = "aempbtn";
            this.aempbtn.Size = new System.Drawing.Size(142, 40);
            this.aempbtn.TabIndex = 17;
            this.aempbtn.Text = "Add Employee";
            this.aempbtn.UseVisualStyleBackColor = true;
            this.aempbtn.Click += new System.EventHandler(this.aempbtn_Click);
            // 
            // btnCi
            // 
            this.btnCi.Location = new System.Drawing.Point(553, 184);
            this.btnCi.Name = "btnCi";
            this.btnCi.Size = new System.Drawing.Size(142, 40);
            this.btnCi.TabIndex = 20;
            this.btnCi.Text = "Coach Instruction";
            this.btnCi.UseVisualStyleBackColor = true;
            this.btnCi.Click += new System.EventHandler(this.btnCi_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCi);
            this.Controls.Add(this.empdetbtn);
            this.Controls.Add(this.aempbtn);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Home";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button empdetbtn;
        private System.Windows.Forms.Button aempbtn;
        private System.Windows.Forms.Button btnCi;
    }
}