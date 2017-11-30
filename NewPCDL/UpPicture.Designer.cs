namespace NewPCDL
{
    partial class uppic_main
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
            this.btn_upload = new System.Windows.Forms.Button();
            this.outputArea = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.openFileDialog_pic = new System.Windows.Forms.OpenFileDialog();
            this.btn_selectfile = new System.Windows.Forms.Button();
            this.tb_filename = new System.Windows.Forms.TextBox();
            this.pic_view = new System.Windows.Forms.PictureBox();
            this.tb_up_filename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_up_title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pic_view)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(14, 663);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(141, 55);
            this.btn_upload.TabIndex = 0;
            this.btn_upload.Text = "确定开始上传";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // outputArea
            // 
            this.outputArea.Location = new System.Drawing.Point(861, 54);
            this.outputArea.Multiline = true;
            this.outputArea.Name = "outputArea";
            this.outputArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputArea.Size = new System.Drawing.Size(251, 585);
            this.outputArea.TabIndex = 1;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(861, 648);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(251, 54);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "clear Log";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // openFileDialog_pic
            // 
            this.openFileDialog_pic.FileName = "selected_file";
            // 
            // btn_selectfile
            // 
            this.btn_selectfile.Location = new System.Drawing.Point(707, 54);
            this.btn_selectfile.Name = "btn_selectfile";
            this.btn_selectfile.Size = new System.Drawing.Size(126, 29);
            this.btn_selectfile.TabIndex = 3;
            this.btn_selectfile.Text = "浏览";
            this.btn_selectfile.UseVisualStyleBackColor = true;
            this.btn_selectfile.Click += new System.EventHandler(this.btn_selectfile_Click);
            // 
            // tb_filename
            // 
            this.tb_filename.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_filename.Location = new System.Drawing.Point(12, 54);
            this.tb_filename.Name = "tb_filename";
            this.tb_filename.Size = new System.Drawing.Size(675, 29);
            this.tb_filename.TabIndex = 4;
            this.tb_filename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_filename_KeyPress);
            this.tb_filename.Leave += new System.EventHandler(this.tb_filename_Leave);
            // 
            // pic_view
            // 
            this.pic_view.Location = new System.Drawing.Point(12, 105);
            this.pic_view.Name = "pic_view";
            this.pic_view.Size = new System.Drawing.Size(821, 420);
            this.pic_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_view.TabIndex = 5;
            this.pic_view.TabStop = false;
            // 
            // tb_up_filename
            // 
            this.tb_up_filename.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_up_filename.Location = new System.Drawing.Point(13, 610);
            this.tb_up_filename.Name = "tb_up_filename";
            this.tb_up_filename.Size = new System.Drawing.Size(385, 29);
            this.tb_up_filename.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "上传的文件名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "上传的标题";
            // 
            // tb_up_title
            // 
            this.tb_up_title.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_up_title.Location = new System.Drawing.Point(448, 610);
            this.tb_up_title.Name = "tb_up_title";
            this.tb_up_title.Size = new System.Drawing.Size(385, 29);
            this.tb_up_title.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(827, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "请选择3M以内的图像文件，支持拖拽,支持手动改后回车或离开焦点";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(864, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Log";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "服务器端信息";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1138, 25);
            this.menu.TabIndex = 11;
            this.menu.Text = "menuStrip1";
            // 
            // menu1
            // 
            this.menu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(44, 21);
            this.menu1.Text = "设定";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItem.Text = "服务器连接信息设定";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // uppic_main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 759);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_up_title);
            this.Controls.Add(this.tb_up_filename);
            this.Controls.Add(this.pic_view);
            this.Controls.Add(this.tb_filename);
            this.Controls.Add(this.btn_selectfile);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.outputArea);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "uppic_main";
            this.Text = "选择图片上传";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.uppic_main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.uppic_main_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pic_view)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.TextBox outputArea;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.OpenFileDialog openFileDialog_pic;
        private System.Windows.Forms.Button btn_selectfile;
        private System.Windows.Forms.TextBox tb_filename;
        private System.Windows.Forms.PictureBox pic_view;
        private System.Windows.Forms.TextBox tb_up_filename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_up_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menu1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
    }
}

