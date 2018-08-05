﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTournamentExtensionInterfaces
{
    public interface IGenericExtensionInformation
    {
        string extensionName { get; }
        Version extensionVersion { get; }
        string extensionDevelopers { get; }
        string appropriateLicenseShort { get; }
        string appropriateLicenseLong { get; }
    }
}
