namespace Soccer
{
    partial class EmpDetails
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
            this.userid = new System.Windows.Forms.TextBox();
            this.useridlbl = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.salarytxt = new System.Windows.Forms.TextBox();
            this.typetxt = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.editbtn = new System.Windows.Forms.Button();
            this.dlbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.ldbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1278, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 34);
            this.button1.TabIndex = 85;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userid
            // 
            this.userid.Location = new System.Drawing.Point(1230, 240);
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            this.userid.Size = new System.Drawing.Size(151, 20);
            this.userid.TabIndex = 84;
            // 
            // useridlbl
            // 
            this.useridlbl.AutoSize = true;
            this.useridlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useridlbl.Location = new System.Drawing.Point(1143, 238);
            this.useridlbl.Name = "useridlbl";
            this.useridlbl.Size = new System.Drawing.Size(68, 20);
            this.useridlbl.TabIndex = 83;
            this.useridlbl.Text = "User ID:";
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(407, 61);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(106, 34);
            this.searchbtn.TabIndex = 82;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(180, 69);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(221, 20);
            this.searchtxt.TabIndex = 81;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(1230, 191);
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(151, 20);
            this.idtxt.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1143, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 79;
            this.label1.Text = "ID:";
            // 
            // salarytxt
            // 
            this.salarytxt.Location = new System.Drawing.Point(1233, 417);
            this.salarytxt.Name = "salarytxt";
            this.salarytxt.Size = new System.Drawing.Size(151, 20);
            this.salarytxt.TabIndex = 78;
            // 
            // typetxt
            // 
            this.typetxt.FormattingEnabled = true;
            this.typetxt.Items.AddRange(new object[] {
            "Admin",
            "Coach",
            "Player"});
            this.typetxt.Location = new System.Drawing.Point(1230, 308);
            this.typetxt.Name = "typetxt";
            this.typetxt.Size = new System.Drawing.Size(151, 21);
            this.typetxt.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1146, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 76;
            this.label9.Text = "Salary:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1143, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 75;
            this.label7.Text = "Type:";
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(1275, 356);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(106, 34);
            this.editbtn.TabIndex = 74;
            this.editbtn.Text = "Update";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // dlbtn
            // 
            this.dlbtn.Location = new System.Drawing.Point(867, 61);
            this.dlbtn.Name = "dlbtn";
            this.dlbtn.Size = new System.Drawing.Size(106, 34);
            this.dlbtn.TabIndex = 73;
            this.dlbtn.Text = "Delete";
            this.dlbtn.UseVisualStyleBackColor = true;
            this.dlbtn.Click += new System.EventHandler(this.dlbtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.Location = new System.Drawing.Point(1005, 61);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(106, 34);
            this.homebtn.TabIndex = 72;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // ldbtn
            // 
            this.ldbtn.Location = new System.Drawing.Point(30, 61);
            this.ldbtn.Name = "ldbtn";
            this.ldbtn.Size = new System.Drawing.Size(106, 34);
            this.ldbtn.TabIndex = 71;
            this.ldbtn.Text = "Load";
            this.ldbtn.UseVisualStyleBackColor = true;
            this.ldbtn.Click += new System.EventHandler(this.ldbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1081, 492);
            this.dataGridView1.TabIndex = 70;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // EmpDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 695);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.useridlbl);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salarytxt);
            this.Controls.Add(this.typetxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.dlbtn);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.ldbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmpDetails";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.EmpDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox userid;
        private System.Windows.Forms.Label useridlbl;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salarytxt;
        private System.Windows.Forms.ComboBox typetxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button dlbtn;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button ldbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}