using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace demoForFrame2._0
{
    public partial class AsyncTaskForm : Form
    {
        public AsyncTaskForm()
        {
            InitializeComponent();
            Load += AsyncTaskForm_Load;
        }


        private int _index = 0;
        private void AsyncTaskForm_Load(object sender, EventArgs e)
        {
            for (var i= 0; i <= 10; i++)
            {
                _index = i;
                //Thread.Sleep(100);
                lab_Progress.Text = AsyncTaskHelper.BeginTask(UpdateProgress)();
            }
            
        }

        private string UpdateProgress()
        {
            //this.BeginInvoke(new Action<bool>(delegate { lab_Progress.Text = _index.ToString(); }));
            return _index.ToString();
        }
    }
}
