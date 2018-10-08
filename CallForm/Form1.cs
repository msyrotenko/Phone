using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phone;
using System.Threading;
using CallForm.CallView;

namespace CallForm
{
    public partial class Form1 : Form
    {
        object lock_obj;
        CallStorage storage;
        CallProvider provider;
        List<CallViewModel> callList;
        public Form1()
        {
            InitializeComponent();
            lock_obj = new object();
            callList = new List<CallViewModel>();
            storage = new CallStorage();
            storage.CallAdded += ReshrechCallView;
            provider = new CallProvider(storage);
            provider.Stast();
        }

        private void ReshrechCallView(Call call)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Call> (ReshrechCallView), call);
                return;
            }

            var callVM = new CallViewModel(call);

            if (callList.Count() ==0 || !callList.Last().Equals(call))
            {
                callList.Add(callVM);
                string calldetails = $"[{callVM.calltime}] {callVM.calldirection} ({callVM.count})";
                listView1.Items.Add(new ListViewItem(new[] { callVM.contact.name, calldetails }));
            }
            else
            {
                var lastcall = callList.Last();
                lastcall.AddNewCall(callVM);
                string calldetails = $"[{lastcall.calltime}] {lastcall.calldirection} ({lastcall.count})";
                listView1.Items[callList.Count() - 1] = new ListViewItem(new[] { lastcall.contact.name, calldetails });
            }

  
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            provider.Stop();
        }
    }
}
