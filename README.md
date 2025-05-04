<p align="center">
  <img src="https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png" height="80" alt="Soenneker logo" />
</p>

<h1 align="center">Soenneker.Stripe.Suite</h1>

<p align="center"><strong>A comprehensive suite of Stripe utility libraries for .NET — built for clarity, flexibility, and scalability.</strong></p>

<p align="center">
  <a href="https://www.nuget.org/packages/soenneker.stripe.suite/">
    <img src="https://img.shields.io/nuget/v/soenneker.stripe.suite.svg?style=for-the-badge" alt="NuGet version" />
  </a>
  <a href="https://github.com/soenneker/soenneker.stripe.suite/actions/workflows/publish-package.yml">
    <img src="https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.suite/publish-package.yml?style=for-the-badge" alt="Build status" />
  </a>
  <a href="https://www.nuget.org/packages/soenneker.stripe.suite/">
    <img src="https://img.shields.io/nuget/dt/soenneker.stripe.suite.svg?style=for-the-badge" alt="NuGet downloads" />
  </a>
</p>

---

## 📦 Overview

This package aggregates the core Soenneker Stripe utilities into a single unified registration entry point — enabling fast and clean integration for applications needing customer management, subscriptions, usage billing, saved payment methods, and secure off-session payments.

---

## 🧩 Included Utilities

| Utility (GitHub) | NuGet | Description |
|------------------|-------|-------------|
| [Soenneker.Stripe.Customers](https://github.com/soenneker/soenneker.stripe.customers) | [![NuGet](https://img.shields.io/nuget/v/Soenneker.Stripe.Customers.svg)](https://www.nuget.org/packages/Soenneker.Stripe.Customers) | Manage Stripe customers with strong abstractions |
| [Soenneker.Stripe.PaymentIntents](https://github.com/soenneker/soenneker.stripe.paymentintents) | [![NuGet](https://img.shields.io/nuget/v/Soenneker.Stripe.PaymentIntents.svg)](https://www.nuget.org/packages/Soenneker.Stripe.PaymentIntents) | Create, confirm, capture, and cancel PaymentIntents |
| [Soenneker.Stripe.PaymentMethods](https://github.com/soenneker/soenneker.stripe.paymentmethods) | [![NuGet](https://img.shields.io/nuget/v/Soenneker.Stripe.PaymentMethods.svg)](https://www.nuget.org/packages/Soenneker.Stripe.PaymentMethods) | List, delete, and manage customer payment methods |
| [Soenneker.Stripe.Subscriptions](https://github.com/soenneker/soenneker.stripe.subscriptions) | [![NuGet](https://img.shields.io/nuget/v/Soenneker.Stripe.Subscriptions.svg)](https://www.nuget.org/packages/Soenneker.Stripe.Subscriptions) | Full subscription lifecycle support, including proration, metadata, and billing anchors |
| [Soenneker.Stripe.SetupIntents](https://github.com/soenneker/soenneker.stripe.setupintents) | [![NuGet](https://img.shields.io/nuget/v/Soenneker.Stripe.SetupIntents.svg)](https://www.nuget.org/packages/Soenneker.Stripe.SetupIntents) | Save and validate payment methods for future off-session billing, including mandate and 3DS support |

---

## 🚀 Installation

```bash
dotnet add package Soenneker.Stripe.Suite
````

---

## 🛠️ Usage

Register all Stripe utilities in your application:

```csharp
using Microsoft.Extensions.DependencyInjection;
using Soenneker.Stripe.Suite.Registrars;

public void ConfigureServices(IServiceCollection services)
{
    services.AddStripeSuiteAsSingleton(); // Or .AddStripeSuiteAsScoped()
}
```

---

## 🔒 Security and Compliance

All utilities are designed to comply with:

* 🔐 [Strong Customer Authentication (SCA)](https://stripe.com/docs/strong-customer-authentication)
* 🕒 Off-session billing flows
* ✅ 3D Secure
* 🔁 Idempotent retries
* 🧾 Mandate agreements for bank debits and recurring charges

---

## 📚 Documentation

Each utility is:

* ✅ Fully XML-commented
* 🧪 Designed for testability via interfaces
* 🔗 Individually documented in its own GitHub repository