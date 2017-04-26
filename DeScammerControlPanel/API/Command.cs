﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeScammerControlPanel.API
{
    public abstract class Command
    {
        #region Abstract Functions
        public abstract void Execute(string[] args);
        #endregion
    }
}
