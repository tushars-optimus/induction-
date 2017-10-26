using AvigilonProject.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AvigilonProject
{
    /// <summary>
    /// To locate different View Models
    /// </summary>
     public class ViewModelLocator
    {
         /// <summary>
         /// Redirect to main page
         /// </summary>
         public AvigilonProjectViewModel AvigilonProjectViewModel
         {
             get
             {
                 return new AvigilonProjectViewModel();
             }
         }
         /// <summary>
         /// Redirect to Ip page
         /// </summary>
         public AvigilonIpVewModel AvigilonIpVewModel
         {
             get
             {
                 return new AvigilonIpVewModel();
             }
         }
         /// <summary>
         /// Redirect to Adding Ip page
         /// </summary>
         public AvigilonIpAddViewModel AvigilonIpAddViewModel
         {
             get
             {
                 return new AvigilonIpAddViewModel();
             }
         }
    }

}
