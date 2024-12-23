using Microsoft.Extensions.DependencyInjection;
using Soenneker.Stripe.Customers.Registrars;
using Soenneker.Stripe.PaymentIntents.Registrars;
using Soenneker.Stripe.PaymentMethods.Registrars;
using Soenneker.Stripe.Subscriptions.Registrars;

namespace Soenneker.Stripe.Suite.Registrars;

/// <summary>
/// A comprehensive suite of utility libraries for Stripe
/// </summary>
public static class StripeSuiteRegistrar
{
    public static IServiceCollection AddStripeSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddStripeCustomersUtilAsSingleton();
        services.AddStripePaymentIntentsUtilAsSingleton();
        services.AddStripePaymentMethodsUtilAsSingleton();
        services.AddStripeSubscriptionsUtilAsSingleton();

        return services;
    }

    public static IServiceCollection AddStripeSuiteAsScoped(this IServiceCollection services)
    {
        services.AddStripeCustomersUtilAsScoped();
        services.AddStripePaymentIntentsUtilAsScoped();
        services.AddStripePaymentMethodsUtilAsScoped();
        services.AddStripeSubscriptionsUtilAsScoped();

        return services;
    }
}
