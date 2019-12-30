namespace UserControlTest
{
    partial class InputControl
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDisp = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelDisp
            // 
            this.labelDisp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelDisp.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDisp.Location = new System.Drawing.Point(0, 0);
            this.labelDisp.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.labelDisp.Name = "labelDisp";
            this.labelDisp.Size = new System.Drawing.Size(223, 27);
            this.labelDisp.TabIndex = 0;
            this.labelDisp.Text = "何か入力してください";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox.Location = new System.Drawing.Point(222, 0);
            this.textBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(200, 27);
            this.textBox.TabIndex = 1;
            this.textBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelDisp);
            this.Name = "InputControl";
            this.Size = new System.Drawing.Size(423, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDisp;
        private System.Windows.Forms.TextBox textBox;
    }
}
