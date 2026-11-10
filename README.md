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

## Användarroller

Vi använder Umbracos inbyggda användargrupper:

| Grupp | Användning |
|---|---|
| Administrators | Administrerar webbplatsen, inställningar och användare. |
| Editors | Redaktörer som skapar, redigerar, publicerar och avpublicerar artiklar. Saknar åtkomst till Settings och Users. |

### Skapa en lokal redaktörsanvändare

1. Logga in som administratör.
2. Öppna Users och skapa en separat användare.
3. Tilldela användaren endast gruppen Editors.
4. Slutför skapandet och ange ett lösenord.

Användare lagras lokalt (ej Git eller uSync).

### Kontrollera behörigheterna

Logga in som redaktören i ett privat webbläsarfönster:

- Öppna en kategori under Home och kontrollera artikelöverblicken.
- Kontrollera att publicerade och opublicerade artiklar går att skilja åt.
- Öppna en artikel från överblicken.
- Skapa en testartikel och spara den som utkast.
- Publicera och avpublicera testartikeln.
- Kontrollera att Settings och Users inte är tillgängliga.

Relaterade user stories: #23 (US-11) och #25 (US-17).

## TODO

- Innehållsmodell (Document Types)
- Tipsformulär
