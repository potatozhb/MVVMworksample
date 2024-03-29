﻿using Caliburn.Micro;
using MVVMCaliburnMicro.ViewModels;
using System.Windows;

namespace MVVMCaliburnMicro
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
