This demo illustrates how to invoke ordinary (twoway) operations, as
well as how to make oneway, datagram, secure, and batched invocations.

The Ice extension for Ruby currently supports only client-side
functionality, therefore you must use a server from any other language
mapping.

After starting the server, run the Ruby client:

$ ruby Client.rb

To test timeouts you can use 'T' to set a timeout on the client proxy 
and 'P' to set a delayed response in the server to cause a timeout.
You will notice that two "Hello World!" messages will be printed by
the server in this case. This is because the sayHello method is marked
as idempotent in the slice, meaning that Ice does not need to follow
the at-most-once retry semantics. See the manual for more information
about retry behavior.
