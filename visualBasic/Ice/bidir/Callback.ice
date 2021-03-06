// **********************************************************************
//
// Copyright (c) 2003-2015 ZeroC, Inc. All rights reserved.
//
// **********************************************************************

#pragma once

#include <Ice/Identity.ice>

module BidirDemo
{

interface CallbackReceiver
{
    void callback(int num);
};

interface CallbackSender
{
    void addClient(Ice::Identity ident);
};

};
