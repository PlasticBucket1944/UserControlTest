using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTest
{

    /// <summary>
    /// メイン画面
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// inputControlLeaveValueChangedイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputControl_LeaveValueChanged(object sender, EventArgs e)
        {
            this.labelDisp.Text = this.inputControl.Value;
        }
    }
}
