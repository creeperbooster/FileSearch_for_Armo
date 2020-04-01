namespace ForArmoByMaxim1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCatalog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.cbFdir = new System.Windows.Forms.CheckBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.fBDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tbCatalog
            // 
            this.tbCatalog.Location = new System.Drawing.Point(128, 12);
            this.tbCatalog.Name = "tbCatalog";
            this.tbCatalog.Size = new System.Drawing.Size(273, 20);
            this.tbCatalog.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Каталог поиска";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMore
            // 
            this.btnMore.Location = new System.Drawing.Point(407, 44);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(106, 23);
            this.btnMore.TabIndex = 2;
            this.btnMore.Text = "Искать!";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Маска имени файла";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(128, 44);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(273, 20);
            this.tbFname.TabIndex = 3;
            // 
            // cbFdir
            // 
            this.cbFdir.AutoSize = true;
            this.cbFdir.Checked = true;
            this.cbFdir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFdir.Location = new System.Drawing.Point(128, 83);
            this.cbFdir.Name = "cbFdir";
            this.cbFdir.Size = new System.Drawing.Size(189, 17);
            this.cbFdir.TabIndex = 6;
            this.cbFdir.Text = "Искать включая поддиректории\r\n";
            this.cbFdir.UseVisualStyleBackColor = true;
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(139, 112);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(374, 303);
            this.lbResult.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Обзор";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(419, 421);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(94, 23);
            this.btnClearAll.TabIndex = 9;
            this.btnClearAll.Text = "Очистить Всё!";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 112);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 303);
            this.treeView1.TabIndex = 10;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.cbFdir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCatalog);
            this.Name = "Form1";
            this.Text = "FileFinder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCatalog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.CheckBox cbFdir;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog fBDialog;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.TreeView treeView1;
    }
}

