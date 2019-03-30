using System;

namespace Atlant.Bitcoin.Server.Settings.Abstractions
{
    public interface IBitcoinServerSettings
    {
        Uri Uri { get; }
        string User { get; }
        string Password { get; }
    }
}
