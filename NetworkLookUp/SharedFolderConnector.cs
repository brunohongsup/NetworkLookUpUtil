﻿using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Net;

public class SharedFolderConnector : IDisposable
{
    private readonly string _networkName;

    public SharedFolderConnector(string networkName, NetworkCredential credentials)
    {
        _networkName = networkName; 
        var netResource = new NetResource
        {
            ResourceType = ResourceType.Any,
            RemoteName = _networkName,
            LocalName = null,
            Provider = null,
            Scope = ResourceScope.Connected
        };

        var userName = string.IsNullOrEmpty(credentials.Domain)
            ? credentials.UserName
            : $@"{credentials.Domain}\{credentials.UserName}";

        var result = WNetAddConnection2(
            netResource,
            null,
            null,
            0x08);

        if (result != 0)
        {
            int error = Marshal.GetLastWin32Error();
            throw new Win32Exception(result, "Error connecting to remote share");
        }
    }


    ~SharedFolderConnector()
    {
        Dispose(false);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        WNetCancelConnection2(_networkName, 0, true);
    }

    [DllImport("mpr.dll")]
    private static extern int WNetAddConnection2(NetResource netResource, string? password, string? username, int flags);

    [DllImport("mpr.dll")]
    private static extern int WNetCancelConnection2(string? name, int flags, bool force);

    [StructLayout(LayoutKind.Sequential)]
    public class NetResource
    {
        public ResourceScope Scope;
        public ResourceType ResourceType;
        public ResourceDisplaytype DisplayType;
        public int Usage;
        public string? LocalName;
        public string? RemoteName;
        public string? Comment;   
        public string? Provider;  
    }

    public enum ResourceScope : int
    {
        Connected = 1,
        GlobalNetwork,
        Remembered,
        Recent,
        Context
    };

    public enum ResourceType : int
    {
        Any = 0,
        Disk = 0x01,
        Print = 0x02,
        Reserved = 0x08
    }

    public enum ResourceDisplaytype : int
    {
        Generic = 0x0,
        Domain = 0x01,
        Server = 0x02,
        Share = 0x03,
        File = 0x04,
        Group = 0x05,
        Network = 0x06,
        Root = 0x07,
        Shareadmin = 0x08,
        Directory = 0x09,
        Tree = 0x0a,
        Ndscontainer = 0x0b
    }
}