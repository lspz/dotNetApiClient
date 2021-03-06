﻿using IndependentReserve.DotNetClientApi.Data;
using NUnit.Framework;

namespace UnitTest
{
    partial class PublicClientFixture
    {
        [Test]
        public void GetOrderBook()
        {
            using (var client = CreatePublicClient())
            {
                var orderBook = client.GetOrderBook(CurrencyCode.Xbt, CurrencyCode.Usd);

                Assert.IsNotNull(orderBook);
            }
        }
    }
}
