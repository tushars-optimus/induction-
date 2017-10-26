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
            static ConnectionView connectionview;  //remove static

            public DialogueService()
            {
                if (connectionview == null)
                    connectionview = new ConnectionView();
            }
            public void ShowIpWindow()
            {
                if (connectionview != null)
                    connectionview.ShowDialog();
                connectionview = null;
            }
            public void CloseIpWindow()
            {
                if (connectionview != null)
                    connectionview.Close();
                connectionview = null;
            }
        }
    
}
