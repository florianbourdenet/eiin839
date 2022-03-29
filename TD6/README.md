# TD6 - Rendu

## Pour tester le serveur SOAP

- Lancer le serveur SOAP dans le dossier WCF_SOAP
- Lancer le client SOAP dans le dossier WCF_SOAP_CLIENT

## Pour tester le serveur REST

- Lancer le serveur REST dans le dossier WCF_REST

### Endpoints GET

#### Add

```
http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/add?a=20&b=20
```

#### Substract

```
http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/substract?a=20&b=20
```

#### Multiply

```
http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/multiply?a=20&b=20
```

#### Divide

```
http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/divide?a=20&b=20
```


### Endpoints POST

```json
{
    "a": 20,
    "b": 20
}
```

#### Add

```
http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/add
```

#### Substract

```
http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/substract
```

#### Multiply

```
http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/multiply
```

#### Divide

```
http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/divide
```