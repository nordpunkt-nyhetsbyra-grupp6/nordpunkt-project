# Nordpunkt Nyhetsbyrå

> Utkast.

Nyhetssajt för Nordpunkt Nyhetsbyrå, byggd i Umbraco. Redaktörer skapar och publicerar artiklar i backoffice. Besökare läser nyheter och kan tipsa redaktionen via ett formulär.

Grupp 6, CMS-kursen (WIN25).

## Teknik

- Umbraco 18.2.1, .NET 10
- uSync 18.1.5
- Databas: TODO

## Kör lokalt

```bash
git clone https://github.com/nordpunkt-nyhetsbyra-grupp6/nordpunkt-project.git
cd nordpunkt-project
dotnet run --project src/Nordpunkt.Web
```

Första gången: följ installationsguiden och skapa en lokal admin-användare. Importera sedan via **Settings → uSync → Import**.

## TODO

- Innehållsmodell (Document Types)
- Användarroller
- Tipsformulär
