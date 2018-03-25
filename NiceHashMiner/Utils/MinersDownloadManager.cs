﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.IO.Compression;
using System.Windows.Forms;
using NiceHashMiner.Interfaces;
using System.Threading;
using NiceHashMiner.Configs;
using NiceHashMiner.Devices;

namespace NiceHashMiner.Utils {
    public static class MinersDownloadManager {
        public static DownloadSetup StandardDlSetup = new DownloadSetup(
             "https://github.com/angelbbs/NiceHashMinerLegacy/releases/download/Fork_Fix_5/bin_ff5.zip",
            "bins.zip",
            "bin");

        public static DownloadSetup ThirdPartyDlSetup = new DownloadSetup(
            "https://github.com/angelbbs/NiceHashMinerLegacy/releases/download/Fork_Fix_5/bin_3rdparty_ff5.zip",
            "bins_3rdparty.zip",
            "bin_3rdparty");
    }
}
