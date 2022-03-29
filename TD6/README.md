# TD6 - Rendu

## Partie SOAP

### Utilisation

- Lancer le serveur SOAP [ici](./WCF_SOAP).
- Lancer la solution de test présente dans le client SOAP [ici](./WCF_SOAP_CLIENT).

## Partie REST

### Utilisation

- Lancer le serveur REST [ici](./WCF_REST).
- Tester les endpoints.

#### Endpoints GET

Sur Postman, faire une requête GET sur les endpoints suivants :

##### Add

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

Sur Postman, mettre les paramètres ci-dessous dans le corps de la requête :

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

## Partie BONUS

4/ Optional. Try different ResponseFormat and BodyStyle to compare the results you get.

- ResponseFormat : par défaut, la réponse est donnée en XML. Cependant, lorsque le paramètre `WebMessageFormat.Json` est donné, la réponse devient du JSON.

5/ Optional. Change the method of one of the OperationContract to POST. It will not work directly with your browser since typing an URL is a GET request, but you should be able to communicate with the server by using Postman.

cf la partie Endpoints POST

