namespace MoneyDrop
{
    partial class Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PInsertQuestion = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cmboLevel = new System.Windows.Forms.ComboBox();
            this.txtAns3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAns2 = new System.Windows.Forms.TextBox();
            this.cmboCategory = new System.Windows.Forms.ComboBox();
            this.txtAns1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorrectAns = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PInsertCategory = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pData = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.cmboID = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.questionTableView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.PInsertQuestion.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.PInsertCategory.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.pData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.insertQuestionToolStripMenuItem,
            this.insertCategoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // insertQuestionToolStripMenuItem
            // 
            this.insertQuestionToolStripMenuItem.Name = "insertQuestionToolStripMenuItem";
            this.insertQuestionToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.insertQuestionToolStripMenuItem.Text = "Insert Question";
            this.insertQuestionToolStripMenuItem.Click += new System.EventHandler(this.insertQuestionToolStripMenuItem_Click);
            // 
            // insertCategoryToolStripMenuItem
            // 
            this.insertCategoryToolStripMenuItem.Name = "insertCategoryToolStripMenuItem";
            this.insertCategoryToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.insertCategoryToolStripMenuItem.Text = "Insert Category";
            this.insertCategoryToolStripMenuItem.Click += new System.EventHandler(this.insertCategoryToolStripMenuItem_Click);
            // 
            // PInsertQuestion
            // 
            this.PInsertQuestion.Controls.Add(this.tableLayoutPanel1);
            this.PInsertQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PInsertQuestion.Location = new System.Drawing.Point(0, 26);
            this.PInsertQuestion.Name = "PInsertQuestion";
            this.PInsertQuestion.Size = new System.Drawing.Size(658, 606);
            this.PInsertQuestion.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(658, 606);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.txtId, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.cmboLevel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtAns3, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.txtAns2, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.cmboCategory, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtAns1, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtCorrectAns, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtQuestion, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.6383F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.6383F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.6383F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.6383F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.6383F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.6383F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.6383F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.6383F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(652, 540);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // txtId
            // 
            this.txtId.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("M-Myanmar3 (Unicode)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(198, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(65, 34);
            this.txtId.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Id";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(198, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 55);
            this.button2.TabIndex = 9;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmboLevel
            // 
            this.cmboLevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboLevel.Font = new System.Drawing.Font("M-Myanmar3 (Unicode)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboLevel.FormattingEnabled = true;
            this.cmboLevel.Location = new System.Drawing.Point(198, 60);
            this.cmboLevel.Name = "cmboLevel";
            this.cmboLevel.Size = new System.Drawing.Size(96, 35);
            this.cmboLevel.TabIndex = 1;
            this.cmboLevel.SelectedIndexChanged += new System.EventHandler(this.cmboLevel_SelectedIndexChanged);
            // 
            // txtAns3
            // 
            this.txtAns3.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtAns3.Font = new System.Drawing.Font("M-Myanmar3 (Unicode)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAns3.Location = new System.Drawing.Point(198, 425);
            this.txtAns3.Name = "txtAns3";
            this.txtAns3.Size = new System.Drawing.Size(182, 34);
            this.txtAns3.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Incorrect Answer3";
            // 
            // txtAns2
            // 
            this.txtAns2.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtAns2.Font = new System.Drawing.Font("M-Myanmar3 (Unicode)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAns2.Location = new System.Drawing.Point(198, 368);
            this.txtAns2.Name = "txtAns2";
            this.txtAns2.Size = new System.Drawing.Size(182, 34);
            this.txtAns2.TabIndex = 6;
            // 
            // cmboCategory
            // 
            this.cmboCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboCategory.Font = new System.Drawing.Font("M-Myanmar3 (Unicode)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboCategory.FormattingEnabled = true;
            this.cmboCategory.IntegralHeight = false;
            this.cmboCategory.Location = new System.Drawing.Point(198, 117);
            this.cmboCategory.MaxDropDownItems = 10;
            this.cmboCategory.Name = "cmboCategory";
            this.cmboCategory.Size = new System.Drawing.Size(150, 35);
            this.cmboCategory.TabIndex = 2;
            // 
            // txtAns1
            // 
            this.txtAns1.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtAns1.Font = new System.Drawing.Font("M-Myanmar3 (Unicode)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAns1.Location = new System.Drawing.Point(198, 311);
            this.txtAns1.Name = "txtAns1";
            this.txtAns1.Size = new System.Drawing.Size(182, 34);
            this.txtAns1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Incorrect Answer2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // txtCorrectAns
            // 
            this.txtCorrectAns.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCorrectAns.Font = new System.Drawing.Font("M-Myanmar3 (Unicode)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrectAns.Location = new System.Drawing.Point(198, 254);
            this.txtCorrectAns.Name = "txtCorrectAns";
            this.txtCorrectAns.Size = new System.Drawing.Size(182, 34);
            this.txtCorrectAns.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Question";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Incorrect Answer1";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuestion.Font = new System.Drawing.Font("M-Myanmar3 (Unicode)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(198, 174);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(451, 74);
            this.txtQuestion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correct Answer";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(652, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Question Insert";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PInsertCategory
            // 
            this.PInsertCategory.Controls.Add(this.tableLayoutPanel3);
            this.PInsertCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PInsertCategory.Location = new System.Drawing.Point(0, 26);
            this.PInsertCategory.Name = "PInsertCategory";
            this.PInsertCategory.Size = new System.Drawing.Size(658, 606);
            this.PInsertCategory.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(658, 606);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(652, 58);
            this.label10.TabIndex = 0;
            this.label10.Text = "Insert Category";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.45763F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.44751F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.09392F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.83051F));
            this.tableLayoutPanel4.Controls.Add(this.label11, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label12, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtCategoryName, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtCategoryId, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.button3, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.button4, 2, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 80);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.60714F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.75F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.75F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(652, 502);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(182, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 51);
            this.label11.TabIndex = 0;
            this.label11.Text = "ID";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(182, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 53);
            this.label12.TabIndex = 1;
            this.label12.Text = "Category Name";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCategoryName.Font = new System.Drawing.Font("M-Myanmar3 (Unicode)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(309, 111);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(144, 34);
            this.txtCategoryName.TabIndex = 3;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCategoryId.Enabled = false;
            this.txtCategoryId.Font = new System.Drawing.Font("M-Myanmar3 (Unicode)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryId.Location = new System.Drawing.Point(309, 60);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(144, 34);
            this.txtCategoryId.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(182, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(309, 164);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 45);
            this.button4.TabIndex = 6;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pData
            // 
            this.pData.Controls.Add(this.button5);
            this.pData.Controls.Add(this.cmboID);
            this.pData.Controls.Add(this.lblId);
            this.pData.Controls.Add(this.questionTableView);
            this.pData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pData.Location = new System.Drawing.Point(0, 26);
            this.pData.Name = "pData";
            this.pData.Size = new System.Drawing.Size(658, 606);
            this.pData.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("M-Myanmar3 (Unicode)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(367, 519);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 35);
            this.button5.TabIndex = 9;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cmboID
            // 
            this.cmboID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmboID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmboID.Font = new System.Drawing.Font("M-Myanmar3 (Unicode)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboID.FormattingEnabled = true;
            this.cmboID.IntegralHeight = false;
            this.cmboID.Location = new System.Drawing.Point(204, 519);
            this.cmboID.MaxDropDownItems = 5;
            this.cmboID.Name = "cmboID";
            this.cmboID.Size = new System.Drawing.Size(121, 35);
            this.cmboID.TabIndex = 8;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("M-Myanmar3 (Unicode)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(151, 522);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 27);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "ID";
            // 
            // questionTableView
            // 
            this.questionTableView.AllowUserToAddRows = false;
            this.questionTableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.questionTableView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("M-Myanmar3 (Unicode)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.questionTableView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.questionTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("M-Myanmar3 (Unicode)", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.questionTableView.DefaultCellStyle = dataGridViewCellStyle2;
            this.questionTableView.Dock = System.Windows.Forms.DockStyle.Top;
            this.questionTableView.Location = new System.Drawing.Point(0, 0);
            this.questionTableView.Name = "questionTableView";
            this.questionTableView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.questionTableView.Size = new System.Drawing.Size(658, 419);
            this.questionTableView.TabIndex = 6;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 632);
            this.Controls.Add(this.pData);
            this.Controls.Add(this.PInsertCategory);
            this.Controls.Add(this.PInsertQuestion);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PInsertQuestion.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.PInsertCategory.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.pData.ResumeLayout(false);
            this.pData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertCategoryToolStripMenuItem;
        private System.Windows.Forms.Panel PInsertQuestion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmboLevel;
        private System.Windows.Forms.TextBox txtAns3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAns2;
        private System.Windows.Forms.ComboBox cmboCategory;
        private System.Windows.Forms.TextBox txtAns1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorrectAns;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PInsertCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pData;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cmboID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView questionTableView;
    }
}