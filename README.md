# QuadrigaCX.NET
A C# / Dot Net wrapper for the QuadrigaCX bitcoin exchange API

Disclaimer:  I do not work for Quadriga, and this project is not supported by Quadriga - please do not expect them to help you with it or even know of it's existence.

**Please** let me know if you were able to use this and/or if it was helpful - this is my first GitHub project and I'm curious to know if anyone even finds it...

Here is the first functional implementation of the wrapper.  The API and it's calls are described on the Quadriga site here: https://www.quadrigacx.com/api_info.  The following API calls are implemented in this wrapper:

Current Trading Information
Order Book
Transactions
Account Balance
User Transactions
Open Orders

The following calls will (probably) be implemented (someday):

Lookup Order
Cancel Order
Buy Order - Limit Order
Buy Order - Market Order
Sell Order - Limit Order
Sell Order - Market Order
Bitcoin Deposit
Bitcoin Withdraw

There is a Winforms test app that has example usage and allows you to see the calls in action.  Everything should be pretty self-explanatory, but let me know if you have any questions
