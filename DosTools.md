# DOS Tools

The DOS Tools project includes two tools, goldeneye and thc-ssl-dos, that can be used to test web servers for vulnerabilities and perform Denial of Service (DoS) attacks. These tools are built into Kali Linux and can be run in a secure environment for testing purposes.

## Goldeneye

Goldeneye is a tool, created by Jan Seidl in 2012, that “looks” at a target site and reports if an exploit could be used. The tool tests sites for “HTTP Keep Alive” and “NoCache” function vulnerabilities. The results of this tool will show whether the target web server is vulnerable.

To install and test Goldeneye, run the following commands in a terminal:

```
apt-get install goldeneye
goldeneye -h
goldeneye http://192.168.86.38:443/ -s 10 –m random
```

## thc-ssl-dos

thc-ssl-dos is a tool, created by The Hacker’s Choice (THC) in 2011, that uses SSL to perform DoS attacks. This tool is popular because it doesn’t need multiple devices or tons of bandwidth. thc-ssl-dos can take down a server with just one computer. It takes advantage of the overhead of an SSL connection to overload a server.

To install and test thc-ssl-dos, run the following commands in a terminal:

```
apt-get install thc-ssl-dos
thc-ssl-dos -h
thc-ssl-dos –l 100 192.168.86.38 443 --accept
```

## Disclaimer

Please note that these tools are for testing purposes only and should not be used for illegal activities. Misuse of these tools could result in legal consequences. Use at your own risk.
