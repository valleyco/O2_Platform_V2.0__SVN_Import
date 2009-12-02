using System;
using System.Windows.Forms;
using O2.External.WinFormsUI;
using O2.External.WinFormsUI.O2Environment;

namespace O2.External.WinFormsUI.Ascx
{
    public partial class ascx_LogViewer : UserControl
    {
        public bool loadConfigExecuted;

        public ascx_LogViewer()
        {
            InitializeComponent();
            if (false == DesignMode)
            {
                DebugMsg.setRtbObject(rtbDebugMessages);

                cbErrorMessages.Checked = true;
                cbDebugMessages.Checked = true;
                cbInfoMessages.Checked = true;
                //DI.log.error("Testing logging: Error Message");
                DI.log.debug("Testing logging: Debug Message");
                DI.log.info("Testing logging: Info Message");
            }
            //  this.Location = new Point(20,500);            
        }


        private void btAddNewLineToDebugWindiw_Click(object sender, EventArgs e)
        {
            DI.log.info("");
        }



        private void btClearDebugView_Click(object sender, EventArgs e)
        {
            DebugMsg.clearText();
        }

        private void rtbDebugMessages_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbErrorMessages_CheckedChanged(object sender, EventArgs e)
        {
            DebugMsg.bShowError = cbErrorMessages.Checked;
        }

        private void cbDebugMessages_CheckedChanged(object sender, EventArgs e)
        {
            DebugMsg.bShowDebug = cbDebugMessages.Checked;
        }

        private void cbInfoMessages_CheckedChanged(object sender, EventArgs e)
        {
            DebugMsg.bShowInfo = cbInfoMessages.Checked;
        }

        private void llGCCollect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GC.Collect();
        }

        private void ascx_LogViewer_Load(object sender, EventArgs e)
        {
            if (false == DesignMode)
            {
                if (false == loadConfigExecuted)
                {
                    if (ParentForm != null)
                        ParentForm.Closing += delegate
                                                  {
                                                      DebugMsg.removeRtbObject(rtbDebugMessages);
                                                  };
                    else
                        DI.log.error("in ascx_LogViewer_Load, there was not parent so .Closing event could not be set");
                    loadConfigExecuted = true;
                }
            }
        }
    }
}