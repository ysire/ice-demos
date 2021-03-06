// **********************************************************************
//
// Copyright (c) 2003-2015 ZeroC, Inc. All rights reserved.
//
// **********************************************************************

using Demo;
using System;

public class SessionFactoryI : SessionFactoryDisp_
{
    public SessionFactoryI(ReapThread reapThread)
    {
        _reaper = reapThread;
    }

    public override SessionPrx create(string name, Ice.Current c)
    {
        SessionI session = new SessionI(name);
        SessionPrx proxy = SessionPrxHelper.uncheckedCast(c.adapter.addWithUUID(session));
        _reaper.add(proxy, session);
        return proxy;
    }

    public override void shutdown(Ice.Current c)
    {
        Console.Out.WriteLine("Shutting down...");
        c.adapter.getCommunicator().shutdown();
    }

    private ReapThread _reaper;
}
