# macavalltestswa5601

A no-framework static web app deployed to Azure Static Web Apps with a managed
.NET 10 (isolated worker) Azure Functions API.

## Structure

- `src/` — static front end (HTML/CSS/JS, no framework)
- `api/` — managed .NET 10 isolated Functions API
  - `GET /api/timestamp` returns the current UTC server timestamp

## Local development

```powershell
# Run the API
cd api
func start
```

Open `src/index.html` (or serve `src/` with any static server) and the page
fetches `/api/timestamp`.

## Deployment

Deployed via GitHub Actions to Azure Static Web App `macavalltestswa5601`
(resource group `testswa5611rg`). Pushing to the `main` branch builds and
deploys automatically.
