namespace Sys01510
{
    partial class EmployeesF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesF));
            this.dgv_employee = new Sunny.UI.UIDataGridView();
            this.btn_add = new Sunny.UI.UIButton();
            this.btn_update = new Sunny.UI.UIButton();
            this.btn_delete = new Sunny.UI.UIButton();
            this.btn_reload = new Sunny.UI.UIButton();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.btn_clear = new Sunny.UI.UISymbolButton();
            this.btn_search = new Sunny.UI.UISymbolButton();
            this.cmb_title = new Sunny.UI.UIComboBox();
            this.cmb_team = new Sunny.UI.UIComboBox();
            this.txt_extension = new Sunny.UI.UITextBox();
            this.txt_ip = new Sunny.UI.UITextBox();
            this.txt_pcid = new Sunny.UI.UITextBox();
            this.txt_name = new Sunny.UI.UITextBox();
            this.txt_id = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_employee
            // 
            this.dgv_employee.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_employee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_employee.BackgroundColor = System.Drawing.Color.White;
            this.dgv_employee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_employee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_employee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_employee.EnableHeadersVisualStyles = false;
            this.dgv_employee.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_employee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_employee.Location = new System.Drawing.Point(12, 119);
            this.dgv_employee.Name = "dgv_employee";
            this.dgv_employee.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_employee.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_employee.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_employee.RowTemplate.Height = 24;
            this.dgv_employee.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_employee.SelectedIndex = -1;
            this.dgv_employee.Size = new System.Drawing.Size(707, 383);
            this.dgv_employee.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_employee.Style = Sunny.UI.UIStyle.Custom;
            this.dgv_employee.TabIndex = 0;
            this.dgv_employee.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btn_add.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btn_add.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.btn_add.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btn_add.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_add.Location = new System.Drawing.Point(725, 119);
            this.btn_add.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_add.Name = "btn_add";
            this.btn_add.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btn_add.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.btn_add.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btn_add.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btn_add.Size = new System.Drawing.Size(87, 35);
            this.btn_add.Style = Sunny.UI.UIStyle.Green;
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "新增";
            this.btn_add.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btn_update.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btn_update.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.btn_update.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btn_update.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btn_update.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_update.Location = new System.Drawing.Point(725, 165);
            this.btn_update.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_update.Name = "btn_update";
            this.btn_update.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btn_update.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.btn_update.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btn_update.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btn_update.Size = new System.Drawing.Size(87, 35);
            this.btn_update.Style = Sunny.UI.UIStyle.Orange;
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "修改";
            this.btn_update.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_delete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_delete.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btn_delete.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_delete.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_delete.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_delete.Location = new System.Drawing.Point(725, 211);
            this.btn_delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_delete.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btn_delete.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_delete.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_delete.Size = new System.Drawing.Size(87, 35);
            this.btn_delete.Style = Sunny.UI.UIStyle.Red;
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "刪除";
            this.btn_delete.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_reload.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_reload.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btn_reload.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btn_reload.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btn_reload.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_reload.Location = new System.Drawing.Point(725, 256);
            this.btn_reload.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_reload.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.btn_reload.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btn_reload.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.btn_reload.Size = new System.Drawing.Size(87, 35);
            this.btn_reload.Style = Sunny.UI.UIStyle.LayuiGreen;
            this.btn_reload.TabIndex = 4;
            this.btn_reload.Text = "重新載入";
            this.btn_reload.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.btn_clear);
            this.uiGroupBox1.Controls.Add(this.btn_search);
            this.uiGroupBox1.Controls.Add(this.cmb_title);
            this.uiGroupBox1.Controls.Add(this.cmb_team);
            this.uiGroupBox1.Controls.Add(this.txt_extension);
            this.uiGroupBox1.Controls.Add(this.txt_ip);
            this.uiGroupBox1.Controls.Add(this.txt_pcid);
            this.uiGroupBox1.Controls.Add(this.txt_name);
            this.uiGroupBox1.Controls.Add(this.txt_id);
            this.uiGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiGroupBox1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(12, 14);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiGroupBox1.Size = new System.Drawing.Size(800, 97);
            this.uiGroupBox1.Style = Sunny.UI.UIStyle.Orange;
            this.uiGroupBox1.TabIndex = 5;
            this.uiGroupBox1.Text = "搜尋";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.CircleRectWidth = 2;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FillColor = System.Drawing.Color.Transparent;
            this.btn_clear.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_clear.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_clear.IsCircle = true;
            this.btn_clear.Location = new System.Drawing.Point(746, 60);
            this.btn_clear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.RectColor = System.Drawing.Color.DarkGray;
            this.btn_clear.Size = new System.Drawing.Size(42, 33);
            this.btn_clear.Style = Sunny.UI.UIStyle.Custom;
            this.btn_clear.StyleCustomMode = true;
            this.btn_clear.Symbol = 362189;
            this.btn_clear.SymbolColor = System.Drawing.Color.Red;
            this.btn_clear.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btn_clear.SymbolOffset = new System.Drawing.Point(2, 2);
            this.btn_clear.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btn_clear.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btn_clear.TabIndex = 87;
            this.btn_clear.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_clear.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.CircleRectWidth = 2;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FillColor = System.Drawing.Color.Transparent;
            this.btn_search.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_search.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_search.IsCircle = true;
            this.btn_search.Location = new System.Drawing.Point(746, 22);
            this.btn_search.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_search.Name = "btn_search";
            this.btn_search.RectColor = System.Drawing.Color.DarkGray;
            this.btn_search.Size = new System.Drawing.Size(42, 33);
            this.btn_search.Style = Sunny.UI.UIStyle.Custom;
            this.btn_search.StyleCustomMode = true;
            this.btn_search.Symbol = 61442;
            this.btn_search.SymbolColor = System.Drawing.Color.Red;
            this.btn_search.SymbolHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btn_search.SymbolOffset = new System.Drawing.Point(1, 0);
            this.btn_search.SymbolPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btn_search.SymbolSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btn_search.TabIndex = 86;
            this.btn_search.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cmb_title
            // 
            this.cmb_title.DataSource = null;
            this.cmb_title.FillColor = System.Drawing.Color.White;
            this.cmb_title.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.cmb_title.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_title.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.cmb_title.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.cmb_title.Items.AddRange(new object[] {
            "處長",
            "副處長",
            "視察",
            "組長",
            "課長",
            "承辦",
            "秘書"});
            this.cmb_title.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.cmb_title.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.cmb_title.Location = new System.Drawing.Point(648, 45);
            this.cmb_title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_title.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_title.Name = "cmb_title";
            this.cmb_title.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_title.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.cmb_title.Size = new System.Drawing.Size(91, 29);
            this.cmb_title.Style = Sunny.UI.UIStyle.Orange;
            this.cmb_title.TabIndex = 7;
            this.cmb_title.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmb_title.Watermark = "職稱";
            this.cmb_title.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cmb_team
            // 
            this.cmb_team.DataSource = null;
            this.cmb_team.FillColor = System.Drawing.Color.White;
            this.cmb_team.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.cmb_team.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_team.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(212)))));
            this.cmb_team.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.cmb_team.Items.AddRange(new object[] {
            "00處長室",
            "01火源組",
            "04電源策劃組",
            "05水源組",
            "06調查組",
            "07水文組",
            "10管理組"});
            this.cmb_team.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.cmb_team.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.cmb_team.Location = new System.Drawing.Point(549, 45);
            this.cmb_team.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_team.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_team.Name = "cmb_team";
            this.cmb_team.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_team.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.cmb_team.Size = new System.Drawing.Size(91, 29);
            this.cmb_team.Style = Sunny.UI.UIStyle.Orange;
            this.cmb_team.TabIndex = 6;
            this.cmb_team.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmb_team.Watermark = "組別";
            this.cmb_team.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txt_extension
            // 
            this.txt_extension.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_extension.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.txt_extension.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.txt_extension.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_extension.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.txt_extension.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.txt_extension.ButtonWidth = 100;
            this.txt_extension.CanEmpty = true;
            this.txt_extension.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_extension.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.txt_extension.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_extension.Location = new System.Drawing.Point(457, 45);
            this.txt_extension.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_extension.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_extension.Name = "txt_extension";
            this.txt_extension.Padding = new System.Windows.Forms.Padding(5);
            this.txt_extension.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_extension.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_extension.ShowText = false;
            this.txt_extension.Size = new System.Drawing.Size(84, 29);
            this.txt_extension.Style = Sunny.UI.UIStyle.Orange;
            this.txt_extension.TabIndex = 11;
            this.txt_extension.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_extension.Watermark = "分機";
            this.txt_extension.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txt_ip
            // 
            this.txt_ip.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_ip.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.txt_ip.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.txt_ip.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_ip.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.txt_ip.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.txt_ip.ButtonWidth = 100;
            this.txt_ip.CanEmpty = true;
            this.txt_ip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ip.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.txt_ip.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_ip.Location = new System.Drawing.Point(346, 45);
            this.txt_ip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ip.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Padding = new System.Windows.Forms.Padding(5);
            this.txt_ip.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_ip.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_ip.ShowText = false;
            this.txt_ip.Size = new System.Drawing.Size(103, 29);
            this.txt_ip.Style = Sunny.UI.UIStyle.Orange;
            this.txt_ip.TabIndex = 10;
            this.txt_ip.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_ip.Watermark = "IP位址";
            this.txt_ip.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txt_pcid
            // 
            this.txt_pcid.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_pcid.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.txt_pcid.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.txt_pcid.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_pcid.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.txt_pcid.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.txt_pcid.ButtonWidth = 100;
            this.txt_pcid.CanEmpty = true;
            this.txt_pcid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pcid.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.txt_pcid.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_pcid.Location = new System.Drawing.Point(235, 45);
            this.txt_pcid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pcid.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_pcid.Name = "txt_pcid";
            this.txt_pcid.Padding = new System.Windows.Forms.Padding(5);
            this.txt_pcid.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_pcid.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_pcid.ShowText = false;
            this.txt_pcid.Size = new System.Drawing.Size(103, 29);
            this.txt_pcid.Style = Sunny.UI.UIStyle.Orange;
            this.txt_pcid.TabIndex = 7;
            this.txt_pcid.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_pcid.Watermark = "電腦名稱";
            this.txt_pcid.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txt_name
            // 
            this.txt_name.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_name.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.txt_name.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.txt_name.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_name.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.txt_name.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.txt_name.ButtonWidth = 100;
            this.txt_name.CanEmpty = true;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.txt_name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_name.Location = new System.Drawing.Point(124, 45);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_name.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_name.Name = "txt_name";
            this.txt_name.Padding = new System.Windows.Forms.Padding(5);
            this.txt_name.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_name.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_name.ShowText = false;
            this.txt_name.Size = new System.Drawing.Size(103, 29);
            this.txt_name.Style = Sunny.UI.UIStyle.Orange;
            this.txt_name.TabIndex = 6;
            this.txt_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_name.Watermark = "姓名";
            this.txt_name.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txt_id
            // 
            this.txt_id.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_id.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.txt_id.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.txt_id.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_id.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.txt_id.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.txt_id.ButtonWidth = 100;
            this.txt_id.CanEmpty = true;
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.txt_id.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_id.Location = new System.Drawing.Point(13, 45);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_id.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_id.Name = "txt_id";
            this.txt_id.Padding = new System.Windows.Forms.Padding(5);
            this.txt_id.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_id.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.txt_id.ShowText = false;
            this.txt_id.Size = new System.Drawing.Size(103, 29);
            this.txt_id.Style = Sunny.UI.UIStyle.Orange;
            this.txt_id.TabIndex = 5;
            this.txt_id.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_id.Watermark = "姓名代號";
            this.txt_id.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // EmployeesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 507);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_employee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeesF";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employee)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView dgv_employee;
        private Sunny.UI.UIButton btn_add;
        private Sunny.UI.UIButton btn_update;
        private Sunny.UI.UIButton btn_delete;
        private Sunny.UI.UIButton btn_reload;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UITextBox txt_pcid;
        private Sunny.UI.UITextBox txt_name;
        private Sunny.UI.UITextBox txt_id;
        private Sunny.UI.UIComboBox cmb_title;
        private Sunny.UI.UIComboBox cmb_team;
        private Sunny.UI.UITextBox txt_extension;
        private Sunny.UI.UITextBox txt_ip;
        private Sunny.UI.UISymbolButton btn_search;
        private Sunny.UI.UISymbolButton btn_clear;
    }
}