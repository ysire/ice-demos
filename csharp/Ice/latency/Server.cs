// **********************************************************************
//
// Copyright (c) 2003-2015 ZeroC, Inc. All rights reserved.
//
// **********************************************************************

using Demo;
using System;
using System.Reflection;

[assembly: CLSCompliant(true)]

[assembly: AssemblyTitle("IceLatencyServer")]
[assembly: AssemblyDescription("Ice latency demo server")]
[assembly: AssemblyCompany("ZeroC, Inc.")]

public class Server
{
    public class App : Ice.Application
    {
        public override int run(string[] args)
        {
            if(args.Length > 0)
            {
                Console.Error.WriteLine(appName() + ": too many arguments");
                return 1;
            }

            Ice.ObjectAdapter adapter = communicator().createObjectAdapter("Latency");
            adapter.add(new Ping(), communicator().stringToIdentity("ping"));
            adapter.activate();
            communicator().waitForShutdown();
            return 0;
        }
    }

    public static int Main(string[] args)
    {
        App app = new App();
        return app.main(args, "config.server");
    }
}
