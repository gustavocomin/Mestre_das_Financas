# Mestre das Finanças

> Personal-finance backend that goes one level deeper than typical expense trackers:
> it parses Brazilian NFC-e fiscal receipts at the **item** level, so you don't just
> see *"Supermarket R$ 320"* — you see every product, quantity, unit price, brand,
> and discount.

Built in **C# / .NET 7** with a layered Clean-Architecture / DDD-light style and a
PostgreSQL backing store.

---

## What the application does

Most personal-finance tools stop at the bank transaction. **Mestre das Finanças**
keeps going:

- Reads the **NFC-e** (Nota Fiscal de Consumidor Eletrônica) consultation page of
  Brazilian state tax authorities, scrapes the HTML, and extracts every line item
  of a supermarket receipt — sequence, description, quantity, unit, unit price,
  total, and discounts.
- Persists those items into a normalized model: a **Compra** (purchase) is the
  aggregate root, owning many **ItemCompra** records, each optionally tied to a
  **DescontoItem** (discount) and a global **Item** + **MarcaItem** (product +
  brand) catalog.
- Auto-creates the **Empresa** (vendor) record from the receipt's CNPJ and the
  **Item** catalog entries for any products not seen before, so the catalog grows
  on its own as you import receipts.
- Tracks the broader monthly picture alongside the receipts:
  - **Despesa** — expenses categorized as `Moradia`, `Transporte`,
    `Entretenimento`, `Investimentos`, `Animais`, `Pessoais`, `Mercado`,
    `Outros`, with optional date ranges and monthly-recurring flag.
  - **Renda** — income (with a `Salario` flag and link to vendor/consumer).
  - **Meta** + **MetaItem** — savings goals, with auto-calculated *monthly
    amount to save* based on target date and reserve already accumulated.
- Provides a user-management layer (**Usuario** + **Consumidor**) with email
  uniqueness validation and SMTP-based password recovery via a DB-stored
  **EmailProvider** credential.

The longer-term vision is a unified personal-finance data backend for an
AI-powered assistant — but today the codebase is focused on the ingestion +
domain model, not the analytics or AI layer.

---

## Tech stack

| Layer | Choice |
|---|---|
| Runtime | **.NET 7** / ASP.NET Core Web API |
| ORM | **Entity Framework Core 7** |
| Database | **PostgreSQL** (`Npgsql.EntityFrameworkCore.PostgreSQL` 7.0.3) |
| API docs | Swashbuckle / Swagger + XML doc comments |
| HTML scraping | **HtmlAgilityPack** (NFC-e page parsing) |
| Email | `System.Net.Mail` (active) + **MailKit** (referenced) |
| Auth (scaffolded, not active) | `Microsoft.AspNetCore.Authentication.JwtBearer`, `System.IdentityModel.Tokens.Jwt` |
| OData (referenced, not wired) | `Microsoft.AspNetCore.OData` |

---

## Architecture

The solution is split into five projects under [MF/](MF/), following a
Clean-Architecture / DDD-light layering:

```
┌──────────────────────────────────────────────────────────────┐
│  MF.Api  —  HTTP entry point                                  │
│  Controllers · Program.cs · DI wiring · Swagger · appsettings │
└────────────────────────┬─────────────────────────────────────┘
                         │ depends on
                         ▼
┌──────────────────────────────────────────────────────────────┐
│  MF.Application  —  Use cases / orchestration                 │
│  AplicXxx services · NFCE import flow · email recovery        │
└────────────────────────┬─────────────────────────────────────┘
                         │ depends on
                         ▼
┌──────────────────────────────────────────────────────────────┐
│  MF.Domain  —  Entities · DTOs · Views · Repo interfaces      │
│  Compra · ItemCompra · Despesa · Renda · Meta · Usuario · ... │
│  Base classes: IdBase, IdBaseDtAlt (auto DataAlteracao)       │
└──────────────────────────────────────────────────────────────┘
                         ▲                          ▲
                         │ implements               │ implements
                         │                          │
┌────────────────────────┴────────────────┐   ┌─────┴───────────────────┐
│  MF.Repository  —  EF Core persistence  │   │  MF.infrastructure       │
│  Rep<T> base · per-entity Reps · Fluent │   │  AuthenticationService   │
│  configs · Migrations · DataContext     │   │  (JWT — currently unused)│
└──────────────────────────────────────────┘   └──────────────────────────┘
                         │
                         ▼
                 ┌───────────────┐
                 │  PostgreSQL   │
                 └───────────────┘
```

**Patterns in use**

