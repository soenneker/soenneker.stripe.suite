[![](https://img.shields.io/nuget/v/soenneker.stripe.suite.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.suite/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.suite/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.stripe.suite.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.stripe.suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.stripe.suite/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.stripe.suite/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Stripe.Suite

Install and register the Soenneker Stripe customer, payment, setup-intent, invoice-item, and subscription libraries as one package.

## Included packages

- `Soenneker.Stripe.Customers`
- `Soenneker.Stripe.InvoiceItems`
- `Soenneker.Stripe.PaymentIntents`
- `Soenneker.Stripe.PaymentMethods`
- `Soenneker.Stripe.SetupIntents`
- `Soenneker.Stripe.SubscriptionItems`
- `Soenneker.Stripe.Subscriptions`

## Installation

```bash
dotnet add package Soenneker.Stripe.Suite
```

## Configuration

```json
{
  "Stripe": {
    "SecretKey": "sk_test_..."
  }
}
```

## Usage

```csharp
using Soenneker.Stripe.Customers.Abstract;
using Soenneker.Stripe.PaymentIntents.Abstract;
using Soenneker.Stripe.Suite.Registrars;

services.AddStripeSuiteAsScoped();

Stripe.Customer? customer = await stripeCustomersUtil.Create(
    email: "customer@example.com",
    name: "Example Customer",
    userId: applicationUserId,
    cancellationToken: cancellationToken);

Stripe.PaymentIntent intent = await stripePaymentIntentsUtil.Create(
    customer!.Id,
    amount: 49.95m,
    idempotencyKey: $"order-{orderId}",
    cancellationToken: cancellationToken);
```

`AddStripeSuiteAsScoped` creates scoped utility wrappers that all borrow the same singleton Stripe client. Disposing a scope releases those wrappers without tearing down the shared client. Use `AddStripeSuiteAsSingleton` when the utility wrappers should also live for the application lifetime.

This suite does not add behavior beyond its component packages. Refer to each package for operation-specific details, especially destructive and account-wide methods.
