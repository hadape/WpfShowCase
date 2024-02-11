﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlPlayers.Infrastructure
{
    public interface IInfrastrucutreSetting
    {
        string ImportFolder { get; set; }
        string ExportFolder { get; set; }
        string ImportPath { get;}
        string ExportPath { get;}
        string FileTypeFilter { get; set; }
    }
}