- **Clean Architecture / Onion** — `Api → Application → Domain ← Repository / Infrastructure`. The domain has no outbound dependencies.
- **Repository pattern** — a generic [`Rep<T>`](MF/MF.Repository/Commons/Rep.cs) implementing [`IRep<T>`](MF/MF.Domain/Commons/IRep.cs) provides `FindAll / FindById / SaveChanges / Delete`. Specific repos extend it for entity-specific queries (e.g. [`RepEmpresa.BuscarEmpresaPorNomeOuCNPJ`](MF/MF.Repository/Data/Commons/Empresas/RepEmpresa.cs)).
- **DTO / View segregation** — every aggregate has a `XxxDto` (inbound, write) and `XxxView` (outbound, read). Controllers never expose entities directly.
- **Aggregate root with encapsulated calculations** — `Compra.AtualizaCalculos()` recomputes totals from its `Itens`; `MetaItem` recomputes *amount to save per month* from target date and reserve. Calculated fields use `private set`.
- **Template-method base entity** — [`IdBaseDtAlt`](MF/MF.Domain/Commons/ClassesBase/IdBaseDtAlt.cs) uses reflection to keep `DataAlteracao` fresh on instantiation.
- **EF Core Fluent API per entity** — every entity has a matching `XxxConfig : IEntityTypeConfiguration<T>` under [MF/MF.Repository/Data/](MF/MF.Repository/Data/), auto-applied via `modelBuilder.ApplyConfigurationsFromAssembly`.
- **Transactional import** — `AplicCompra.MapearDadosNFCE` runs inside a `TransactionScope` so a partially-parsed receipt rolls back as one unit.

---

## Folder structure

```
Mestre_das_Financas/
└── MF/
    ├── MF.sln
    │
    ├── MF.Api/                        ← ASP.NET Core entry point
    │   ├── Program.cs                 ← DI registration, Swagger, EF setup
    │   ├── appsettings.json           ← Connection string, JWT secret
    │   └── Controllers/
    │       ├── Commons/
    │       │   ├── Consumirdores/     ← ConsumidorController
    │       │   ├── Empresas/          ← EmpresaController
    │       │   ├── ModalidadePagto/
    │       │   │   └── CondPagtos/    ← CondPagtoController, Parcs/
    │       │   └── Usuarios/          ← UsuarioController (signup, password reset)
    │       └── ControleMensal/
    │           └── Mercado/
    │               ├── Compras/       ← CompraController (CRUD + NFC-e import)
    │               └── Itens/         ← ItemCompraController
    │
    ├── MF.Application/                ← Use cases (AplicXxx services)
    │   ├── Commons/                   ← Consumidor, Empresa, ModalidadePagto, Usuario
    │   ├── ControleMensal/            ← Despesa, Renda, Mercado.Compras (NFC-e import)
    │   └── Planejamento/              ← Meta, MetaItem
    │
    ├── MF.Domain/                     ← Entities + interfaces (no dependencies out)
    │   ├── Commons/
    │   │   ├── ClassesBase/           ← IdBase, IdBaseDtAlt
    │   │   ├── Consumirdores/         ← Consumidor + Dto/View
    │   │   ├── Empresas/              ← Empresa + Dto/View
    │   │   ├── ModalidadePagto/
    │   │   │   ├── CondPagtos/        ← CondPagto + Parcs (installments)
    │   │   │   └── FormaPagtos/       ← FormaPagto (payment method)
    │   │   ├── Usuarios/              ← Usuario, Email/, Validacoes/
    │   │   └── Functions/             ← CommonFunctions (string sanitizing)
    │   ├── ControleMensal/
    │   │   ├── Despesas/              ← Despesa + TipoDespesa enum
    │   │   ├── Rendas/                ← Renda
    │   │   └── Mercado/
    │   │       ├── Compras/           ← Compra aggregate
    │   │       │   └── Itens/         ← ItemCompra, Desconto/
    │   │       └── Itens/             ← Item catalog, MarcaItens/
    │   ├── Planejamento/              ← Meta + MetaItem (savings goals)
    │   └── Configuration/             ← IAuthenticationService
    │
    ├── MF.Repository/                 ← EF Core implementations
    │   ├── Commons/                   ← Generic Rep<T>
    │   ├── Configurations/Db/         ← DataContext (DbContext)
    │   ├── Data/                      ← Per-entity Repo + EntityTypeConfig
    │   └── Migrations/                ← EF migrations (Apr–May 2023)
    │
    └── MF.infrastructure/             ← Cross-cutting infra
        └── Configuration/             ← AuthenticationService (JWT, not yet wired)
```

A note on naming: the domain is in **Portuguese** because the fiscal data it
ingests (NFC-e, CNPJ, CCF, COO) is Portuguese, and the model fields map 1:1 to
Brazilian fiscal terminology. There's also a typo carried through the tree —
`Consumirdores` should be `Consumidores` — preserved as-is to keep the existing
migrations valid.

