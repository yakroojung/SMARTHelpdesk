namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvAuthenUserGroup = new System.Windows.Forms.DataGridView();
            this.dgvMenuChild = new System.Windows.Forms.DataGridView();
            this.dgvMenuParent = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.bttLogOn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthenUserGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuParent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAuthenUserGroup
            // 
            this.dgvAuthenUserGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthenUserGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAuthenUserGroup.Location = new System.Drawing.Point(0, 471);
            this.dgvAuthenUserGroup.Name = "dgvAuthenUserGroup";
            this.dgvAuthenUserGroup.Size = new System.Drawing.Size(1107, 134);
            this.dgvAuthenUserGroup.TabIndex = 0;
            // 
            // dgvMenuChild
            // 
            this.dgvMenuChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuChild.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMenuChild.Location = new System.Drawing.Point(0, 337);
            this.dgvMenuChild.Name = "dgvMenuChild";
            this.dgvMenuChild.Size = new System.Drawing.Size(1107, 134);
            this.dgvMenuChild.TabIndex = 1;
            // 
            // dgvMenuParent
            // 
            this.dgvMenuParent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuParent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMenuParent.Location = new System.Drawing.Point(0, 203);
            this.dgvMenuParent.Name = "dgvMenuParent";
            this.dgvMenuParent.Size = new System.Drawing.Size(1107, 134);
            this.dgvMenuParent.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "รหัสผ่าน";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "รหัสพนักงาน";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(255, 64);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(278, 29);
            this.txtPassword.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(255, 23);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(278, 29);
            this.txtUserName.TabIndex = 4;
            // 
            // bttLogOn
            // 
            this.bttLogOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLogOn.Image = ((System.Drawing.Image)(resources.GetObject("bttLogOn.Image")));
            this.bttLogOn.Location = new System.Drawing.Point(255, 112);
            this.bttLogOn.Margin = new System.Windows.Forms.Padding(4);
            this.bttLogOn.Name = "bttLogOn";
            this.bttLogOn.Size = new System.Drawing.Size(197, 56);
            this.bttLogOn.TabIndex = 8;
            this.bttLogOn.Text = "เข้าสู่ระบบ";
            this.bttLogOn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttLogOn.UseVisualStyleBackColor = true;
            this.bttLogOn.Click += new System.EventHandler(this.bttLogOn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 605);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.bttLogOn);
            this.Controls.Add(this.dgvMenuParent);
            this.Controls.Add(this.dgvMenuChild);
            this.Controls.Add(this.dgvAuthenUserGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthenUserGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuParent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuthenUserGroup;
        private System.Windows.Forms.DataGridView dgvMenuChild;
        private System.Windows.Forms.DataGridView dgvMenuParent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button bttLogOn;
    }
}

