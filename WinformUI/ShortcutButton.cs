using Bussiness.Abstract;
using Bussiness.Constants.DependencyResolvers.Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformUI
{
    internal class ShortcutButton : Button 
    {

        protected override void OnClick(EventArgs e)
        {

            ProductBarcode();
           
             
        }

    

         private string ProductBarcode()
        {
            return this.Name;
        }

    }
}
