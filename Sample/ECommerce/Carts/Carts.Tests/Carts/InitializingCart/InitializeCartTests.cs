using System;
using Carts.ShoppingCarts;
using Carts.Tests.Extensions.Reservations;
using Xunit;

namespace Carts.Tests.Carts.InitializingCart;

public class InitializeCartTests
{
    [Fact]
    public void ForValidParams_ShouldCreateCartWithPendingStatus()
    {
        // Given
        var cartId = Guid.NewGuid();
        var clientId = Guid.NewGuid();

        // When
        var cart = ShoppingCart.Initialize(
            cartId,
            clientId
        );

        // Then

        cart
            .IsInitializedCartWith(
                cartId,
                clientId
            )
            .HasCartInitializedEventWith(
                cartId,
                clientId
            );
    }
}