VerdeelStation PoC
==

Dit project bevat een combinatie van nginx en een C# project. Nginx stuurt de binnenkomende verzoeken door
naar de C# engine. Als zal vervolgens aangeven of de url geredirect of geproxyd moet worden, en nginx zal het vervolgens
op die manier afhandelen.

Opstarten:
-

```sh
docker-compose up --build
```

Testen:
-
```sh
curl -i http://localhost:4500/redirect
curl -i http://localhost:4500/proxy
```
