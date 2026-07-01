# macavalltestswa5601

A no-framework static web app deployed to Azure Static Web Apps with a managed
.NET (isolated worker) Azure Functions API.

> Note: Azure Static Web Apps managed functions currently support .NET isolated
> 8.0 and 9.0 only. .NET 10 is not yet a supported managed runtime, so the API
> targets .NET 9 (isolated) — the newest version SWA managed functions accept.

## Structure

- `src/` — static front end (HTML/CSS/JS, no framework)
- `api/` — managed .NET 9 isolated Functions API
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
