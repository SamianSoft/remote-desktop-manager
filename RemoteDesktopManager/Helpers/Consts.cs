using System.ComponentModel;

namespace RemoteDesktopManager.Helpers
{
    public enum OnlineStatus
    {
        Connecting,
        Connected,
        Reconnecting,
        Disconnected
    }
    public enum ScreenSize
    {
        Default=1,
        Fullscreen,
        W640_H480,
        W800_H600,
        W1024_H768,
        W1152_H864,
        W1280_H800,
        W1440_H900,
        W1400_H1050,
        W1600_H1024,
        W1600_H1200,
        W1600_H1280,
        W1680_H1050,
        W1900_H1200,
        W1920_H1200,
        W2048_H1536,
        W2560_H2048,
        W3200_H2400,
        W3840_H2400,
        Custom,
        CurrentScreenSize
    }
    public enum DisplayColor
    {
        _8bits=1,
        _15bits,
        _16bits,
        _24bits,
        _32bits,
    }
}