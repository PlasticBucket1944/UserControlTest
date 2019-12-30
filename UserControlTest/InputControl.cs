using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTest
{
    public partial class InputControl : UserControl
    {
        public InputControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 変更前テキスト保持用
        /// </summary>
        private string bfoText = string.Empty;

        /// <summary>
        /// LeaveValueChangedイベントハンドラ
        /// </summary>
        private event EventHandler leaveValueChanged;

        /// <summary>
        /// LeaveValueChanged イベントを追加・削除
        /// </summary>
        [Category("UserControl1")]
        [Browsable(true)]
        [Description("LeaveValueChanged イベント")]
        public event EventHandler LeaveValueChanged
        {
            add
            {
                this.leaveValueChanged += value;
            }
            remove
            {
                this.leaveValueChanged -= value;
            }
        }

        /// <summary>
        /// 入力値取得
        /// </summary>
        public string Value
        {
            get
            {
                return textBox.Text;
            }
        }

        /// <summary>
        /// テキストボックスLeaveイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Leave(object sender, EventArgs e)
        {
            if (textBox.Text == bfoText) return;

            labelDisp.Text = textBox.Text;
            this.bfoText = textBox.Text;

            // 処理を渡す
            if (this.leaveValueChanged != null)
            {
                this.leaveValueChanged(this, new EventArgs());
            }
        }
    }
}
