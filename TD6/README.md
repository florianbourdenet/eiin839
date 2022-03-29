# TD6 - Rendu

## Partie SOAP

- Lancer le serveur SOAP [ici](./WCF_SOAP).
- Lancer la solution de test présente dans le client SOAP [ici](./WCF_SOAP).

## Partie REST

- Lancer le serveur REST dans le dossier WCF_REST

### Endpoints GET

Sur Postman, faire une requête GET sur les endpoints suivants :

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

Sur Postman, mettre dans le corps de la requête les paramètres ci-dessous :

```json
{
    "a": 20,
    "b": 20
}
```

Puis faire une requête POST sur les endpoints suivants :

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
