# Bengts snickeri

## Beskrivning
Den här applikationen är en enkel webbapplikation byggd med ASP.NET MVC för att visa upp Bengts skapelser. För att köra programmet så laddar du ner projektet på din dator. Sedan öppnar du det med Visual Studio eller Visual Studio Code. För att sedan starta programmet öppnar du terminalen och kör det med hjälp av dotnet run.

### Funktioner
- Kontaktinformation finns på en egen sida (`/About/Info`).
- Lista över produkter visas på en egen sida (`/Product/Index`).

## Struktur
- `Models/Product.cs` Här står det vad produkterna ska innehålla.
- `Controllers`: Innehåller olika kontroller för sidorna About, product och home.
- `Views`: Innehåller bootstrap, html och logik för att visa Landningssida, produktsida och kontaktsida.

### Produkter
- Produkterna är skapade i en hårdkodad lista som finns i `ProductController`. Genom att göra såhär så ska det vara enkelt att byta ut dessa med en lista från en databas istället.

## Utveckling i framtiden
- Dynamiskt innehåll via en databas.
- Möjlighet för användare att göra beställningar.
