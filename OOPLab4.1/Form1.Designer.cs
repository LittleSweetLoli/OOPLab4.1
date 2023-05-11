namespace OOPLab4._1
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
            this.CtrlBt = new System.Windows.Forms.CheckBox();
            this.AllBt = new System.Windows.Forms.CheckBox();
            this.CreateBt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CtrlBt
            // 
            this.CtrlBt.AutoSize = true;
            this.CtrlBt.Location = new System.Drawing.Point(13, 418);
            this.CtrlBt.Name = "CtrlBt";
            this.CtrlBt.Size = new System.Drawing.Size(48, 20);
            this.CtrlBt.TabIndex = 0;
            this.CtrlBt.Text = "Ctrl";
            this.CtrlBt.UseVisualStyleBackColor = true;
            this.CtrlBt.CheckedChanged += new System.EventHandler(this.CtrlBt_CheckedChanged);
            this.CtrlBt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.CtrlBt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // AllBt
            // 
            this.AllBt.AutoSize = true;
            this.AllBt.Location = new System.Drawing.Point(67, 418);
            this.AllBt.Name = "AllBt";
            this.AllBt.Size = new System.Drawing.Size(44, 20);
            this.AllBt.TabIndex = 1;
            this.AllBt.Text = "All";
            this.AllBt.UseVisualStyleBackColor = true;
            this.AllBt.CheckedChanged += new System.EventHandler(this.AllBt_CheckedChanged);
            this.AllBt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.AllBt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // CreateBt
            // 
            this.CreateBt.AutoSize = true;
            this.CreateBt.Location = new System.Drawing.Point(117, 418);
            this.CreateBt.Name = "CreateBt";
            this.CreateBt.Size = new System.Drawing.Size(69, 20);
            this.CreateBt.TabIndex = 2;
            this.CreateBt.Text = "Create";
            this.CreateBt.UseVisualStyleBackColor = true;
            this.CreateBt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.CreateBt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateBt);
            this.Controls.Add(this.AllBt);
            this.Controls.Add(this.CtrlBt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CtrlBt;
        private System.Windows.Forms.CheckBox AllBt;
        private System.Windows.Forms.CheckBox CreateBt;
    }
}