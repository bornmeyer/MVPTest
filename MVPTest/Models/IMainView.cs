﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest.Models
{
    public interface IMainView : IView
    {
        String Title
        {
            get;
            set;
        }

        event Action? OnCreateIdClicked;
    }
}
