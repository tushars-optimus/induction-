using AvigilonProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvigilonProject.UI.Dialogue
{
    /// <summary>
    /// To show dialog box for adding Ip
    /// </summary>
    class DialogueService
    {
            private static ConnectionView _connectionView;  

            public DialogueService()
            {
                if (_connectionView == null)
                    _connectionView = new ConnectionView();
            }
            public void ShowIpWindow()
            {
                if (_connectionView != null)
                    _connectionView.ShowDialog();
                _connectionView = null;
            }
            public void CloseIpWindow()
            {
                if (_connectionView != null)
                    _connectionView.Close();
                _connectionView = null;
            }
        }
    
}
