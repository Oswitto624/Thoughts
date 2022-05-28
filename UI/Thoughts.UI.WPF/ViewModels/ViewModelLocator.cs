﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

namespace Thoughts.UI.WPF.ViewModels
{
    internal class ViewModelLocator
    {
        public FilesViewModel FilesModel => App.Services.GetRequiredService<FilesViewModel>();
    }
}
