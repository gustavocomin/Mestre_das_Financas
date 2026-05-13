# Mestre das Finanças

> Personal finance intelligence engine — NF-e receipt parsing, multi-source expense aggregation,
> item-level spending history, and financial analytics. Backend companion to
> [ConversorFaturas](https://github.com/gustavocomin/ConversorFaturas).

---

## What it does

Most personal finance tools track transactions at the bank level — you see "Supermercado R$320"
but not *what* you bought. Mestre das Finanças goes further: it parses Brazilian NF-e fiscal
receipts (notas fiscais) and supermarket purchase receipts at the item level, building a
longitudinal history of what you actually spend money on.

Combined with bank statement data from [ConversorFaturas](https://github.com/gustavocomin/ConversorFaturas),
it produces a full picture of personal finances — from raw bank transactions down to individual
grocery items.

---

## Core capabilities

**NF-e / receipt parsing**
Reads Brazilian electronic fiscal receipts (NF-e) and supermarket receipts, extracting individual
line items, quantities, unit prices, and totals — not just the aggregate transaction value.

**Item-level spending history**
Tracks purchase history per product across time, enabling queries like:
- "How much did I spend on this item over the last 6 months?"
- "Which store has the best price for this product?"
- "What's my average monthly spend on groceries by category?"

**Expense aggregation**
Consolidates transactions from multiple sources (bank statements via ConversorFaturas + fiscal
receipts) into a unified spending model, with deduplication and source tagging.

**Financial analytics**
Calculates spending totals, trends, and breakdowns by period, category, merchant, and item —
providing the data layer for a planned AI financial assistant.

---

## Architecture

```
┌────────────────────────────────────────────────────────┐
│                    Data Sources                         │
│  Bank statements (via ConversorFaturas)                 │
│  NF-e XML / fiscal receipts / supermarket receipts      │
└───────────────────┬────────────────────────────────────┘
                    │
                    ▼
┌────────────────────────────────────────────────────────┐
│                  Ingestion Layer                        │
│  NF-e parser · Receipt parser · Bank data adapter      │
└───────────────────┬────────────────────────────────────┘
                    │
                    ▼
┌────────────────────────────────────────────────────────┐
│                  Domain Layer                           │
│  Transaction · LineItem · Product · Merchant           │
│  SpendingPeriod · Category · PriceHistory              │
└───────────────────┬────────────────────────────────────┘
                    │
                    ▼
┌────────────────────────────────────────────────────────┐
│               Analytics / Application                   │
│  Spending summaries · Item history · Trend calculation  │
└───────────────────┬────────────────────────────────────┘
                    │
                    ▼
┌────────────────────────────────────────────────────────┐
│                  Persistence                            │
│  SQL Server · Entity Framework Core · Repository       │
└────────────────────────────────────────────────────────┘
                    │
                    ▼
           [Planned] AI assistant layer
           Natural language queries over spending history
```

**Key patterns:** Clean Architecture · DDD · Repository · Strategy (per-source parsers)

---

## Tech stack

- **Runtime:** C# .NET / ASP.NET Core
- **ORM:** Entity Framework Core
- **Database:** SQL Server
- **Architecture:** Clean Architecture, DDD, SOLID
- **Parsing:** NF-e XML processing, CSV/text receipt extraction

---

## Ecosystem

This project is part of a two-repo personal finance backend:

| Repo | Role |
|---|---|
| [ConversorFaturas](https://github.com/gustavocomin/ConversorFaturas) | Bank statement ingestion — reads Itaú, Nubank, Inter, Mercado Pago exports and normalizes into a unified transaction model |
| **Mestre das Finanças** | Financial intelligence — NF-e parsing, item-level history, spending analytics |

Together they form the data backend for a planned AI-powered personal finance assistant.

---

## Roadmap

- [x] NF-e / fiscal receipt parsing
- [x] Item-level purchase history
- [x] Expense aggregation and deduplication
- [x] Spending analytics by period, category, and merchant
- [x] Integration with ConversorFaturas bank transaction data
- [ ] REST API layer
- [ ] Transaction categorization (ML-assisted)
- [ ] OpenAI integration — natural language financial queries
- [ ] Price tracking across merchants over time
