namespace Sys01510
{
    partial class FolderAdd
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
            this.txt_itemPath = new Sunny.UI.UITextBox();
            this.btn_cancel = new Sunny.UI.UISymbolButton();
            this.btn_ok = new Sunny.UI.UISymbolButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txt_itemName = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // txt_itemPath
            // 
            this.txt_itemPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_itemPath.EnterAsTab = true;
            this.txt_itemPath.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_itemPath.Location = new System.Drawing.Point(119, 50);
            this.txt_itemPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_itemPath.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_itemPath.Name = "txt_itemPath";
            this.txt_itemPath.Padding = new System.Windows.Forms.Padding(5);
            this.txt_itemPath.ShowText = false;
            this.txt_itemPath.Size = new System.Drawing.Size(348, 29);
            this.txt_itemPath.TabIndex = 35;
            this.txt_itemPath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_itemPath.Watermark = "";
            this.txt_itemPath.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_cancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_cancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btn_cancel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancel.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_cancel.Location = new System.Drawing.Point(367, 87);
            this.btn_cancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_cancel.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btn_cancel.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancel.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancel.Size = new System.Drawing.Size(100, 35);
            this.btn_cancel.Style = Sunny.UI.UIStyle.Red;
            this.btn_cancel.Symbol = 61453;
            this.btn_cancel.TabIndex = 50;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btn_ok
            // 
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_ok.Location = new System.Drawing.Point(253, 87);
            this.btn_ok.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(100, 35);
            this.btn_ok.TabIndex = 49;
            this.btn_ok.Text = "確定";
            this.btn_ok.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(25, 55);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(42, 21);
            this.uiLabel3.TabIndex = 40;
            this.uiLabel3.Text = "路徑";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txt_itemName
            // 
            this.txt_itemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_itemName.EnterAsTab = true;
            this.txt_itemName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_itemName.Location = new System.Drawing.Point(119, 11);
            this.txt_itemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_itemName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Padding = new System.Windows.Forms.Padding(5);
            this.txt_itemName.ShowText = false;
            this.txt_itemName.Size = new System.Drawing.Size(348, 29);
            this.txt_itemName.TabIndex = 34;
            this.txt_itemName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_itemName.Watermark = "";
            this.txt_itemName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(25, 15);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(42, 21);
            this.uiLabel2.TabIndex = 37;
            this.uiLabel2.Text = "名稱";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FolderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 134);
            this.Controls.Add(this.txt_itemPath);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.txt_itemName);
            this.Controls.Add(this.uiLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FolderAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增捷徑";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UITextBox txt_itemPath;
        private Sunny.UI.UISymbolButton btn_cancel;
        private Sunny.UI.UISymbolButton btn_ok;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txt_itemName;
        private Sunny.UI.UILabel uiLabel2;
    }
}