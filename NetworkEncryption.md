# Network Encryption

Data encryption is important for securely storing data, but how do we protect data as it traverses networks? Network encryption is necessary to keep this data confidential. This project covers cryptography standards at the application, network, and link layers.

## Cryptography at the Application Layer

Cryptography at the application layer involves email and end-to-end encryption. Email encryption is used to securely transport emails. PEM (Privacy-Enhanced Mail) was developed during the 1920s as the model for end-to-end email encryption. It used RSA public keys to distribute the message encrypting key.

Modern systems tend to use end-to-end encryption. Many devices and applications rely on end-to-end encryption to automatically control key management. In enterprise scenarios, it is likely up to the IT department to cover key management. Secure communication is vital to avoid leaks or worse issues regarding confidential information. The same goes for online commerce. One such security mechanism is called Secure Sockets Layer (SSL). This protocol secures client/server data streams within an SSL Session.

## Cryptography at the Network Layer

Cryptography at the network layer is useful for protecting data and routing packets through the internet. One particular standard called PPP or Point-to-Point Protocol was developed in the 1980s. It allowed connections to be protected cryptographically.

Eventually in the 1990s, IPsec was developed. This protocol solved many problems that PPP could not. IPsec has two main components for protecting data; the Authentication Header (AH) and the Encapsulating Security Payload (ESP). IPsec is commonly used within a Virtual Private Network (VPN). VPNs provide secure point-to-point connections across separate locations.

## Cryptography at the Link Layer

Wireless security offers another way to secure information at the link layer. This does not necessarily protect data that travels to another network, however, it does protect the current network from outside access.

WEP or Wired Equivalent Privacy was of the first methods of securing wireless access. The weak security was due to the usage of the RC4 cipher. Later, WEP was replaced by WPA or Wireless Protected Access. WPA used a stronger encryption algorithm known as TKIP (Temporal Key Integrity Protocol).

The current standard for wireless security is WPA2. It uses the Advanced Encryption Standard (AES) algorithm which provides stronger encryption. It also includes features such as CCMP (Counter Mode with Cipher Block Chaining Message Authentication Code Protocol) for data integrity and EAP (Extensible Authentication Protocol) for authentication.

## Conclusion

Cryptography at the application, network, and link layers play an important role in securing data as it traverses networks. It is important to understand the different protocols and standards in order to properly secure data and prevent against potential attacks.
