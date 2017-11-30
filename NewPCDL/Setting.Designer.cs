namespace NewPCDL
{
    partial class Setting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_apiurl = new System.Windows.Forms.TextBox();
            this.tb_appkey = new System.Windows.Forms.TextBox();
            this.tb_sessionkey = new System.Windows.Forms.TextBox();
            this.tb_secret = new System.Windows.Forms.TextBox();
            this.btn_real_url = new System.Windows.Forms.Button();
            this.btn_sandbox_url = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "API URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "App Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(25, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Session Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(25, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Secret";
            // 
            // tb_apiurl
            // 
            this.tb_apiurl.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_apiurl.Location = new System.Drawing.Point(164, 24);
            this.tb_apiurl.Name = "tb_apiurl";
            this.tb_apiurl.Size = new System.Drawing.Size(482, 31);
            this.tb_apiurl.TabIndex = 3;
            // 
            // tb_appkey
            // 
            this.tb_appkey.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_appkey.Location = new System.Drawing.Point(164, 132);
            this.tb_appkey.Name = "tb_appkey";
            this.tb_appkey.Size = new System.Drawing.Size(244, 31);
            this.tb_appkey.TabIndex = 4;
            // 
            // tb_sessionkey
            // 
            this.tb_sessionkey.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_sessionkey.Location = new System.Drawing.Point(164, 256);
            this.tb_sessionkey.Name = "tb_sessionkey";
            this.tb_sessionkey.Size = new System.Drawing.Size(482, 31);
            this.tb_sessionkey.TabIndex = 5;
            // 
            // tb_secret
            // 
            this.tb_secret.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_secret.Location = new System.Drawing.Point(164, 194);
            this.tb_secret.Name = "tb_secret";
            this.tb_secret.Size = new System.Drawing.Size(244, 31);
            this.tb_secret.TabIndex = 6;
            // 
            // btn_real_url
            // 
            this.btn_real_url.Location = new System.Drawing.Point(163, 61);
            this.btn_real_url.Name = "btn_real_url";
            this.btn_real_url.Size = new System.Drawing.Size(100, 31);
            this.btn_real_url.TabIndex = 7;
            this.btn_real_url.Text = "默认正式环境";
            this.btn_real_url.UseVisualStyleBackColor = true;
            this.btn_real_url.Click += new System.EventHandler(this.btn_real_url_Click);
            // 
            // btn_sandbox_url
            // 
            this.btn_sandbox_url.Location = new System.Drawing.Point(283, 61);
            this.btn_sandbox_url.Name = "btn_sandbox_url";
            this.btn_sandbox_url.Size = new System.Drawing.Size(100, 31);
            this.btn_sandbox_url.TabIndex = 8;
            this.btn_sandbox_url.Text = "默认沙盒环境";
            this.btn_sandbox_url.UseVisualStyleBackColor = true;
            this.btn_sandbox_url.Click += new System.EventHandler(this.btn_sandbox_url_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(129, 309);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(372, 37);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "button1";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 358);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_sandbox_url);
            this.Controls.Add(this.btn_real_url);
            this.Controls.Add(this.tb_secret);
            this.Controls.Add(this.tb_sessionkey);
            this.Controls.Add(this.tb_appkey);
            this.Controls.Add(this.tb_apiurl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Setting";
            this.Text = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_apiurl;
        private System.Windows.Forms.TextBox tb_appkey;
        private System.Windows.Forms.TextBox tb_sessionkey;
        private System.Windows.Forms.TextBox tb_secret;
        private System.Windows.Forms.Button btn_real_url;
        private System.Windows.Forms.Button btn_sandbox_url;
        private System.Windows.Forms.Button btn_save;
    }
}