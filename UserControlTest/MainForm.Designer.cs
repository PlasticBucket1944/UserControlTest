namespace UserControlTest
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.inputControl = new UserControlTest.InputControl();
            this.button = new System.Windows.Forms.Button();
            this.labelDisp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputControl
            // 
            this.inputControl.Location = new System.Drawing.Point(13, 35);
            this.inputControl.Margin = new System.Windows.Forms.Padding(0);
            this.inputControl.Name = "inputControl";
            this.inputControl.Size = new System.Drawing.Size(423, 29);
            this.inputControl.TabIndex = 0;
            this.inputControl.LeaveValueChanged += new System.EventHandler(this.inputControl_LeaveValueChanged);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(361, 110);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 1;
            this.button.Text = "button1";
            this.button.UseVisualStyleBackColor = true;
            // 
            // labelDisp
            // 
            this.labelDisp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelDisp.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDisp.Location = new System.Drawing.Point(9, 106);
            this.labelDisp.Margin = new System.Windows.Forms.Padding(0);
            this.labelDisp.Name = "labelDisp";
            this.labelDisp.Size = new System.Drawing.Size(223, 27);
            this.labelDisp.TabIndex = 2;
            this.labelDisp.Text = "変更値が反映されます";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 213);
            this.Controls.Add(this.labelDisp);
            this.Controls.Add(this.button);
            this.Controls.Add(this.inputControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private InputControl inputControl;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label labelDisp;
    }
}

