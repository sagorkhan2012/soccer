namespace Soccer
{
    partial class PlayerPerformance
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ldbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.homebtn = new System.Windows.Forms.Button();
            this.btnAddPerf = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbPass = new System.Windows.Forms.ComboBox();
            this.cmbDrib = new System.Windows.Forms.ComboBox();
            this.cmbHead = new System.Windows.Forms.ComboBox();
            this.cmbFinish = new System.Windows.Forms.ComboBox();
            this.cmbAttack = new System.Windows.Forms.ComboBox();
            this.cmbDef = new System.Windows.Forms.ComboBox();
            this.cmbBall = new System.Windows.Forms.ComboBox();
            this.cmbLeader = new System.Windows.Forms.ComboBox();
            this.cmbAgil = new System.Windows.Forms.ComboBox();
            this.cmbStrn = new System.Windows.Forms.ComboBox();
            this.cmbDriv = new System.Windows.Forms.ComboBox();
            this.cmbAgg = new System.Windows.Forms.ComboBox();
            this.cmbSpd = new System.Windows.Forms.ComboBox();
            this.cmbEndur = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(809, 539);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ldbtn
            // 
            this.ldbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.ldbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldbtn.Location = new System.Drawing.Point(50, 44);
            this.ldbtn.Name = "ldbtn";
            this.ldbtn.Size = new System.Drawing.Size(128, 54);
            this.ldbtn.TabIndex = 88;
            this.ldbtn.Text = "Load";
            this.ldbtn.UseVisualStyleBackColor = false;
            this.ldbtn.Click += new System.EventHandler(this.ldbtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.Aquamarine;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(751, 50);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(106, 34);
            this.searchbtn.TabIndex = 87;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(425, 50);
            this.searchtxt.Multiline = true;
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(284, 34);
            this.searchtxt.TabIndex = 86;
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.LawnGreen;
            this.homebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.Location = new System.Drawing.Point(949, 44);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(132, 47);
            this.homebtn.TabIndex = 95;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // btnAddPerf
            // 
            this.btnAddPerf.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddPerf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerf.Location = new System.Drawing.Point(1275, 44);
            this.btnAddPerf.Name = "btnAddPerf";
            this.btnAddPerf.Size = new System.Drawing.Size(139, 47);
            this.btnAddPerf.TabIndex = 96;
            this.btnAddPerf.Text = "Add Performance";
            this.btnAddPerf.UseVisualStyleBackColor = false;
            this.btnAddPerf.Click += new System.EventHandler(this.btnAddPerf_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1020, 202);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(192, 20);
            this.txtName.TabIndex = 116;
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(1020, 154);
            this.txtUid.Name = "txtUid";
            this.txtUid.ReadOnly = true;
            this.txtUid.Size = new System.Drawing.Size(192, 20);
            this.txtUid.TabIndex = 115;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(945, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 25);
            this.label11.TabIndex = 106;
            this.label11.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1217, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 25);
            this.label9.TabIndex = 105;
            this.label9.Text = "Endurance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(912, 604);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 104;
            this.label8.Text = "In Defence";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(927, 555);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 103;
            this.label7.Text = "In Attack";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(926, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 102;
            this.label6.Text = "FInishing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(931, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 101;
            this.label5.Text = "Heading";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(929, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 100;
            this.label4.Text = "Dribbling";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(935, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 99;
            this.label3.Text = "Passing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(910, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 98;
            this.label2.Text = "Ball Control";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(932, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 97;
            this.label1.Text = "User ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1212, 603);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 25);
            this.label12.TabIndex = 122;
            this.label12.Text = "Leadership";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1187, 548);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 25);
            this.label13.TabIndex = 121;
            this.label13.Text = "Aggresiveness";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1255, 495);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 25);
            this.label14.TabIndex = 120;
            this.label14.Text = "Drive";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1238, 442);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 25);
            this.label15.TabIndex = 119;
            this.label15.Text = "Strenth";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1250, 394);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 25);
            this.label16.TabIndex = 118;
            this.label16.Text = "Agility";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1244, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 25);
            this.label10.TabIndex = 117;
            this.label10.Text = "Speed";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lime;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1323, 167);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 44);
            this.btnUpdate.TabIndex = 129;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbPass
            // 
            this.cmbPass.FormattingEnabled = true;
            this.cmbPass.Items.AddRange(new object[] {
            "level 1",
            "level 2",
            "level 3"});
            this.cmbPass.Location = new System.Drawing.Point(1030, 330);
            this.cmbPass.Name = "cmbPass";
            this.cmbPass.Size = new System.Drawing.Size(121, 21);
            this.cmbPass.TabIndex = 137;
            // 
            // cmbDrib
            // 
            this.cmbDrib.FormattingEnabled = true;
            this.cmbDrib.Items.AddRange(new object[] {
            "level 1",
            "level 2",
            "level 3"});
            this.cmbDrib.Location = new System.Drawing.Point(1030, 383);
            this.cmbDrib.Name = "cmbDrib";
            this.cmbDrib.Size = new System.Drawing.Size(121, 21);
            this.cmbDrib.TabIndex = 136;
            // 
            // cmbHead
            // 
            this.cmbHead.FormattingEnabled = true;
            this.cmbHead.Items.AddRange(new object[] {
            "level 1",
            "level 2",
            "level 3"});
            this.cmbHead.Location = new System.Drawing.Point(1030, 438);
            this.cmbHead.Name = "cmbHead";
            this.cmbHead.Size = new System.Drawing.Size(121, 21);
            this.cmbHead.TabIndex = 135;
            // 
            // cmbFinish
            // 
            this.cmbFinish.FormattingEnabled = true;
            this.cmbFinish.Items.AddRange(new object[] {
            "level 1",
            "level 2",
            "level 3"});
            this.cmbFinish.Location = new System.Drawing.Point(1030, 497);
            this.cmbFinish.Name = "cmbFinish";
            this.cmbFinish.Size = new System.Drawing.Size(121, 21);
            this.cmbFinish.TabIndex = 134;
            // 
            // cmbAttack
            // 
            this.cmbAttack.FormattingEnabled = true;
            this.cmbAttack.Items.AddRange(new object[] {
            "level 1",
            "level 2",
            "level 3"});
            this.cmbAttack.Location = new System.Drawing.Point(1030, 555);
            this.cmbAttack.Name = "cmbAttack";
            this.cmbAttack.Size = new System.Drawing.Size(121, 21);
            this.cmbAttack.TabIndex = 133;
            // 
            // cmbDef
            // 
            this.cmbDef.FormattingEnabled = true;
            this.cmbDef.Items.AddRange(new object[] {
            "level 1",
            "level 2",
            "level 3"});
            this.cmbDef.Location = new System.Drawing.Point(1030, 604);
            this.cmbDef.Name = "cmbDef";
            this.cmbDef.Size = new System.Drawing.Size(121, 21);
            this.cmbDef.TabIndex = 132;
            // 
            // cmbBall
            // 
            this.cmbBall.FormattingEnabled = true;
            this.cmbBall.Items.AddRange(new object[] {
            "level 1",
            "level 2",
            "level 3"});
            this.cmbBall.Location = new System.Drawing.Point(1030, 277);
            this.cmbBall.Name = "cmbBall";
            this.cmbBall.Size = new System.Drawing.Size(121, 21);
            this.cmbBall.TabIndex = 131;
            // 
            // cmbLeader
            // 
            this.cmbLeader.FormattingEnabled = true;
            this.cmbLeader.Items.AddRange(new object[] {
            "level 1",
            "level 2",
            "level 3"});
            this.cmbLeader.Location = new System.Drawing.Point(1333, 606);
            this.cmbLeader.Name = "cmbLeader";
            this.cmbLeader.Size = new System.Drawing.Size(121, 21);
            this.cmbLeader.TabIndex = 143;
            // 
            // cmbAgil
            // 
            this.cmbAgil.FormattingEnabled = true;
            this.cmbAgil.Items.AddRange(new object[] {
            "level 1",
            "level 2",
            "level 3"});
            this.cmbAgil.Location = new System.Drawing.Point(1333, 397);
            this.cmbAgil.Name = "cmbAgil";
            this.cmbAgil.Size = new System.Drawing.Size(121, 21);
            this.cmbAgil.TabIndex = 142;
            // 
            // cmbStrn
            // 
            this.cmbStrn.FormattingEnabled = true;
            this.cmbStrn.Items.AddRange(new object[] {
            "level 1",
            "level 2",
            "level 3"});
            this.cmbStrn.Location = new System.Drawing.Point(1333, 445);
            this.cmbStrn.Name = "cmbStrn";
            this.cmbStrn.Size = new System.Drawing.Size(121, 21);
            this.cmbStrn.TabIndex = 141;
            // 
            // cmbDriv
            // 
            this.cmbDriv.FormattingEnabled = true;
            this.cmbDriv.Items.AddRange(new object[] {
            "level 1",
            "level 2",
            "level 3"});
            this.cmbDriv.Location = new System.Drawing.Point(1333, 498);
            this.cmbDriv.Name = "cmbDriv";
            this.cmbDriv.Size = new System.Drawing.Size(121, 21);
            this.cmbDriv.TabIndex = 140;
            // 
            // cmbAgg
            // 
            this.cmbAgg.FormattingEnabled = true;
            this.cmbAgg.Items.AddRange(new object[] {
            "level 1",
            "level 2",
            "level 3"});
            this.cmbAgg.Location = new System.Drawing.Point(1333, 550);
            this.cmbAgg.Name = "cmbAgg";
            this.cmbAgg.Size = new System.Drawing.Size(121, 21);
            this.cmbAgg.TabIndex = 139;
            // 
            // cmbSpd
            // 
            this.cmbSpd.FormattingEnabled = true;
            this.cmbSpd.Items.AddRange(new object[] {
            "level 1",
            "level 2",
            "level 3"});
            this.cmbSpd.Location = new System.Drawing.Point(1333, 341);
            this.cmbSpd.Name = "cmbSpd";
            this.cmbSpd.Size = new System.Drawing.Size(121, 21);
            this.cmbSpd.TabIndex = 138;
            // 
            // cmbEndur
            // 
            this.cmbEndur.FormattingEnabled = true;
            this.cmbEndur.Items.AddRange(new object[] {
            "level 1",
            "level 2",
            "level 3"});
            this.cmbEndur.Location = new System.Drawing.Point(1333, 285);
            this.cmbEndur.Name = "cmbEndur";
            this.cmbEndur.Size = new System.Drawing.Size(121, 21);
            this.cmbEndur.TabIndex = 144;
            // 
            // PlayerPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1496, 784);
            this.Controls.Add(this.cmbEndur);
            this.Controls.Add(this.cmbLeader);
            this.Controls.Add(this.cmbAgil);
            this.Controls.Add(this.cmbStrn);
            this.Controls.Add(this.cmbDriv);
            this.Controls.Add(this.cmbAgg);
            this.Controls.Add(this.cmbSpd);
            this.Controls.Add(this.cmbPass);
            this.Controls.Add(this.cmbDrib);
            this.Controls.Add(this.cmbHead);
            this.Controls.Add(this.cmbFinish);
            this.Controls.Add(this.cmbAttack);
            this.Controls.Add(this.cmbDef);
            this.Controls.Add(this.cmbBall);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPerf);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.ldbtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PlayerPerformance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player Performance";
            this.Load += new System.EventHandler(this.PlayerPerformance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ldbtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button btnAddPerf;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbPass;
        private System.Windows.Forms.ComboBox cmbDrib;
        private System.Windows.Forms.ComboBox cmbHead;
        private System.Windows.Forms.ComboBox cmbFinish;
        private System.Windows.Forms.ComboBox cmbAttack;
        private System.Windows.Forms.ComboBox cmbDef;
        private System.Windows.Forms.ComboBox cmbBall;
        private System.Windows.Forms.ComboBox cmbLeader;
        private System.Windows.Forms.ComboBox cmbAgil;
        private System.Windows.Forms.ComboBox cmbStrn;
        private System.Windows.Forms.ComboBox cmbDriv;
        private System.Windows.Forms.ComboBox cmbAgg;
        private System.Windows.Forms.ComboBox cmbSpd;
        private System.Windows.Forms.ComboBox cmbEndur;
    }
}