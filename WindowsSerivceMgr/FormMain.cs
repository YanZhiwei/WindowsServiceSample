using System;
using System.Windows.Forms;
using MasterChief.DotNet4.Utilities.Common;
using MasterChief.DotNet4.Utilities.WinForm;

namespace WindowsSerivceMgr
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private string ServicePath => txtServicePath.Text.Trim();
        private string ServiceName => "ServiceSample";

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!ServiceHelper.IsExisted(ServiceName))
            {
                MessageBoxHelper.ShowError($"{ServiceName}不存在");
                return;
            }

            ServiceHelper.Start(ServiceName);
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (!ServiceHelper.IsExisted(ServiceName))
            {
                MessageBoxHelper.ShowError($"{ServiceName}不存在");
                return;
            }

            ServiceHelper.Stop(ServiceName);
        }

        private void BtnInstall_Click(object sender, EventArgs e)
        {
            if (ServiceHelper.IsExisted(ServiceName))
            {
                MessageBoxHelper.ShowError($"{ServiceName}已经存在");
                return;
            }

            ServiceHelper.Install(ServicePath);
        }

        private void BtnUnInstall_Click(object sender, EventArgs e)
        {
            if (!ServiceHelper.IsExisted(ServiceName))
            {
                MessageBoxHelper.ShowError($"{ServiceName}不存在");
                return;
            }

            ServiceHelper.Uninstall(ServicePath);
        }
    }
}