// **********************************************************************
//
// Copyright (c) 2003-2015 ZeroC, Inc. All rights reserved.
//
// **********************************************************************

class ContactFactory implements Ice.ObjectFactory
{
    @Override
    public Ice.Object
    create(String type)
    {
        assert(type.equals("::Demo::Contact"));
        return new ContactI(this);
    }

    @Override
    public void
    destroy()
    {
    }

    ContactFactory()
    {
    }

    void
    setEvictor(Freeze.Evictor evictor)
    {
        _evictor = evictor;
    }

    Freeze.Evictor
    getEvictor()
    {
        return _evictor;
    }

    private Freeze.Evictor _evictor;
}
