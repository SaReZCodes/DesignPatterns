using ProxyPattern;

Client client = new Client();

Console.WriteLine("Client: Executing the client code with a real subject:");
Vodafone realSubject = new Vodafone();
client.DoAction(realSubject);

Console.WriteLine();

Console.WriteLine("Client: Executing the same client code with a proxy:");
Proxy proxy = new Proxy(realSubject);
client.DoAction(proxy);