---

## What's working today

**Ingestion**
- [x] NFC-e import: scrapes the SEFAZ-SC consultation HTML, parses header, vendor (CNPJ + name), and full line-item table.
- [x] Auto-creation of `Empresa` records from the receipt's CNPJ (with sanitized characters).
- [x] Auto-creation of `Item` catalog entries for previously unseen product descriptions.
- [x] Per-item fields: sequence, description, quantity, unit (`KG` / `UN`), unit price, total.
- [x] Transactional import — the whole NFC-e ingestion rolls back as one unit on failure.

**Domain model + CRUD**
- [x] Full CRUD on `Compra` and `ItemCompra` (purchases + line items) — controllers wired.
- [x] Full CRUD on `Empresa`, `Consumidor`, `Usuario`, `CondPagto`, `CondPagtoParcs` — controllers wired.
- [x] User signup with login + email uniqueness validation.
- [x] Password-recovery flow: SMTP send via DB-stored `EmailProvider` credentials.
- [x] Aggregate calculations: `Compra` total = items − discounts + taxes; `MetaItem` monthly savings = remaining / months-until-target.
- [x] EF Core fluent-API configurations for every entity; migrations checked in.

**Infrastructure**
- [x] PostgreSQL connection (default: `localhost:5433`, db `MF`).
- [x] Swagger UI in Development with XML doc comments.
- [x] Generic repository contract `IRep<T>` + base `Rep<T>`.

---

## What's scaffolded but not yet active

These show up in the code but are not currently wired into the running app:

- [ ] **JWT authentication** — [`AuthenticationService`](MF/MF.infrastructure/Configuration/AuthenticationService.cs) is fully implemented and `JwtConfigurations:Secret` is in `appsettings.json`, but every `AddAuthentication` / `AddJwtBearer` / `AddScoped<IAuthenticationService, …>` line in [`Program.cs`](MF/MF.Api/Program.cs) is commented out, and every controller is annotated `[AllowAnonymous]`. No login endpoint exists yet.
- [ ] **OData** — `Microsoft.AspNetCore.OData` is referenced in the API project but not registered.
- [ ] **Domain folders with no controller yet** — `Controllers/ControleMensal/Despesas/`, `Rendas/`, `Mercado/Compras/Itens/Desconto/`, `Mercado/Itens/MarcaItens/Hist/`, `Planejamento/Itens/` exist as empty folders in the csproj. The `MF.Application` services (`AplicDespesa`, `AplicRenda`, `AplicMeta`, `AplicMetaItem`, `AplicItem`, `AplicMarcaItem`, `AplicDescontoItem`, `AplicFormaPagto`) are written; only the HTTP controllers are missing.

---

## Roadmap

**Short term — finish the existing surface**
- [ ] Wire JWT authentication end-to-end (add login endpoint, uncomment the JWT pipeline, switch `[AllowAnonymous]` → role-based authorization).
- [ ] Hash user passwords (currently stored plain-text in `Usuario.Senha`).
- [ ] Add the missing HTTP controllers for `Despesa`, `Renda`, `Meta`, `MetaItem`, `Item`, `MarcaItem`, `DescontoItem`, `FormaPagto` — the application services already exist.
- [ ] Make NFC-e import URL-driven — the current `ImportarNFCEAsync` overwrites the `url` parameter with a hardcoded test URL.
- [ ] Remove the hard-coded Windows absolute path in [`DataContext.OnConfiguring`](MF/MF.Repository/Configurations/Db/DataContext.cs).

**Medium term — analytics**
- [ ] Spending summaries by period / category / vendor / item.
- [ ] Per-item price history across vendors over time (the data model already supports it).
- [ ] Monthly cash-flow view combining `Renda` − `Despesa` − `Compra`.
- [ ] OData endpoints for ad-hoc client-side queries (package is already referenced).

**Longer term — assistant layer**
- [ ] Bank-statement ingestion (e.g. integration with [ConversorFaturas](https://github.com/gustavocomin/ConversorFaturas)) to unify card/bank data with item-level receipts.
- [ ] ML-assisted transaction categorization for `Despesa.TipoDespesa`.
- [ ] LLM-backed natural-language query layer over the spending history.
- [ ] Frontend / mobile client.

---

## Running locally

Requirements: .NET 7 SDK, PostgreSQL running on `localhost:5433` with a `MF` database (or change [`appsettings.json`](MF/MF.Api/appsettings.json)).

```bash
cd MF
dotnet restore
dotnet ef database update --project MF.Repository --startup-project MF.Api
dotnet run --project MF.Api
```

Then open `https://localhost:<port>/swagger` for the API explorer.
